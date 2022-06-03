#pragma checksum "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a63401ce46ef33582f4b50cbea8f09dd1f392324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sonuc), @"mvc.1.0.view", @"/Views/Home/Sonuc.cshtml")]
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
#line 1 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\_ViewImports.cshtml"
using KelimeOyunu.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\_ViewImports.cshtml"
using KelimeOyunu.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63401ce46ef33582f4b50cbea8f09dd1f392324", @"/Views/Home/Sonuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84bcba882f049f2d350d4c36b3e3e3c75a3aa738", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sonuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SonucModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a63401ce46ef33582f4b50cbea8f09dd1f3923243441", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""/css/style.css"">
    <link rel=""stylesheet"" href=""/lib/icofont/icofont.min.css"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a63401ce46ef33582f4b50cbea8f09dd1f3923244734", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <header>
            Kelime Oyunu
        </header>
        <div class=""content"">
            <div class=""score-table"">
                <div class=""table-box"">
                    <table>
                        <tr>
                            <td>Sıra No</td>
                            <td>Ad Soyad</td>
                            <td>Puan</td>
                            <td>Artan Süre</td>
                            <td>Skor Zamanı</td>
                        </tr>
");
#nullable restore
#line 31 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                          
                            int sira = 1;
                            foreach (SkorlarModel item in Model.Skorlar)
                            {
                                string sure = (int)(item.ArtanSure / 60) + "." + (item.ArtanSure % 60);

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 37 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                                   Write(sira);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 38 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                                   Write(item.AdSoyad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 39 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                                   Write(item.Puan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                                   Write(sure);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 41 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                                   Write(item.Zaman.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                                sira++;
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <div class=\"my-score\">\r\n                <div class=\"score-box\">");
#nullable restore
#line 52 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                                  Write(Model.OturumModel.Puan);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>Puan</div>\r\n                <div class=\"time-box\">");
#nullable restore
#line 53 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                                 Write(Model.OturumModel.ArtanSure);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>Kalan Saniye</div>\r\n                <div class=\"crrct-box\">");
#nullable restore
#line 54 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\Sonuc.cshtml"
                                  Write(Model.DogruSayisi);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<br>Doğru Cevap</div>
                <div onclick=""location.href='/'"" style=""cursor:pointer; font-size:20px;""><i class=""icofont-refresh""></i>&nbsp;&nbsp; Yeniden Başla</div>
            </div>
        </div>
        <footer><i class=""icofont-bubble-right""></i>&nbsp;&nbsp;&nbsp;&nbsp; Hazar Arda TÜYSÜZ&nbsp;&nbsp;&nbsp;&nbsp;<br>&nbsp;&nbsp;&nbsp;&nbsp;Internet Programcılığı II&nbsp;&nbsp;&nbsp;&nbsp;<i class=""icofont-bubble-left""></i></footer>    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SonucModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
