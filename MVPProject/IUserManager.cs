using System.Collections.Generic;

namespace MVPProject
{
    internal interface IUserManager
    {
        List<IUser> Users { get; set; }

        void AddUser(IUser user);

        void RemoveUser(IUser user);

        IUser GetUserByIndex(int index);
    }
}