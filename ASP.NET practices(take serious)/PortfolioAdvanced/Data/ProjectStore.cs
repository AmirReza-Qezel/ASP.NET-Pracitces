using PortfolioAdvanced.Models;

namespace PortfolioAdvanced.Data
{
    public class ProjectStore
    {
        public static List<SpecialArticle> GetProject()
        {
            return new List<SpecialArticle> {
            new SpecialArticle(1, "Project Heading", "Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.", "Google", "project-1.jpg"),
            new SpecialArticle(2, "Project Heading", "Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.", "Google", "project-2.jpg"),
            new SpecialArticle(3, "Project Heading", "Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.", "Google", "project-3.jpg"),
             new SpecialArticle(4, "Project Heading", "Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.", "Google", "project-4.jpg")
            };
        }
        public static SpecialArticle GetProjectBy(int id)
        {
            return GetProject().FirstOrDefault(x => x.Id == id);
        }
    }
}
