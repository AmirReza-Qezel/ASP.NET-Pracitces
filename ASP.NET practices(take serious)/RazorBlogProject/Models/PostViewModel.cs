namespace RazorBlogProject.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PicturePath { get; set; }
        public string AltPicturePath { get; set; }
        public string PictureTitle { get; set; }
        public string ShortSummary { get; set; }
        public string Description { get; set; }
        public string CreationDate{ get; set; }
    }
}
