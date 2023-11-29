using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Primary Key Example

namespace EFCoreMigrations.Domain
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
        public string  Content { get; set; }
        public int BlogId { get; set; }
        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }

        //public ICollection<Comment> Posts { get; set;}
        public Person CreatedBy { get; set; }

        public Person UpdatedBy { get; set;}
    }
}
