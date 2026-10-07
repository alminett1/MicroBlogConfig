using System.ComponentModel.DataAnnotations;


namespace MicroBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required, StringLength(100, ErrorMessage = "Must be 100 characters or fewer.")]
        public string Title { get; set; } = string.Empty;

        public string Body { get; set; } = string.Empty;

        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    }
}
