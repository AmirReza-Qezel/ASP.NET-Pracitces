using Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.JournalistAgg
{
    public class Journalist
    {
        public Journalist(string firstName,
            string lastName,
            string profilePicturePath)
        {
            FirstName = firstName;
            LastName = lastName;
            ProfilePicturePath = profilePicturePath;
            IsDeleted = false;
            MembershipDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ProfilePicturePath { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime MembershipDate { get; set; }
        public ICollection<Article> Articles { get; set; }

    }
}
