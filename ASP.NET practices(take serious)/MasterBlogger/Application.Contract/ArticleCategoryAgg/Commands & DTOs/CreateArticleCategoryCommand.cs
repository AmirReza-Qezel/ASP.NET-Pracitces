using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.ArticleAgg.Commands
{
    public class CreateArticleCategoryCommand
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
