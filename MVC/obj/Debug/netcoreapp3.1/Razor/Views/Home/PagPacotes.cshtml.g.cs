#pragma checksum "C:\Users\vitaoTM\Documents\github\SENAC\Projetinho_CRUD_SENAC\MVC\Views\Home\PagPacotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c0bf08e5220205b0f2fd84b6515ba4480dddf6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PagPacotes), @"mvc.1.0.view", @"/Views/Home/PagPacotes.cshtml")]
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
#line 1 "C:\Users\vitaoTM\Documents\github\SENAC\Projetinho_CRUD_SENAC\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\vitaoTM\Documents\github\SENAC\Projetinho_CRUD_SENAC\MVC\Views\Home\PagPacotes.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vitaoTM\Documents\github\SENAC\Projetinho_CRUD_SENAC\MVC\Views\Home\PagPacotes.cshtml"
using List<ListaPacotes>;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0bf08e5220205b0f2fd84b6515ba4480dddf6d", @"/Views/Home/PagPacotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PagPacotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\vitaoTM\Documents\github\SENAC\Projetinho_CRUD_SENAC\MVC\Views\Home\PagPacotes.cshtml"
  
    ViewData["Title"] = "Pacotes";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>
    Lista de Pacotes
</h2>
 <table border=""1"">
    <thead>
        <tr>
            <th> NomePacote </th>
            <th> Valor </th>
            <th> Destino </th>
            <th> Observacao </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\vitaoTM\Documents\github\SENAC\Projetinho_CRUD_SENAC\MVC\Views\Home\PagPacotes.cshtml"
         foreach (Pacotes item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> item.NomePacote </td>\r\n                <td> item.Valor </td>\r\n                <td> item.Destino </td>\r\n                <td> item.Observacao </td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\vitaoTM\Documents\github\SENAC\Projetinho_CRUD_SENAC\MVC\Views\Home\PagPacotes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
