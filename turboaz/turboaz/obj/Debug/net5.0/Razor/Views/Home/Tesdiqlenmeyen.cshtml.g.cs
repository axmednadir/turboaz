#pragma checksum "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fac1a7dcbf328d51e0c9079002265d2b544dbd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tesdiqlenmeyen), @"mvc.1.0.view", @"/Views/Home/Tesdiqlenmeyen.cshtml")]
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
#line 4 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
using turboaz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fac1a7dcbf328d51e0c9079002265d2b544dbd1", @"/Views/Home/Tesdiqlenmeyen.cshtml")]
    #nullable restore
    public class Views_Home_Tesdiqlenmeyen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""source"">
    <div class=""source-input"">
        <div class=""input-first"">
            <input type=""text"" placeholder=""Marka"">
            <input type=""text"" placeholder=""Model"">
            <input type=""text"" placeholder=""Şəhər"">
        </div>
        <div class=""input-end"">
            <div class=""input-left"">
                <input type=""text"" placeholder=""İl-min"">
                <input type=""text"" placeholder=""İl-max"">
            </div>
            <div class=""input-right"">
                <input class=""qiymet"" type=""text"" placeholder=""qiymət-min"">
                <input class=""qiymet"" type=""text"" placeholder=""qiymət-max"">
            </div>

        </div>

    </div>

</section>
<!-- ///////////////////////////Section-Product//////////////////////////////////// -->
<section class=""product-vip"">
    <div class=""vip"">
        <div class=""vip-title"">
            <span>VIP ELANLAR</span>
        </div>
        <div class=""vip-product"">
");
#nullable restore
#line 35 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 1170, "\"", 1215, 2);
            WriteAttributeValue("", 1178, "vip-products", 1178, 12, true);
#nullable restore
#line 37 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
WriteAttributeValue(" ", 1190, item.CarcategoryMarkaId, 1191, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <div class=\"vip-photo\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1294, "\"", 1343, 2);
            WriteAttributeValue("", 1300, "/img/", 1300, 5, true);
#nullable restore
#line 40 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
WriteAttributeValue("", 1305, item.Photos.FirstOrDefault().PhotoUrl, 1305, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"vip-description\">\r\n                        <p class=\"p-qiymet\"> <strong><span>");
#nullable restore
#line 43 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
                                                      Write(item.CarQiy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span>AZN</span></strong> </p>\r\n                        <p>\r\n\r\n                            <span>\r\n                                Marka\r\n                            </span>\r\n\r\n                            <span> ");
#nullable restore
#line 50 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
                              Write(item.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </p>\r\n                        <p>");
#nullable restore
#line 52 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
                      Write(item.CarIl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"p-tarix\">");
#nullable restore
#line 53 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
                                      Write(item.CarSeher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p> ");
#nullable restore
#line 54 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
                       Write(item.CarTestiq);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n                    </div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1979, "\"", 2008, 2);
            WriteAttributeValue("", 1986, "/Home/Edit/", 1986, 11, true);
#nullable restore
#line 57 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
WriteAttributeValue("", 1997, item.CarId, 1997, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2042, "\"", 2075, 2);
            WriteAttributeValue("", 2049, "/Home/Readmore/", 2049, 15, true);
#nullable restore
#line 58 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
WriteAttributeValue("", 2064, item.CarId, 2064, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Readmore</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2113, "\"", 2144, 2);
            WriteAttributeValue("", 2120, "/Home/Remove/", 2120, 13, true);
#nullable restore
#line 59 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
WriteAttributeValue("", 2133, item.CarId, 2133, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2180, "\"", 2213, 2);
            WriteAttributeValue("", 2187, "/Home/Tesdiqle/", 2187, 15, true);
#nullable restore
#line 60 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
WriteAttributeValue("", 2202, item.CarId, 2202, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tesdiqle</a>\r\n                </div>\r\n");
#nullable restore
#line 62 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!-- ///////////////////////////category//////////////////////////////////// -->\r\n<section class=\"category\">\r\n    <div class=\"category-list\">\r\n");
#nullable restore
#line 69 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("cat", " cat=\"", 2514, "\"", 2544, 1);
#nullable restore
#line 71 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"
WriteAttributeValue("", 2520, item.CarcategoryMarkaId, 2520, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">Marka</a>\r\n");
#nullable restore
#line 72 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Tesdiqlenmeyen.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
