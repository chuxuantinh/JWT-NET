using JWTASPNetCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace JWTASPNetCore
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserDTO> users = new List<UserDTO>();
        public UserRepository()
        {
            users.Add(new UserDTO { UserName = "tinh1", Password = "t1", Role = "manager" });
            users.Add(new UserDTO { UserName = "tinh2", Password = "t2", Role = "developer" });
            users.Add(new UserDTO { UserName = "tinh3", Password = "t3", Role = "tester" });
            users.Add(new UserDTO { UserName = "t4", Password = "t4", Role = "admin" });
            users.Add(new UserDTO { UserName = "t5", Password = "t5", Role = "admin" });
        }
        public UserDTO GetUser(UserModel userModel)
        {
            return users.Where(x => x.UserName.ToLower() == userModel.UserName.ToLower()
                && x.Password == userModel.Password).FirstOrDefault();
        }
    }
}
