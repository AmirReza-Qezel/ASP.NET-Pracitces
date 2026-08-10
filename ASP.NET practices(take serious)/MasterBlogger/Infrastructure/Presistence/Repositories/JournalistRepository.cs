using Domain.ArticleAgg;
using Domain.JournalistAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistence.Repositories
{
    public class JournalistRepository : Repository<Journalist>
    {
        private readonly MasterBloggerContext _context;

        public JournalistRepository(MasterBloggerContext context) : base(context)
        {
        }
    }
}
