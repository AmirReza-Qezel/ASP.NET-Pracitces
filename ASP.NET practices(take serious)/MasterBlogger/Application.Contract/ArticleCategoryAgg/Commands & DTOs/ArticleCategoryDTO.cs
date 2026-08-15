using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.ArticleCategoryAgg.Commands___DTOs
{
    public class ArticleCategoryDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
