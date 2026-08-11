using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg;
using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.JournalistAgg
{
    public class JournalistViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public string ProfilePicturePath { get; set; } = null!;

        public bool IsDeleted { get; set; }
    }
}
