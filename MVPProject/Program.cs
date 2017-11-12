using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPProject
{
    class Program
    {
        static IUserManager userManager;

        static void Main(string[] args)
        {
            InitLogic();
            InitUsers();
            ShowUsers();

            Console.ReadKey();
        }

        static void InitLogic()
        {
            userManager = new UserManager();
        }

        static void InitUsers()
        {
            if (userManager == null)
                return;

            userManager.AddUser(new User() { Id = Guid.NewGuid(), Name = "Grisha", Age = 27 });
            userManager.AddUser(new User() { Id = Guid.NewGuid(), Name = "Dima", Age = 22 });
            userManager.AddUser(new User() { Id = Guid.NewGuid(), Name = "Gregor", Age = 26 });
            userManager.AddUser(new User() { Id = Guid.NewGuid(), Name = "Roma", Age = 20 });
        }

        static void ShowUsers()
        {
            if (userManager == null)
                return;

            Console.WriteLine("The list of users:");
            
            IUser userOne = userManager.GetUserByIndex(1);
            Console.WriteLine($"{userOne.Id} - {userOne.Name} - {userOne.Age}");

            IUser userTwo = userManager.GetUserByIndex(2);
            Console.WriteLine($"{userTwo.Id} - {userTwo.Name} - {userTwo.Age}");
        }
    }
}
