using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlogProject.Models;

namespace RazorBlogProject.Pages
{
    public class CreateArticleModel : PageModel
    {
        [BindProperty]
        public CreatePost Command { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }
        [TempData]
        public string SuccesMessage { get; set; }
        private readonly BlogContext _context;

        public CreateArticleModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                var Post = new BlogPost(Command.Title, Command.PicturePath, Command.AltPicturePath, Command.PictureTitle, Command.ShortSummary, Command.Description);
                _context.BlogPosts.Add(Post);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }
            else
            {
                ErrorMessage = "لطفا مقادیر خواسته شده را صحیح وارد کنید";
                return Page();
            }
        }
    }
}
