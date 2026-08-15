using Application.Contract.ArticleAgg.Commands;

namespace Application.Contract.ArticleAgg
{
    public class UpdateArticleCategoryCommand : CreateArticleCategoryCommand
    {
        public int Id { get; set; }
    }
}