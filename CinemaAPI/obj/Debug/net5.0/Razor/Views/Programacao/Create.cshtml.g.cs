#pragma checksum "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08bd4c117ef845ad547cc12bb823fc7099987f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Programacao_Create), @"mvc.1.0.view", @"/Views/Programacao/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08bd4c117ef845ad547cc12bb823fc7099987f38", @"/Views/Programacao/Create.cshtml")]
    public class Views_Programacao_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaAPI.Models.Programacao>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Programacao</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""DataLancamento"" class=""control-label""></label>
                <input asp-for=""DataLancamento"" class=""form-control"" />
                <span asp-validation-for=""DataLancamento"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FilmeHoje"" class=""control-label""></label>
                <input asp-for=""FilmeHoje"" class=""form-control"" />
                <span asp-validation-for=""FilmeHoje"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FilmeSemana"" class=""control-label""></label>
                <input asp-for=""FilmeSemana"" class=""form-control"" />
                <span asp-validation-for=""Fi");
            WriteLiteral(@"lmeSemana"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CinemaId"" class=""control-label""></label>
                <select asp-for=""CinemaId"" class =""form-control"" asp-items=""ViewBag.CinemaId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Paulo\source\repos\CinemaAPI\CinemaAPI\Views\Programacao\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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