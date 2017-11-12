using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPProject
{
    class UserManager:IUserManager
    {
        public List<IUser> Users { get; set; }

        public UserManager()
        {
            Users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            Users.Add(user);
        }

        public void RemoveUser(IUser user)
        {
            Users.Remove(user);
        }

        public IUser GetUserByIndex(int index)
        {
            return Users[index];
        }
    }
}
