using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BL.ModelVM;
using Task.DAL.Entity;

namespace Task.BL.Interface
{
    public interface IUserRepo
    {
        List<Users> getAllUser(); 
        void createUser(Users user);
        Users getUserById(int id);

        void delete(int id);

        void updateUser(UserVM userVM);
    }
}
