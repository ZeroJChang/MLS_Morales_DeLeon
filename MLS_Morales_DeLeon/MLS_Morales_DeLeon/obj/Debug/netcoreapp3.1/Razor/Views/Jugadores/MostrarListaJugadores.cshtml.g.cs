#pragma checksum "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "700a5d94405090f6a800c7e8788af873e36690fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jugadores_MostrarListaJugadores), @"mvc.1.0.view", @"/Views/Jugadores/MostrarListaJugadores.cshtml")]
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
#line 1 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\_ViewImports.cshtml"
using MLS_Morales_DeLeon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\_ViewImports.cshtml"
using MLS_Morales_DeLeon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"700a5d94405090f6a800c7e8788af873e36690fc", @"/Views/Jugadores/MostrarListaJugadores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7630429395dc3b0e8db1796acb535262fe8f0e47", @"/Views/_ViewImports.cshtml")]
    public class Views_Jugadores_MostrarListaJugadores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MLS_Morales_DeLeon.Models.Jugadores>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
  
    ViewData["Title"] = "MostrarListaJugadores";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MostrarListaJugadores</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
Write(Html.ActionLink("Crear nuevo jugador", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
Write(Html.ActionLink("Carga de archivo", "CrearArchivo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
Write(Html.ActionLink("Busqueda archivo", "Busqueda"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.DisplayNameFor(model => model.EquipoMLS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreJugador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.DisplayNameFor(model => model.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.DisplayFor(modelItem => item.EquipoMLS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreJugador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.DisplayFor(modelItem => item.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.Id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 50 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\ZeroJChang\Desktop\MLS\MLS_Morales_DeLeon\MLS_Morales_DeLeon\MLS_Morales_DeLeon\Views\Jugadores\MostrarListaJugadores.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MLS_Morales_DeLeon.Models.Jugadores>> Html { get; private set; }
    }
}
#pragma warning restore 1591
