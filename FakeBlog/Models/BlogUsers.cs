using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class BlogUsers
    {
        [Key]
        public int UserId { get; set; } 

        //relationship to blog, many to many or one blog to many users, which blog has a relationship to post one to many.
    }
}