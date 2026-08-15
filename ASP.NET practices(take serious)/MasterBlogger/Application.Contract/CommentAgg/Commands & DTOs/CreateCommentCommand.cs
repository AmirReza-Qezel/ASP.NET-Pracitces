using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.ArticleAgg.Commands
{
    public class CreateCommentCommand
    {

        public string AuthorName { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int ArticleId { get; set; }
    }
}
