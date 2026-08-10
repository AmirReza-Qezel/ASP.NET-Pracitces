using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistence.Repositories
{
    public class ArticleRepository : Repository<Article>
    {
        public ArticleRepository(MasterBloggerContext context) : base(context)
        {
        }
    }
}
