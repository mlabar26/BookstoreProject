using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreProject.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-number")]
    public class PaginationTagHelper : TagHelper
    {
        //Create page links dynamically

    }
}
