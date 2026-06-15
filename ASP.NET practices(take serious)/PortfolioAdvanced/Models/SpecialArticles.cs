namespace PortfolioAdvanced.Models
{
    public class SpecialArticle
    {
        public SpecialArticle(int id, string title, string description,string client, string photoPath)
        {
            Id = id;
            Title = title;
            Description = description;
            Client = client;
            PhotoPath = photoPath;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string PhotoPath { get; set; }
    }
}
