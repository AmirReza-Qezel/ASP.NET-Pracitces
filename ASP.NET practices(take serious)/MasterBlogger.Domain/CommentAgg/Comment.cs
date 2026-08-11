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
        public Comment(string content, string authorName, int articleId)
        {
            Content = content;
            CreationDate = DateTime.Now;
            AuthorName = authorName;
            ArticleId = articleId;
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public string AuthorName { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; } = null!;
    }
}
