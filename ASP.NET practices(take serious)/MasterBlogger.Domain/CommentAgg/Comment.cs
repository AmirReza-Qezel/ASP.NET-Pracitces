using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CommentAgg
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; } = null!;

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public string AuthorName { get; set; } = null!;

        public int ArticleId { get; set; }
        public Article Article { get; set; } = null!;
    }
}
