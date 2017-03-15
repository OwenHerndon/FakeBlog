using FakeBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBlog.DAL
{
    interface IFakeBlogRepo
    {
        //Create
        void AddPost(string title, ApplicationUser author);
        //bool AddPost(string title, ApplicationUser author);

        //Read
        List<Post> GetPostsFromblog(int blogId);
        Blog GetBlog(int blogId);
        Post GetPost(int postId);
        
        //Update
        bool EditPost(int postId);

        //Delete
        bool DeletePost(int postId);

    }
}
