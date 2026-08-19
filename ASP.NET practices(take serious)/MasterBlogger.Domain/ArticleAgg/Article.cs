using Domain.ArticleCategoryAgg;
using Domain.CommentAgg;
using Domain.JournalistAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.ArticleAgg
{
    public class Article
    {
        public Article(string title,string content,int articleCategoryId)
        {
            Title = title;
            Content = content;
            IsDeleted = false;
            ArticleCategoryId = articleCategoryId;
            CreationDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool  IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }


        public int JournalistId { get; set; }
        public Journalist Journalist { get; set; }
        public int ArticleCategoryId { get; set; }
        public ArticleCategory ArticleCategory { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public void Edit(string title, string content)
        { 
            Title = title;
            Content = content;
        }
        public void Delete()
        {
            IsDeleted = true;
        }
        public void Activate()
        {
            IsDeleted = false;
        }
    }
}
