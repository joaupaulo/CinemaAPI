#pragma checksum "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e97f87e7df044cf953e2f4291bacf764196a886e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Programacao_Delete), @"mvc.1.0.view", @"/Views/Programacao/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e97f87e7df044cf953e2f4291bacf764196a886e", @"/Views/Programacao/Delete.cshtml")]
    public class Views_Programacao_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaAPI.Models.Programacao>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Programacao</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataLancamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataLancamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmeHoje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FilmeHoje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmeSemana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FilmeSemana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cinema));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cinema.CinemaId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd class>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""ProgramacaoId"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaAPI.Models.Programacao> Html { get; private set; }
    }
}
#pragma warning restore 1591
