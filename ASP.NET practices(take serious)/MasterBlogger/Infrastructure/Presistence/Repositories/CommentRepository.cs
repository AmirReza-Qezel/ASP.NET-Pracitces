using Domain.ArticleAgg;
using Domain.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistence.Repositories
{
    public class CommentRepository : Repository<Comment>
    {
        public CommentRepository(MasterBloggerContext context) : base(context)
        {
        }

    }
}
