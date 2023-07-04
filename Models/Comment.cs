using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using TheBlogProject.Enumerations;

namespace TheBlogProject.Models
{
    public class Comment
    {
        //Identity - source properties & prevents duplicates
        public int Id { get; set; }
        public int PostId { get; set; }
        public string BlogUserId { get; set; }
        public string ModeratorId { get; set; }

        //form
        [Required]
        [StringLength(500, ErrorMessage = "The {0} should be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Comment")]
        public string Body { get; set; }

        //DateTime
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Moderated { get; set; }
        public DateTime? Deleted { get; set; }

        //moderator's options
        [StringLength(500, ErrorMessage = "The {0} should be at least {2} and no more than {1} characters long.", MinimumLength = 2)]//high max length - allow to display full error messages
        [Display(Name = "Moderated Comment")]
        public string ModeratedBody { get; set; }

        public ModerationType ModerationType { get; set; } //limits & records moderation type/reason

        //navigation properties - leverages foreign key to get entire record represented by property
        public virtual Post Post { get; set; }//holds BlogUserId's record
        public virtual BlogUser BlogUser { get; set; }//represents default user
        public virtual BlogUser Moderator { get; set; }//use ModeratorId to go from Comment to moderator record

    }
}
