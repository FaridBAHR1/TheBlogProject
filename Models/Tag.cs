using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TheBlogProject.Models
{
    public class Tag
    {
        //Identity - source properties & prevents duplicates
        public int Id { get; set; }
        public int PostId { get; set; }
        public string BlogUserId { get; set; }

        //form
        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} and at most {1} characters.", MinimumLength = 2)]// 25 = maxlength - {0}:Property ; {2}:min; {1}:max
        public string Text { get; set; }

        //navigation
        public virtual Post Post { get; set; }
        public virtual BlogUser BlogUser { get; set; }
    }
}
