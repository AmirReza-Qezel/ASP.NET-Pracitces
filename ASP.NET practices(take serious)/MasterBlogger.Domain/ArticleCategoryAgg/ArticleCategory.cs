using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public ArticleCategory(string title)
        {
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
