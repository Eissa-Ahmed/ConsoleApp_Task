using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BL.Interface;
using Task.BL.ModelVM;
using Task.DAL.DataBase;
using Task.DAL.Entity;

namespace Task.BL.Repo
{
    public class UserRepo : IUserRepo
    {
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();

        public void createUser(Users user)
        {
            try
            {
                applicationDbContext.users.Add(user);
                applicationDbContext.SaveChanges();
            }catch (Exception ex)
            {
                Console.WriteLine("====================");
                Console.WriteLine(ex.Message);
                Console.WriteLine("====================");
            }
        }

        public void delete(int id)
        {
            if (id != null && id != 0)
            {
               var user = applicationDbContext.users.Where(i => i.Id == id).FirstOrDefault();
                if (user != null)
                {
                    user.IsDeleted = true;
                    applicationDbContext.SaveChanges();
                }
            }
        }

        public List<Users> getAllUser()
        {
            var users = applicationDbContext.users.ToList();
            return users;
        }

        public Users getUserById(int id)
        {
            if (id != null && id != 0)
            {
                var user = applicationDbContext.users.Where(i => i.Id == id).FirstOrDefault();
                return user;
            }
            else
            {
                return null;
            }
        }

        public void updateUser(UserVM Newuser)
        {
            if (Newuser.Id != null && Newuser.Id != 0)
            {
                var OldUser = applicationDbContext.users.Where(i => i.Id == Newuser.Id).FirstOrDefault();
               
                if (Newuser != null)
                {
                    OldUser.FName = Newuser.FName;
                    OldUser.LName = Newuser.LName;
                    OldUser.Email = Newuser.Email;
                    OldUser.Password = Newuser.Password;
                    
                    applicationDbContext.SaveChanges();
                }
            }
        }
    }
}
