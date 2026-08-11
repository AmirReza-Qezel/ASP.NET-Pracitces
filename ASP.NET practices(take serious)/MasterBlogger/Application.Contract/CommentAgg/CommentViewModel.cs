using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.CommentAgg
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        public string Content { get; set; } = null!;

        public DateTime CreationDate { get; set; }

        public string AuthorName { get; set; } = null!;

    }
}
