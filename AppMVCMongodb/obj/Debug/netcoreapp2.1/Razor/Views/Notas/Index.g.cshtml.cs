#pragma checksum "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c91bfffa29b032ffc7d9956d41668a4a5b9549b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notas_Index), @"mvc.1.0.view", @"/Views/Notas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Notas/Index.cshtml", typeof(AspNetCore.Views_Notas_Index))]
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
#line 1 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\_ViewImports.cshtml"
using AppMVCMongodb;

#line default
#line hidden
#line 2 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\_ViewImports.cshtml"
using AppMVCMongodb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c91bfffa29b032ffc7d9956d41668a4a5b9549b", @"/Views/Notas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ff0fe59e6de15bed28d0150fbb8c7b9e60379f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Notas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppMVCMongodb.Models.Nota>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
   ViewBag.Title = "Todas las notas";

#line default
#line hidden
            BeginContext(87, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(92, 13, false);
#line 3 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(105, 148, true);
            WriteLiteral("</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Titulo</th>\r\n        <th>Notas</th>\r\n        <th>Eliminar</th>\r\n    </tr>\r\n");
            EndContext();
#line 11 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(294, 50, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 344, "\"", 372, 2);
            WriteAttributeValue("", 351, "Notas/Editar/", 351, 13, true);
#line 15 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
WriteAttributeValue("", 364, item.Id, 364, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(373, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(397, 7, false);
#line 16 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(404, 79, true);
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 483, "\"", 511, 2);
            WriteAttributeValue("", 490, "Notas/Editar/", 490, 13, true);
#line 20 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
WriteAttributeValue("", 503, item.Id, 503, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(512, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(536, 11, false);
#line 21 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
               Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(547, 79, true);
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 626, "\"", 654, 2);
            WriteAttributeValue("", 633, "Notas/Editar/", 633, 13, true);
#line 25 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
WriteAttributeValue("", 646, item.Id, 646, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(655, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(679, 14, false);
#line 26 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
               Write(item.Contenido);

#line default
#line hidden
            EndContext();
            BeginContext(693, 79, true);
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 772, "\"", 802, 2);
            WriteAttributeValue("", 779, "Notas/Eliminar/", 779, 15, true);
#line 30 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
WriteAttributeValue("", 794, item.Id, 794, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(803, 54, true);
            WriteLiteral(">Eliminar Nota</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\rrondosa\source\repos\AppMVCMongodb\AppMVCMongodb\Views\Notas\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(864, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppMVCMongodb.Models.Nota>> Html { get; private set; }
    }
}
#pragma warning restore 1591