using Domain.ArticleCategoryAgg;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistence.Repositories
{
    public class ArticleCategoryRepository : Rep
        ository<ArticleCategory>
    {
        public ArticleCategoryRepository(MasterBloggerContext context) : base(context)
        {
        }
    }
}
