using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BL.ModelVM;
using Task.DAL.DataBase;
using Task.DAL.Entity;

namespace Task.BL.Repo
{
    public class PostsRepo
    {
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();

        public void createPost(PostsVM postsVM)
        {
            Posts posts = new Posts()
            {
                Body = postsVM.Body,
                PublishingDate = DateTime.Now,
                UserId = postsVM.UserId,
                IsDeleted = false,
            };
            try
            {
                applicationDbContext.posts.Add(posts);
                applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
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
                var post = applicationDbContext.posts.Where(i => i.Id == id).FirstOrDefault();
                if (post != null)
                {
                    post.IsDeleted = true;
                    applicationDbContext.SaveChanges();
                }
            }
        }

        public List<Posts> getAllPosts()
        {
            var posts = applicationDbContext.posts.Where(p => p.IsDeleted == false).Include(a => a.users).ToList();
            return posts;
        }

        public PostsVM getPostById(int id)
        {
            if (id != null && id != 0)
            {
                var post = applicationDbContext.posts.Where(i => i.Id == id).FirstOrDefault();
                PostsVM postVM = new PostsVM()
                {
                    Body = post.Body,
                    Id = post.Id,
                    PublishingDate = post.PublishingDate
                };
                return postVM;
            }
            else
            {
                return null;
            }
        }

        public void updatePost(PostsVM newPostvm)
        {
            if (newPostvm.Id != null && newPostvm.Id != 0)
            {
                var OldPost = applicationDbContext.posts.Where(i => i.Id == newPostvm.Id).FirstOrDefault();

                if (newPostvm != null)
                {
                    OldPost.Body = newPostvm.Body;
                  

                    applicationDbContext.SaveChanges();
                }
            }
        }
    }
}
