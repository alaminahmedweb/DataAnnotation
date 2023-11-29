using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMigrations.Domain;

//Primary Key Example
//Required , Max & Min Length, Error Message,Not Mapped , Table Name,Value Object
//Column Name,Concurrency Check , Time Stamp

[Table("InternalBlogs")]
public class Blog
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [ConcurrencyCheck,MaxLength(10,ErrorMessage ="Blogger Name must be in 10 characters"),MinLength(5)]
    public string BloggerName { get; set; }

    [Column("BlogDescription",TypeName ="ntext")]
    public string Description { get; set; }
    public ICollection<Post> Posts { get; set; }


    //Not Mapped
    [NotMapped]
    public string BlogCode { 
        get
        {
            return Title.Substring(0, 1) + ":" + BloggerName.Substring(0, 1);
        } 
    }

    //Value Object
    public BlogDetails BlogDetail { get; set; }

    //TimeStamp For Concurrency Check
    //it will insure that the database field that code first generates is non-nullable
    [Timestamp]
    public byte[] TimeStamp { get; set; }
}
