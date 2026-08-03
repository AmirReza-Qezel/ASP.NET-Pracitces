using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorBlogProject.Models
{
    public class CreatePost
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage ="لطفا عنوان را وارد کنید")]
        public string Title { get; set; }
        [DisplayName("مسیر عکس")]
        [Required(ErrorMessage = "لطفا عنوان را وارد کنید")]
        public string PicturePath { get; set; }
        [DisplayName("مسیر عکس جایگزین")]
        public string AltPicturePath { get; set; }
        [DisplayName(" عنوان عکس")]
        public string PictureTitle { get; set; }
        [DisplayName("خلاصه کوتاه پست")]
        [Required(ErrorMessage = "لطفا عنوان را وارد کنید")]
        public string ShortSummary { get; set; }
        [DisplayName("توضیحات")]
        public string Description { get; set; }
    }
}
