#pragma checksum "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313e6fb3c46db5fef868f79347120aa708401b1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EbiMiMi.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(EbiMiMi.Pages.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313e6fb3c46db5fef868f79347120aa708401b1e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02afd2a00a83b7330be876db360311f4e43f04a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/ImageGallery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\PersonalWebApp\EbiMiMi\EbiMiMi\EbiMiMi\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 798, true);
            WriteLiteral(@"<div class=""boxing"">
    Home💑
</div>

<div class=""parallax""></div>

<div class=""clocktime"">
    <h4>💙💜💚</h4>
    <div class=""countup"" id=""countup1"">
        <span class=""timeel days"">00</span>
        <span class=""timeel timeRefDays"">Days</span>
        <span class=""timeel hours"">00</span>
        <span class=""timeel timeRefHours"">Hours</span>
        <span class=""timeel minutes"">00</span>
        <span class=""timeel timeRefMinutes"">Minutes</span>
        <span class=""timeel seconds"">00</span>
        <span class=""timeel timeRefSeconds"">Seconds</span>
    </div>
    
</div>

<div class=""clock"" style=""margin:2em;""></div>


<div class=""parallax""></div>

<div class=""clocktime"">
    <h4>
        Click the button below to see our photos hehe
    </h4>

    ");
            EndContext();
            BeginContext(869, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "313e6fb3c46db5fef868f79347120aa708401b1e4680", async() => {
                BeginContext(912, 13, true);
                WriteLiteral("Our Photos 🎔");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(929, 1433, true);
            WriteLiteral(@"
</div>

<div class=""parallax""></div>

<script>
    window.onload = function () {
        // Month Day, Year Hour:Minute:Second, id-of-element-container
        countUpFromTime(""Mar 1, 2019 00:00:00"", 'countup1'); //Date Start
    };
    function countUpFromTime(countFrom, id) {
        countFrom = new Date(countFrom).getTime();
        var now = new Date(),
            countFrom = new Date(countFrom),
            timeDifference = (now - countFrom);

        var secondsInADay = 60 * 60 * 1000 * 24,
            secondsInAHour = 60 * 60 * 1000;

        days = Math.floor(timeDifference / (secondsInADay) * 1);
        hours = Math.floor((timeDifference % (secondsInADay)) / (secondsInAHour) * 1);
        mins = Math.floor(((timeDifference % (secondsInADay)) % (secondsInAHour)) / (60 * 1000) * 1);
        secs = Math.floor((((timeDifference % (secondsInADay)) % (secondsInAHour)) % (60 * 1000)) / 1000 * 1);

        var idEl = document.getElementById(id);
        idEl.getElementsByClassName");
            WriteLiteral(@"('days')[0].innerHTML = days;
        idEl.getElementsByClassName('hours')[0].innerHTML = hours;
        idEl.getElementsByClassName('minutes')[0].innerHTML = mins;
        idEl.getElementsByClassName('seconds')[0].innerHTML = secs;

        clearTimeout(countUpFromTime.interval);
        countUpFromTime.interval = setTimeout(function () { countUpFromTime(countFrom, id); }, 1000);
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
