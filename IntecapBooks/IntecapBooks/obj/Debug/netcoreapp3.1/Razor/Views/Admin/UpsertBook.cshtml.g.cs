#pragma checksum "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\UpsertBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60278f737c1b7b7d403e11532290de969d77359e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpsertBook), @"mvc.1.0.view", @"/Views/Admin/UpsertBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60278f737c1b7b7d403e11532290de969d77359e", @"/Views/Admin/UpsertBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9210d42a5f78e623756d82a48b07a60718797c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpsertBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewBook>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\angel.soto\source\repos\IntecapBooks\IntecapBooks\IntecapBooks\Views\Admin\UpsertBook.cshtml"
  
    string title = "Create Book";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<button onclick=""getTodos()"">GET TODOS</button>
<ul id=""todoList"">

</ul>
<script>
    function sendData() {
        var payload = {
            book: {
                description: ""Data from JS with AJAX""
            }
        };

        $.ajax({
            type: ""POST"",
            url: '/Admin/UpsertBook',
            data: JSON.stringify(payload),
            contentType: ""application/json"",
            success: function (data) {
                alert('exito');
            },
            error: function (data) {
                alert('error');
            }
        });
    }

    function getTodos() {
        $.ajax({
            type: ""GET"",
            url: 'https://jsonplaceholder.typicode.com/todos/',
            contentType: ""application/json"",
            success: function (data) {
                console.log(data);
                for (var i = 0; i < data.length; i++) {
                    $('#todoList').append(""<li>"" + data[i].title + ""</li>"");
                }
             ");
            WriteLiteral("   \r\n                console.log(\'finaliza iteraci??n\');\r\n\r\n            },\r\n            error: function (data) {\r\n                alert(\'error\');\r\n            }\r\n        });\n        \n    }\n</script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewBook> Html { get; private set; }
    }
}
#pragma warning restore 1591
