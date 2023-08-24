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
    public class PostServices
    {
        PostsRepo postsRepo = new PostsRepo();

        public void printPost(PostsVM postsVM)
        {
            Console.WriteLine($" Body: {postsVM.Body}"); ;
        }
        public void getAllPosts()
        {
            var allPosts = postsRepo.getAllPosts();

            foreach (var item in allPosts)
            {
                Console.WriteLine($" Body: {item.Body} , User: {item.users.FName}");
            }
        }
        public void createPost(PostsVM postsVM)
        {
            postsRepo.createPost(postsVM);
        }
        public void createData()
        {
            PostsVM postsVM = new PostsVM();
            Console.WriteLine("Hello");
            Console.Write("Enter Body: ");
            postsVM.Body = Console.ReadLine();
            Console.Write("Enter User Id: ");
            postsVM.UserId = int.Parse(Console.ReadLine());
            createPost(postsVM);
            
        }

        public void getPostById(int id)
        {
            var post = postsRepo.getPostById(id);
            
            printPost(post);
        }

        public void deletePost(int id)
        {
            postsRepo.delete(id);
        }

        public void updatePost()
        {
            PostsVM postsVM =new PostsVM();
            Console.WriteLine("Enter Id :");
            postsVM.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Body :");
            postsVM.Body = Console.ReadLine();
            postsRepo.updatePost(postsVM);
        }
    }
}
