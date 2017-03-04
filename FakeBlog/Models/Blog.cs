using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public string Title { get; set; }

        public List<Post> Posts { get; set; }
    }
}