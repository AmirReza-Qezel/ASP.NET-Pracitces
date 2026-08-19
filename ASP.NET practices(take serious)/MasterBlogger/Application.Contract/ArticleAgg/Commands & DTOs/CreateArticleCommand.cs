using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.ArticleAgg.Commands
{
    public class CreateArticleCommand
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ArticleCategoryId { get; set; }
    }
}
