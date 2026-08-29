using Domain.JournalistAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.ArticleAgg.Commands___DTOs
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreationDate { get; set; }
        public string? JournalistFullName { get; set; }
        public string? Category { get; set; }
        public int ArticleCategoryId { get; set; }
    }
}
