namespace Portfolio.Models
{
    public class SampleWork
    {
        public SampleWork(int id, string title, string description, string photoPath)
        {
            Id = id;
            Title = title;
            Description = description;
            PhotoPath = photoPath;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
    }
}
