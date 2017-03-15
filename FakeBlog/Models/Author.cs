using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }  //primary key

        [MinLength(10)]
        [MaxLength(60)]
        public string Email { get; set; }

        [MaxLength(60)]
        public string Username { get; set; }

        [MaxLength(60)]
        public string FullName { get; set; }

        //public Blog AuthorsBlog {get; set;}

        //relationship to blog, one to one, which has a one to many relationship to post

        //relationship to draft, one to one to post

        //relationship to bloguser

        //public ApplicationUser BaseUser { get; set; } //1 to 1 relationship

        //public List<Draft> Drafts { get; set; } //1 to many (boards) relationship

        //public List<Post> Post { get; set; }
    }
}