#pragma checksum "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0392dbbebd77c71739de5f742897134cec05ac40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Index), @"mvc.1.0.view", @"/Views/Player/Index.cshtml")]
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
#line 1 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\_ViewImports.cshtml"
using VoetbalSpeler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\_ViewImports.cshtml"
using VoetbalSpeler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\_ViewImports.cshtml"
using VoetbalSpelersBusiness;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0392dbbebd77c71739de5f742897134cec05ac40", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf546195b3303d75b9027a33c212c88d9660bbbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Player>,Team>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
  
    ViewData["Title"] = "Team Players";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Players</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
Write(Html.ActionLink("Create", "Edit", "Player", new { id = @Model.Item2.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Firstname
            </th>
            <th>
                Lastname
            </th>
            <th>
                Position
            </th>
            <th>
                TeamId
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 34 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
         foreach (var item in Model.Item1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
               Write(Model.Item2.Teamname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
               Write(Html.ActionLink("Stats Details", "Details", "PlayerStats", new { id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 54 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
               Write(Html.ActionLink("Add Stats", "Edit", "PlayerStats", new { id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\dyonv\source\repos\VoetbalSpelers\VoetbalSpeler\Views\Player\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"javascript:void(0);\" onclick=\"history.go(-1);\">Back</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Player>,Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591