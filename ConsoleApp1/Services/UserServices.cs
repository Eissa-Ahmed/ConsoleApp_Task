using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BL.ModelVM;
using Task.BL.Repo;
using Task.DAL.Entity;

namespace Task.Services
{
    public class UserServices
    {
        UserRepo userRepo = new UserRepo();
        UserVM userVM = new UserVM();

        public void printUser(UserVM userVM)
        {
            Console.WriteLine($" FName: {userVM.FName},  LName: {userVM.LName}, Password: {userVM.Password},"); ;
        }
        public void getAllUsers()
        {
            var s = userRepo.getAllUser();

            foreach (var item in s)
            {
                Console.WriteLine($" FName: {item.FName},  LName: {item.LName}, Password: {item.Password},");
            }
        }
        public void createUser(UserVM userVM)
        {
            Users users = new Users()
            {
                FName = userVM.FName,
                LName = userVM.LName,
                Email = userVM.Email,
                Password = userVM.Password,
                IsDeleted = false,
            };
            userRepo.createUser(users);
        }
        public void createData()
        {
            Console.WriteLine("Hello");
            Console.Write("Enter First Name: ");
            userVM.FName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            userVM.LName = Console.ReadLine();
            Console.Write("Enter Email: ");
            userVM.Email = Console.ReadLine();
            Console.Write("Enter Password: ");
            userVM.Password = Console.ReadLine();
            createUser(userVM);
        }

        public void getUserById(int id)
        {
            Users user = userRepo.getUserById(id);
            UserVM usersVM = new UserVM()
            {
                FName = user.FName,
                LName = user.LName,
                Email = user.Email,
                Password = user.Password,
                IsDeleted = false,
            };
            printUser(usersVM);
        }

        public void deleteUser(int id)
        {
            userRepo.delete(id);
        }

        public void updateUser()
        {
            UserVM userVM1 = new UserVM();
            
            Console.Write("Enter Id: ");
            userVM1.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            userVM1.FName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            userVM1.LName = Console.ReadLine();
            Console.Write("Enter Email: ");
            userVM1.Email = Console.ReadLine();
            Console.Write("Enter Password: ");
            userVM1.Password = Console.ReadLine();
            printUser(userVM1);
            userRepo.updateUser(userVM1);
        }
    }
}
