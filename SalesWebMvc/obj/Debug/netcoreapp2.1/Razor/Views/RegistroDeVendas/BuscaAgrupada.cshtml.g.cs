#pragma checksum "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "932c9a36923cdb60739860c4baae744b48318554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroDeVendas_BuscaAgrupada), @"mvc.1.0.view", @"/Views/RegistroDeVendas/BuscaAgrupada.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroDeVendas/BuscaAgrupada.cshtml", typeof(AspNetCore.Views_RegistroDeVendas_BuscaAgrupada))]
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
#line 1 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932c9a36923cdb60739860c4baae744b48318554", @"/Views/RegistroDeVendas/BuscaAgrupada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroDeVendas_BuscaAgrupada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Departamentos, Vendas>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
  
    ViewData["Title"] = "Busca Agrupada";
    DateTime DataInicial = DateTime.Parse(ViewData["DataInicial"] as string);
    DateTime DataFinal = DateTime.Parse(ViewData["DataFinal"] as string);

#line default
#line hidden
            BeginContext(258, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(265, 17, false);
#line 8 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(282, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(371, 678, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "932c9a36923cdb60739860c4baae744b483185545001", async() => {
                BeginContext(423, 223, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data Inicial</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"dataInicial\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 646, "", 677, 1);
#line 16 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
WriteAttributeValue("", 653, ViewData["dataInicial"], 653, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(677, 206, true);
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data Final</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"datafinal\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 883, "", 912, 1);
#line 20 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
WriteAttributeValue("", 890, ViewData["dataFinal"], 890, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(912, 130, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filtro</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1049, 24, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 28 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
 foreach (var departamentosGroup in Model)
{

#line default
#line hidden
            BeginContext(1120, 125, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Departamento ");
            EndContext();
            BeginContext(1246, 27, false);
#line 32 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
                                            Write(departamentosGroup.Key.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1273, 17, true);
            WriteLiteral(", Total Vendas = ");
            EndContext();
            BeginContext(1291, 75, false);
#line 32 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
                                                                                         Write(departamentosGroup.Key.TotalDeVendas(DataInicial, DataFinal).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 650, true);
            WriteLiteral(@"</h3>
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Data
                        </th>
                        <th>
                            Valor
                        </th>
                        <th>
                            Vendedor
                        </th>
                        <th>
                            Status
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 53 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
                     foreach (var item in departamentosGroup)
                    {

#line default
#line hidden
            BeginContext(2102, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2199, 46, false);
#line 57 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DataDaVenda));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 141, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"AlteraCor\" style=\"color:green\">\r\n                                ");
            EndContext();
            BeginContext(2387, 47, false);
#line 60 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ValorDaVenda));

#line default
#line hidden
            EndContext();
            BeginContext(2434, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2538, 48, false);
#line 63 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Vendedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2586, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2690, 41, false);
#line 66 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 69 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
                    }

#line default
#line hidden
            BeginContext(2822, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 74 "D:\Visual Studio\SalesWebMvc\SalesWebMvc\Views\RegistroDeVendas\BuscaAgrupada.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Departamentos, Vendas>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
