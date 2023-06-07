using Books_shop.Data;
using Books_shop.Data.Interfaces;
using Books_shop.Data.Models;

namespace Books_shop.Data.Repository
{
    public class UserTypeRepository : GeneralRepository<UserType>, IUserType
    {
        public UserTypeRepository(AppDBContent dBContent) : base(dBContent)
        {
        }
    }
}