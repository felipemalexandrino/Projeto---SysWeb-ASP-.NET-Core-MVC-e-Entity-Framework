#pragma checksum "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea809301eb21379f1d77fc9d01e791a020ac5b99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroVenda_BuscaGrupo), @"mvc.1.0.view", @"/Views/RegistroVenda/BuscaGrupo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroVenda/BuscaGrupo.cshtml", typeof(AspNetCore.Views_RegistroVenda_BuscaGrupo))]
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
#line 1 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\_ViewImports.cshtml"
using SalesWeb_MVC;

#line default
#line hidden
#line 2 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\_ViewImports.cshtml"
using SalesWeb_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea809301eb21379f1d77fc9d01e791a020ac5b99", @"/Views/RegistroVenda/BuscaGrupo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339f0f3be5ddd986ff95d82d3b0fdfa7b6b9b6d7", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroVenda_BuscaGrupo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Departamento, RegistroVenda>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
  
    ViewData["Title"] = "Busca Grupo";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(249, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(256, 17, false);
#line 8 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(273, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(362, 660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d72bb55c9874196af08278d2c4ead5d", async() => {
                BeginContext(414, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data Min</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 629, "", 656, 1);
#line 16 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
WriteAttributeValue("", 636, ViewData["minDate"], 636, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(656, 202, true);
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data Max</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 858, "", 885, 1);
#line 20 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
WriteAttributeValue("", 865, ViewData["maxDate"], 865, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(885, 130, true);
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
            BeginContext(1022, 24, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 28 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
 foreach (var departamentGroup in Model)
{

#line default
#line hidden
            BeginContext(1091, 125, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Departamento ");
            EndContext();
            BeginContext(1217, 25, false);
#line 32 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
                                            Write(departamentGroup.Key.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1242, 15, true);
            WriteLiteral(" Venda total = ");
            EndContext();
            BeginContext(1258, 62, false);
#line 32 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
                                                                                     Write(departamentGroup.Key.TotalVenda(minDate,maxDate).ToString("F"));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 650, true);
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
#line 53 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
                     foreach (var item in departamentGroup)
                    {

#line default
#line hidden
            BeginContext(2054, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2151, 39, false);
#line 57 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(2190, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2294, 40, false);
#line 60 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(2334, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2438, 48, false);
#line 63 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Vendedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2486, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2590, 41, false);
#line 66 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 69 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
                    }

#line default
#line hidden
            BeginContext(2722, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 74 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaGrupo.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Departamento, RegistroVenda>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
