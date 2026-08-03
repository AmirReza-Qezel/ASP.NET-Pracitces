using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using RazorBlogProject.Models;

namespace RazorBlogProject.Pages
{
    public class PostDetailModel : PageModel
    {
        public PostViewModel Post { get; set; }
        private readonly BlogContext _context;

        public PostDetailModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Post = _context.BlogPosts
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
                }).FirstOrDefault(p=>p.Id == id);
        }
    }
}
