#pragma checksum "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a16a76308af53b2475cc419a538ded3764fde84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Readmore), @"mvc.1.0.view", @"/Views/Home/Readmore.cshtml")]
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
#line 4 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
using turboaz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a16a76308af53b2475cc419a538ded3764fde84", @"/Views/Home/Readmore.cshtml")]
    #nullable restore
    public class Views_Home_Readmore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"product-description\">\r\n    <div class=\"description-product\">\r\n        <div class=\"vip-title\">\r\n\r\n            <span>MARKA<span>,      ");
#nullable restore
#line 11 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
                               Write(Model.CarIl);

#line default
#line hidden
#nullable disable
            WriteLiteral(" il</span> </span>\r\n        </div>\r\n        <div class=\"desc-product\">\r\n\r\n            <div class=\"products-sekil\">\r\n                <div class=\"yuxari\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 429, "\"", 479, 2);
            WriteAttributeValue("", 435, "/img/", 435, 5, true);
#nullable restore
#line 17 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
WriteAttributeValue("", 440, Model.Photos.FirstOrDefault().PhotoUrl, 440, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                    <div class=\"asagi\">\r\n");
#nullable restore
#line 21 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
                 foreach (var item in Model.Photos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 650, "\"", 675, 2);
            WriteAttributeValue("", 656, "/img/", 656, 5, true);
#nullable restore
#line 23 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
WriteAttributeValue("", 661, item.PhotoUrl, 661, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 24 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"infodesc\">\r\n        <div class=\"infodescs\">\r\n            <div class=\"infoseher\">   <span>Şəhər</span></div>\r\n            <div class=\"infoc\">   <span>");
#nullable restore
#line 59 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
                                   Write(Model.CarSeher);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
        </div>
        <div class=""infodescs"">
            <div class=""infoseher"">   <span>Marka</span></div>
            <div class=""infoc"">   <span>Marka</span></div>
        </div>
        <div class=""infodescs"">
            <div class=""infoseher"">   <span>Model</span></div>
            <div class=""infoc"">   <span>");
#nullable restore
#line 67 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
                                   Write(Model.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n        </div>\r\n        <div class=\"infodescs\">\r\n            <div class=\"infoseher\">   <span>Buraxılış ili</span></div>\r\n            <div class=\"infoc\">   <span>");
#nullable restore
#line 71 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
                                   Write(Model.CarIl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n        </div>\r\n    </div>\r\n    <div class=\"infodescr\">\r\n        <span>");
#nullable restore
#line 75 "C:\Users\user\source\repos\WebApplication1\turboaz\turboaz\Views\Home\Readmore.cshtml"
         Write(Model.CarDesciption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
