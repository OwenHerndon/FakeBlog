using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Contents { get; set; }

        public DateTime DateCreated { get; set; } //required by default

        public DateTime PublishTime { get; set; }

        public bool isDraft { get; set; }

        public bool Edited { get; set; }
        //many to many with Blogusers
    }
}