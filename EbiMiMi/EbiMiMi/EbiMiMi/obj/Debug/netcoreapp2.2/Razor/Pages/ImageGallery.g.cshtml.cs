#pragma checksum "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e607a3c4219c1f40968656a3485966cc75234d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EbiMiMi.Pages.Pages_ImageGallery), @"mvc.1.0.razor-page", @"/Pages/ImageGallery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ImageGallery.cshtml", typeof(EbiMiMi.Pages.Pages_ImageGallery), null)]
namespace EbiMiMi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\_ViewImports.cshtml"
using EbiMiMi;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e607a3c4219c1f40968656a3485966cc75234d", @"/Pages/ImageGallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02afd2a00a83b7330be876db360311f4e43f04a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ImageGallery : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
  
    ViewData["Title"] = "Image Gallery";

#line default
#line hidden
            BeginContext(96, 94, true);
            WriteLiteral("\r\n<h1 class=\"titledesign\">Our Photos 💚</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
            EndContext();
#line 12 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
         if (ViewData["SuccessMessage"] != null)
        {

#line default
#line hidden
            BeginContext(438, 284, true);
            WriteLiteral(@"            <div class=""alert alert-success alert-dismissible"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <strong>");
            EndContext();
            BeginContext(723, 26, false);
#line 18 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
                   Write(ViewData["SuccessMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(749, 31, true);
            WriteLiteral("</strong>\r\n            </div>\r\n");
            EndContext();
#line 20 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
        }

#line default
#line hidden
            BeginContext(791, 43, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"orderly\">\r\n");
            EndContext();
#line 27 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
     if (Model.GalleryImages.Count > 0)
    {
        var c = 1;
        for (int i=0; i < Model.GalleryImages.Count; i++)
        {

            var k = Model.GalleryImages.Count;

#line default
#line hidden
            BeginContext(1285, 77, true);
            WriteLiteral("            <div class=\"responsive\">\r\n                <div class=\"gallery\">\r\n");
            EndContext();
#line 36 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
                     if (Model.GalleryImages[k - c].URL.Substring(Model.GalleryImages[k - c].URL.Length - 4) != ".mp4")
                    {

#line default
#line hidden
            BeginContext(1506, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1532, "\"", 1570, 1);
#line 38 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
WriteAttributeValue("", 1539, Model.GalleryImages[k - c].URL, 1539, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1571, 35, true);
            WriteLiteral(">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1606, "\"", 1643, 1);
#line 39 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
WriteAttributeValue("", 1612, Model.GalleryImages[k - c].URL, 1612, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1644, 43, true);
            WriteLiteral(" alt=\"...\">\r\n                        </a>\r\n");
            EndContext();
#line 41 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1759, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1785, "\"", 1823, 1);
#line 44 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
WriteAttributeValue("", 1792, Model.GalleryImages[k - c].URL, 1792, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1824, 42, true);
            WriteLiteral(">\r\n                            <video loop");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1866, "\"", 1903, 1);
#line 45 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
WriteAttributeValue("", 1872, Model.GalleryImages[k - c].URL, 1872, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1904, 52, true);
            WriteLiteral(" alt=\"...\" autoplay>\r\n                        </a>\r\n");
            EndContext();
#line 47 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
                    }

#line default
#line hidden
            BeginContext(1979, 39, true);
            WriteLiteral("                    <div class=\"des\">\r\n");
            EndContext();
#line 51 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
                         if (Model.GalleryImages[k - c].Caption != null)
                        {

#line default
#line hidden
            BeginContext(2281, 31, true);
            WriteLiteral("                            <p>");
            EndContext();
            BeginContext(2313, 34, false);
#line 53 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
                          Write(Model.GalleryImages[k - c].Caption);

#line default
#line hidden
            EndContext();
            BeginContext(2347, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 54 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2437, 41, true);
            WriteLiteral("                            <p>Love</p>\r\n");
            EndContext();
#line 58 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
                        }

#line default
#line hidden
            BeginContext(2505, 72, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 62 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
            c++;
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2630, 40, true);
            WriteLiteral("        <h1>No Images to display!</h1>\r\n");
            EndContext();
#line 68 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\ImageGallery.cshtml"
    }

#line default
#line hidden
            BeginContext(2677, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EbiMiMi.Pages.ImageGalleryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EbiMiMi.Pages.ImageGalleryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EbiMiMi.Pages.ImageGalleryModel>)PageContext?.ViewData;
        public EbiMiMi.Pages.ImageGalleryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
