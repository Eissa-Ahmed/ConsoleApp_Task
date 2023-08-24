using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Services
{
    public class WelcomeServices
    {
        public void work()
        {
            int num;
            do
            {
                Console.WriteLine($"Hello\nClick 1 if You Want Work User\nClick 2 if You Want Work Post\nClick 3 if You Want Exist");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        UserServices userServices1 = new UserServices();
                        int num1;
                        do
                        {
                            Console.WriteLine($"Hello Click 1 if You Create User\nClick 2 if You Want Update User\nClick 3 if You Want Delete User\nClick 4 if You Want Exist");
                            num1 = int.Parse(Console.ReadLine());
                            switch (num1)
                            {
                                case 1:
                                    Console.Clear();
                                    userServices1.createData();
                                    break;
                                case 2:
                                    Console.Clear();
                                    userServices1.updateUser();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Enter Id User :");
                                    int id = int.Parse(Console.ReadLine());
                                    userServices1.deleteUser(id);
                                    break;
                                case 4:
                                    Console.Clear();
                                    break;
                            }
                        } while (num1 < 4);
                        break;
                    //------------------------
                    case 2:
                        Console.Clear();
                        PostServices postServices = new PostServices();
                        int num2;

                        do
                        {
                            Console.WriteLine($"Hello Click 1 if You Create Post\nClick 2 if You Want Update Post\nClick 3 if You Want Delete Post\nClick 4 if You Want Exist");
                            num2 = int.Parse(Console.ReadLine());
                            switch (num2)
                            {
                                case 1:
                                    Console.Clear();
                                    postServices.createData();
                                    break;
                                case 2:
                                    Console.Clear();
                                    postServices.updatePost();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Enter Id Post :");
                                    int id = int.Parse(Console.ReadLine());
                                    postServices.deletePost(id);
                                    break;
                                case 4:
                                    Console.Clear();
                                    //return;
                                    break;
                            }
                        } while (num2 < 4);
                        break;
                }
            } while (num < 3);
        }
    }
}
