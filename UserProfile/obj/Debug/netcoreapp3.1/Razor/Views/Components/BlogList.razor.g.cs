#pragma checksum "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Components\BlogList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31f1a2d733c283f60b85e5a8255a6c7ee0fede64"
// <auto-generated/>
#pragma warning disable 1591
namespace UserProfile.Views.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Components\BlogList.razor"
using UserProfile.Models;

#line default
#line hidden
#nullable disable
    public partial class BlogList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Blog List</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-light");
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 5 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Components\BlogList.razor"
     foreach (BlogModel blog in ModelList)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 8 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Components\BlogList.razor"
                 blog.Author.userName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 9 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Components\BlogList.razor"
                 blog.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 10 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Components\BlogList.razor"
                 blog.Slug

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 12 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Components\BlogList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Components\BlogList.razor"
       

    [Parameter]
    public IEnumerable<BlogModel> ModelList { get; set; }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
