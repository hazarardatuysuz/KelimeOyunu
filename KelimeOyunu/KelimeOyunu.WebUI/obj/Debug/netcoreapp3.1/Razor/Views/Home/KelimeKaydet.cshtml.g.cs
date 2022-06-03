#pragma checksum "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\KelimeKaydet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d1403506b2f40832426f403ffd4e4f99ad89af6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_KelimeKaydet), @"mvc.1.0.view", @"/Views/Home/KelimeKaydet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d1403506b2f40832426f403ffd4e4f99ad89af6", @"/Views/Home/KelimeKaydet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84bcba882f049f2d350d4c36b3e3e3c75a3aa738", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_KelimeKaydet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KelimeOyunu.Entity.Kelime>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\KelimeKaydet.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1403506b2f40832426f403ffd4e4f99ad89af64385", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""/css/eStyle.css"">
    <link rel=""stylesheet"" href=""/lib/icofont/icofont.min.css"">
    <style>
        .content {
            height: calc(80vh - 300px);
            margin-top: 30px;
        }

            .content .score-table {
                height: 45vh;
                overflow-y: auto;
            }

                .content .score-table .table-box {
                    background-color: rgb(255, 255, 255);
                    width: 70vw;
                    margin-left: 15vw;
                    padding: 25px;
                    border-radius: 20px;
                }

                .content .score-table table {
                    width: 100%;
                    border-collapse: collapse;
                }

                    .content .score-table");
                WriteLiteral(@" table tr:first-child td {
                        font-family: 'Oswald', sans-serif;
                        font-weight: bold;
                        font-size: 1.2em;
                        border-bottom: 2px solid gray;
                    }

                    .content .score-table table tr:nth-child(even) {
                        background-color: rgba(0, 0, 0, .2);
                    }


                    .content .score-table table tr td {
                        font-family: 'Montserrat', sans-serif;
                        font-size: .9em;
                        padding: 5px;
                    }

                        .content .score-table table tr td:last-child {
                            color:red;
                            text-decoration:underline;
                            cursor:pointer;
                        }

                        ::-webkit-scrollbar {
                            width: 5px;
                        }


        ::-webkit-scr");
                WriteLiteral(@"ollbar-track {
            background: #f1f1f1;
        }


        ::-webkit-scrollbar-thumb {
            background: #888;
        }

            ::-webkit-scrollbar-thumb:hover {
                background: #555;
            }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1403506b2f40832426f403ffd4e4f99ad89af67743", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <header>
            Kelime Oyunu
        </header>
        <div class=""menu"" style=""height:20vh;"">
            <div class=""gss"">
                <div class=""gss-ct"">
                    <input type=""text"" name=""kelime"" id=""kelime"" style=""top:-70px;"" placeholder=""Kelime"">
                    <input type=""text"" name=""soru"" id=""soru"" style=""width:600px;"" placeholder=""Soru"">
                    <button class=""sendword"" id=""kkaydet"" style=""left:600px"">Kaydet </button>
                </div>
            </div>
        </div>
        <div class=""content"">
            <div class=""score-table"">
                <div class=""table-box"">
                    <table id=""sorular"">
                        <tr>
                            <td>Soru No</td>
                            <td>Kelime Uzunluğu</td>
                            <td>Kelime</td>
                            <td>Soru</td>
                            <td>Son Kullanım Zamanı</td>
                    ");
                WriteLiteral("        <td>Sil</td>\r\n                        </tr>\r\n");
#nullable restore
#line 107 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\KelimeKaydet.cshtml"
                          
                            int sira = 1;
                            foreach (KelimeOyunu.Entity.Kelime item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 112 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\KelimeKaydet.cshtml"
                                   Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 113 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\KelimeKaydet.cshtml"
                                   Write(item.KelimeUzunluk);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 114 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\KelimeKaydet.cshtml"
                                   Write(item.SoruKelime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 115 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\KelimeKaydet.cshtml"
                                   Write(item.Aciklama);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 116 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\KelimeKaydet.cshtml"
                                   Write(item.SonKullanma.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>Sil</td>\r\n                                </tr>\r\n");
#nullable restore
#line 119 "C:\Users\Hazar\Desktop\KelimeOyunu\KelimeOyunu.WebUI\Views\Home\KelimeKaydet.cshtml"
                                sira++;
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    </table>
                </div>
            </div>
        </div>
        <footer><i class=""icofont-bubble-right""></i>&nbsp;&nbsp;&nbsp;&nbsp; Hazar Arda TÜYSÜZ&nbsp;&nbsp;&nbsp;&nbsp;<br>&nbsp;&nbsp;&nbsp;&nbsp;Internet Programcılığı II&nbsp;&nbsp;&nbsp;&nbsp;<i class=""icofont-bubble-left""></i></footer>    </div>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1403506b2f40832426f403ffd4e4f99ad89af611892", async() => {
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
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $(""body"").on(""click"", ""#kkaydet"", function () {
                var kl = $(""#kelime"").val();
                var sr = $(""#soru"").val();
                $.ajax({
                    url: ""/Home/KelimeKaydet"",
                    type: ""POST"",
                    dataType: ""json"",
                    data: { kelime: kl, soru: sr },
                    success: function (data) {
                        $(""#kelime"").val("""");
                        $(""#soru"").val("""");
                        alert(""Soru veritabanı ve aşağıdaki tabloya eklendi. "" + data.id);
                        var zamani = new Date(data.sonKullanma);
                        $('#sorular').append('<tr><td>' + data.id + '</td><td>' + data.kelimeUzunluk + '</td><td>' + data.soruKelime + '</td><td>' + data.aciklama + '</td><td>' + zamani.getDate() + '. ' + (zamani.getMonth() + 1) +'.' + zamani.getFullYear() +'</td></tr>');
                    }
             ");
                WriteLiteral(@"   })
            });

            $(""body"").on(""click"", "".content .score-table table tr td:last-child"", function () {
                var id = $(this).parent().find("">:first-child"").html();
                $(this).parent().remove();
                $.ajax({
                    url: ""/Home/KelimeSil"",
                    type: ""POST"",
                    dataType: ""json"",
                    data: { soruId: id },
                    success: function (data) {
                        alert(""Soru silindi."");
                    }
                })
            });
        });
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KelimeOyunu.Entity.Kelime>> Html { get; private set; }
    }
}
#pragma warning restore 1591
