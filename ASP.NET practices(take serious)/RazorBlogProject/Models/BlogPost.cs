using System.ComponentModel.DataAnnotations;

namespace RazorBlogProject.Models
{
    public class BlogPost
    {
        public BlogPost( string title, string picturePath, string altPicturePath, string pictureTitle, string shortSummary, string description)
        {
            Title = title;
            PicturePath = picturePath;
            AltPicturePath = altPicturePath;
            PictureTitle = pictureTitle;
            ShortSummary = shortSummary;
            Description = description;
            IsDeleted = false;
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string PicturePath { get; set; }
        public string AltPicturePath { get; set; }
        public string PictureTitle { get; set; }
        public string ShortSummary { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
