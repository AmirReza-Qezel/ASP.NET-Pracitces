using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.CommentAgg.Commands___DTOs
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string AuthorName { get; set; } = null!;

        public string Content { get; set; } = null!;

        public DateTime CreationDate { get; set; }

    }
}
