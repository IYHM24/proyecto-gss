#pragma checksum "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e86b56312bdf3f25b3e038abf0d8a1492b775a9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#line 1 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\_ViewImports.cshtml"
using WebApplication_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\_ViewImports.cshtml"
using WebApplication_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86b56312bdf3f25b3e038abf0d8a1492b775a9a", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"541a354062de2c2f128502b745ddb26db44186fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication_MVC.Models.Cliente>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Lista de clientes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <h3>lista de cliente</h3>\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86b56312bdf3f25b3e038abf0d8a1492b775a9a4876", async() => {
                WriteLiteral("Agregar cliente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mt-5\">\r\n");
#nullable restore
#line 19 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
         if (Model.Count()>0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-bordered table-striped\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.id_cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.telefono1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.telefono2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                           Write(item.id_cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                           Write(item.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                           Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                           Write(item.telefono1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                           Write(item.telefono2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 49 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"border shadow-sm\">No existen registros</p>    \r\n");
#nullable restore
#line 53 "C:\Users\USER\Downloads\Documentos GSS\Documentos para trabajo programador\backend\WebApplication MVC\WebApplication MVC\Views\Cliente\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication_MVC.Models.Cliente>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591