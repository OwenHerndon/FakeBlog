using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FakeBlog.Models;

namespace FakeBlog.DAL
{
    public class FakeBlogRepository : IFakeBlogRepo
    {
        public void AddPost(string title, ApplicationUser author)
        {
            throw new NotImplementedException();
            /*
           public bool AddPost(string title, ApplicationUser author)
           {
               Post post = new Post { Title = Title, Author = author };
               if(post != draft)
               {
                   Context.Post.Add(post);
                   Context.SaveChanges();
                   return true;
               }
               return false;
           } 
       */
        }

        public bool DeletePost(int postId)
        {
            throw new NotImplementedException();
        }

        public bool EditPost(int postId)
        {
            throw new NotImplementedException();
            /*
        * public bool EditPost(int postId)
        * {
        *      Post postEdited = GetPost(postId);
        *      if(postEdited.isDraft){
        *          
        *      } 
        *         
        * }
        */
        }

        public Blog GetBlog(int blogId)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(int postId)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPostsFromblog(int blogId)
        {
            throw new NotImplementedException();
        }
    }
}