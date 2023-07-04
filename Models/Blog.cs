using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBlogProject.Models
{
    public class Blog //each Class serves to describe a single Instance
    {
        //Identity - source properties & prevents duplicates
        public int Id { get; set; } //Primary Key - records unique piece of data for itself (here, Blog)
        public string BlogUserId { get; set; } //foreign key in Blog model & primary key in User model - records BlogUserId - links to User

        //Form properties
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]// 100 = maxlength - {0}:Name ; {2}:min; {1}:max
        public string Name { get; set; } //blog name

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]// 100 = maxlength - {0}:Name ; {2}:min; {1}:max
        public string Description { get; set; }

        //DateTime properties
        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime? Updated { get; set;}

        //Image properties
        [Display(Name = "Blog Image")]
        public byte[] ImageData { get; set; }

        [Display(Name = "Image Image")]
        public string ContentType { get; set; }

        [NotMapped] //not mapped in database
        public IFormFile Image { get; set; }//transfer data from user to database - does not need to be stored

        //navigation properties
        [Display(Name="Author")]
        public virtual BlogUser BlogUser { get; set; } //enforces Uniqueness on user's name - regiters new account - tracks email, password
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>(); //declaring Posts interface implemented with concrete class HashSet
    }
}
