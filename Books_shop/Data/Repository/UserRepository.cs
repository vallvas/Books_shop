using Books_shop.Data;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using Books_shop.Data.Interfaces;
using Books_shop.Data.Models;
using Books_shop.Data.Models.Security;

using System;
using System.Linq;

namespace Books_shop.Data.Repository
{
    public class UserRepository : GeneralRepository<User>, IUser
    {

        public UserRepository(AppDBContent dBContent) : base(dBContent)
        {
        }

        public new void Add(User user)
        {
            user.CreatedAt = DateTime.Now;
            user.Password = Utils.Hash.GetMD5(user.Password);
            user.UserTypeId = 2;
            DBContent.User.Add(user);
            user.Type = new UserType() { Name = "Client" };
            DBContent.SaveChanges();
        }



        public User CheckLogin(Login user)
        {
            string hashPassword = Utils.Hash.GetMD5(user.Password);
            return DBContent.User.Where(u =>
                u.Password == hashPassword &&
                u.Email == user.Email
            ).FirstOrDefault();
        }

        public User CheckRegister(Register register)
        {
            return DBContent.User.Where(u =>
               u.Email == register.Email ||
               u.PhoneNumber == register.PhoneNumber
            ).FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return DBContent.User.Where(u =>
                 u.Email == email
            ).FirstOrDefault();
        }
    }
}