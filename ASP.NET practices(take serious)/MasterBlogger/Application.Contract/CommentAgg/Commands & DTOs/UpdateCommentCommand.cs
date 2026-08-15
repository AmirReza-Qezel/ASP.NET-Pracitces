using Application.Contract.ArticleAgg.Commands;

namespace Application.Contract.ArticleAgg
{
    public class UpdateCommentCommand :CreateCommentCommand
    {
        public int Id { get; set; }
    }
}