using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace PortfolioAdvanced.TagHelper
{
    public class EmailTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        private string domain = "gmail.com";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + domain;
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }
    }
}
