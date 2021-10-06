#pragma checksum "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "304aa60ece8426bcba1f3590d2e98a90077e8dfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Books), @"mvc.1.0.view", @"/Views/Admin/Books.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\_ViewImports.cshtml"
using IntecapBooks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\_ViewImports.cshtml"
using IntecapBooks.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"304aa60ece8426bcba1f3590d2e98a90077e8dfb", @"/Views/Admin/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9210d42a5f78e623756d82a48b07a60718797c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpsertBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-primary\">Book List </h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "304aa60ece8426bcba1f3590d2e98a90077e8dfb3977", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; Create New Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<br />
<div class=""p-4 border rounded"">
    <table id=""tblData"" class=""table table-striped table-bordered"" style=""width:100%"">
        <thead class=""thead-dark"">
            <tr class=""table-info"">
                <th>Title</th>
                <th>ISBN</th>
                <th>Price</th>
                <th>Author</th>
                <th>Category</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\Books.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr role=\"row\" class=\"odd\">\r\n                    <td class=\"sorting_1\">");
#nullable restore
#line 30 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\Books.cshtml"
                                     Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\Books.cshtml"
                   Write(book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\Books.cshtml"
                   Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\Books.cshtml"
                   Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>123</td>\r\n                    <td>\r\n                        <div class=\"text-center\">\r\n                            <a");
            BeginWriteAttribute("href", " href=", 1196, "", 1235, 1);
#nullable restore
#line 37 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\Books.cshtml"
WriteAttributeValue("", 1202, "/Admin/UpsertBook/" + book.Id, 1202, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\" style=\"cursor:pointer\">\r\n                                <i class=\"fas fa-edit\" aria-hidden=\"true\">UPDATE</i>\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=", 1446, "", 1488, 1);
#nullable restore
#line 40 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\Books.cshtml"
WriteAttributeValue("", 1455, "/Admin/DeleteBook/" + book.Id, 1455, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger text-white"" style=""cursor:pointer"">
                                <i class=""fas fa-trash-alt"" aria-hidden=""true"">DELETE</i>
                            </a>
                        </div>
                    </td>
                </tr>
");
#nullable restore
#line 46 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\Books.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
