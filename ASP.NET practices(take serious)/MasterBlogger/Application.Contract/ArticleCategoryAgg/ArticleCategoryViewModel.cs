using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.ArticleCategoryAgg
{
    public class ArticleCategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
