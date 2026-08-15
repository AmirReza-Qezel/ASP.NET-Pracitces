using Application.Contract.ArticleAgg.Commands;

namespace Application.Contract.ArticleAgg
{
    public class UpdateJournalistCommand : CreateJournalistCommand
    {
        public int Id { get; set; }
    }
}