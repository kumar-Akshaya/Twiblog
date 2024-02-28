using System.ComponentModel.DataAnnotations;

namespace Twiblog.Models
{
    public class PostInfoModel
    {
        [Key]
        public int? PostId { get; set; }

        [Required]
        public string PostedDate { get; set; }

        [Required]
        public string? PostEditedDate { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "You must enter at least 2 characters to be able to post this message")]
        public string UserName { get; set; }

        public string PostContent { get; set; }

        public List<string>? Likes { get; set; }

        public List<ReplyInfoModel> Replies { get; set; }
    }
}
