#pragma checksum "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e538e91afafac35503c120c2dfbf2e7ec49b874a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListOfFiles_Index), @"mvc.1.0.view", @"/Views/ListOfFiles/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Работа\Smartway\FileLoader\FileLoader\Views\_ViewImports.cshtml"
using FileLoader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Работа\Smartway\FileLoader\FileLoader\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
using FileLoader.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e538e91afafac35503c120c2dfbf2e7ec49b874a", @"/Views/ListOfFiles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ad1e58647da5ca915e63fa2be23205a49b2118", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ListOfFiles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
  
    ViewData["Title"] = "Table of loaded files";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Name of file</th>
            <th>Download the file</th>
            <th>Temporary link</th>
            <th>Generate new link</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
     foreach(FileModel value in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
               Write(value.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
               Write(value.OriginalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=", 576, "", 597, 1);
#nullable restore
#line 24 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
WriteAttributeValue("", 582, value.FullLink, 582, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Download</a></td>\r\n                <td><div>");
#nullable restore
#line 25 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
                    Write(value.FullLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></td>\r\n                <td>");
#nullable restore
#line 26 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
               Write(Html.ActionLink("Generate","ChangeLink","Download",new {link = @value.GeneratedPartOfLink}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "D:\Работа\Smartway\FileLoader\FileLoader\Views\ListOfFiles\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
