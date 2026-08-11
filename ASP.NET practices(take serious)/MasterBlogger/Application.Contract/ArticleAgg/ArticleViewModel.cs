using Domain.ArticleCategoryAgg;
using Domain.CommentAgg;
using Domain.JournalistAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.ArticleAgg
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
