using Microsoft.Win32;
using Books_shop.Data.Models;
using Books_shop.Data.Models.Security;

namespace Books_shop.Data.Interfaces
{
    public interface IUser : IGeneral<User>
    {
        public User CheckLogin(Login user);

        public User CheckRegister(Register register);

        public User GetUserByEmail(string email);


    }
}