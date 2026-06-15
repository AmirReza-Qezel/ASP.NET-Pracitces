using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PortfolioAdvanced.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="فیلد نام نباید خالی باشد!")]
        [MinLength(2,ErrorMessage = "نام صحیح وارد کنید!")]
        [MaxLength(50, ErrorMessage = "نام صحیح وارد کنید!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ایمیل خود را وارد کنید!")]
        [EmailAddress(ErrorMessage = "ایمیل صحیح وارد کنید!")]
        public string Email { get; set; }
        public int Service { get; set; }
        public SelectList Services { get; set; }
        public string Message { get; set; }
    }
}
