#pragma checksum "C:\Users\DMITRO\source\repos\Shop\Shop\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892daaa86b9f69ba46a3b950cea0c308e603c40d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/List.cshtml", typeof(AspNetCore.Views_Cars_List))]
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
#line 1 "C:\Users\DMITRO\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892daaa86b9f69ba46a3b950cea0c308e603c40d", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8698b1ec29562463bc33480ac52eac0346944c13", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 51, true);
            WriteLiteral(" <h2 style=\"margin-top: 100px\">Все авто</h2>\r\n <h3>");
            EndContext();
            BeginContext(52, 21, false);
#line 2 "C:\Users\DMITRO\source\repos\Shop\Shop\Views\Cars\List.cshtml"
Write(Model.currentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(73, 37, true);
            WriteLiteral("</h3>\r\n <div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 4 "C:\Users\DMITRO\source\repos\Shop\Shop\Views\Cars\List.cshtml"
       
         foreach (var car in Model.allCars)
         {

#line default
#line hidden
            BeginContext(176, 80, true);
            WriteLiteral("             <div class=\"col-lg-4\">\r\n                 <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 256, "\"", 270, 1);
#line 8 "C:\Users\DMITRO\source\repos\Shop\Shop\Views\Cars\List.cshtml"
WriteAttributeValue("", 262, car.Img, 262, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 271, "\"", 286, 1);
#line 8 "C:\Users\DMITRO\source\repos\Shop\Shop\Views\Cars\List.cshtml"
WriteAttributeValue("", 277, car.Name, 277, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(287, 26, true);
            WriteLiteral(" />\r\n                 <h2>");
            EndContext();
            BeginContext(314, 8, false);
#line 9 "C:\Users\DMITRO\source\repos\Shop\Shop\Views\Cars\List.cshtml"
                Write(car.Name);

#line default
#line hidden
            EndContext();
            BeginContext(322, 27, true);
            WriteLiteral("</h2>\r\n                 <p>");
            EndContext();
            BeginContext(350, 8, false);
#line 10 "C:\Users\DMITRO\source\repos\Shop\Shop\Views\Cars\List.cshtml"
               Write(car.Desc);

#line default
#line hidden
            EndContext();
            BeginContext(358, 26, true);
            WriteLiteral("</p>\r\n                 <p>");
            EndContext();
            BeginContext(385, 23, false);
#line 11 "C:\Users\DMITRO\source\repos\Shop\Shop\Views\Cars\List.cshtml"
               Write(car.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(408, 98, true);
            WriteLiteral("</p>\r\n                 <p><a class=\"btn btn-warning\" href=\"#\">About</a></p>\r\n             </div>\r\n");
            EndContext();
#line 14 "C:\Users\DMITRO\source\repos\Shop\Shop\Views\Cars\List.cshtml"
         }
     

#line default
#line hidden
            BeginContext(526, 11, true);
            WriteLiteral(" </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
