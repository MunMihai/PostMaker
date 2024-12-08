using System.ComponentModel.DataAnnotations;

namespace PostMaker.Models
{
    public class CreatePostViewModel
    {
        [Required]
        public String Author { get; set; }
        [Required]
        public String Content { get; set; }

    }
}
