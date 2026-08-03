using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlogProject.Models;

namespace RazorBlogProject.Pages
{
    public class IndexModel : PageModel
    {
        public List<PostViewModel> Posts { get; set; }
        private readonly ILogger<IndexModel> _logger;
        private readonly BlogContext _context;
        public IndexModel(ILogger<IndexModel> logger, BlogContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Posts = _context.BlogPosts
                .Where(p => p.IsDeleted == false)
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    PicturePath = p.PicturePath,
                    AltPicturePath = p.AltPicturePath,
                    PictureTitle = p.PictureTitle,
                    ShortSummary = p.ShortSummary,
                    Description = p.Description,
                    CreationDate = p.CreatedAt.ToString()
                }).OrderByDescending(e=>e.Id).ToList();
        }
        public IActionResult OnGetDelete(int id)
        {
            var Post = _context.BlogPosts.FirstOrDefault(p => p.Id == id);
            Post.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
