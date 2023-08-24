using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BL.ModelVM;
using Task.DAL.Entity;

namespace Task.BL.Interface
{
    public interface IPostRepo
    {
        List<Posts> getAllPosts();
        void createPost(Posts post);
        Posts getPostById(int id);

        void delete(int id);

        void updatePost(Posts posts);
    }
}
