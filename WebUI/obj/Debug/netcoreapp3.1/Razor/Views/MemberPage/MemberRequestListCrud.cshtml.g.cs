#pragma checksum "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf815cbf30cb54120e39687aad5ba769eebbc27b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberPage_MemberRequestListCrud), @"mvc.1.0.view", @"/Views/MemberPage/MemberRequestListCrud.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf815cbf30cb54120e39687aad5ba769eebbc27b", @"/Views/MemberPage/MemberRequestListCrud.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberPage_MemberRequestListCrud : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUI.Models.AdViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MemberPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MemberRequestCancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MemberRequestAccept", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MemberRequestReject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""contact"" class=""section-bg"">
    <div class=""container"" data-aos=""fade-up"">

        <div class=""section-header"">
            <h3>İSTEKLERİM</h3>
            <p>Buradan istek attığınız ilanları ve ilanlarınıza atılmış istekleri görüntüleyebilirsiniz.</p>
        </div>
    </div>
</section>
<br />
<br />

<div class=""row"">

    <div class="" col-md-1 "">
    </div>

    <div class="" col-md-5 "">

        <div class=""left"">
            <h4>Benim isteklerim</h4>
            <table class=""table table-bordered"">
                <thead>

                    <tr>
");
            WriteLiteral(@"
                        <th scope=""col""> Ad-Soyad</th>
                        <th scope=""col"">Mail Adres</th>
                        <th scope=""col"">İlan Başlık</th>
                        <th scope=""col"">Kategori Adı</th>
                        <th scope=""col"">Şehir</th>
                        <th scope=""col"">İlan Bigisi</th>
                        <th scope=""col"">İstek Durum </th>
                        <th scope=""col"">İşlemler</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 45 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                     if (Model.AdInfo != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                         foreach (var item in Model.AdInfo)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                             if (item.RequestMemberID == Model.MemberID)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n");
            WriteLiteral("\r\n                                    <td>");
#nullable restore
#line 54 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.MemberName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                                    Write(item.MemberSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 55 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.MemberMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 56 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.AdTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 57 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 58 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 59 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.AdInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 60 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.RequestNameState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf815cbf30cb54120e39687aad5ba769eebbc27b9801", async() => {
                WriteLiteral("\r\n                                            <i class=\"fas fa-trash-alt\">\r\n                                            </i>\r\n                                            iptal\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                                                                                                                        WriteLiteral(item.RequestID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>

    </div>
    <!-- **************** -->
    <div class="" col-md-6"">
        <div class=""right"">
            <h4>Bana Gelen İstekler</h4>
            <table class=""table table-bordered"">
                <thead>

                    <tr>
");
            WriteLiteral(@"
                        <th scope=""col"">İlan Başlık</th>
                        <th scope=""col""> Ad Soyad</th>
                        <th scope=""col"">Mail Adres</th>
                        <th scope=""col"">Kategori Adı</th>
                        <th scope=""col"">Şehir</th>
                        <th scope=""col"">İlan Bigisi</th>
                        <th scope=""col"">İstek Durum</th>
                        <th scope=""col"">İşlemler</th>
                    </tr>
                </thead>

                <tbody>
");
#nullable restore
#line 101 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                     if (Model.AdInfo != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                         foreach (var item in Model.AdInfo)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                             if (item.MemberID == Model.MemberID)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n");
            WriteLiteral("\r\n                                    <td>");
#nullable restore
#line 110 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.MemberName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 110 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                                    Write(item.MemberSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 111 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.MemberMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 112 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.AdTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 113 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 114 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 115 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.AdInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 116 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                   Write(item.RequestNameState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf815cbf30cb54120e39687aad5ba769eebbc27b17885", async() => {
                WriteLiteral("\r\n                                            <i class=\"fas fa-check-square\">\r\n                                            </i>\r\n                                            kabul\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                                                                                                                      WriteLiteral(item.RequestID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf815cbf30cb54120e39687aad5ba769eebbc27b20711", async() => {
                WriteLiteral("\r\n                                            <i class=\"fas fa-window-close\">\r\n                                            </i>\r\n                                            red\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                                                                                                                                        WriteLiteral(item.RequestID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 130 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\Aynur\OneDrive\Masaüstü\BirElinVerdigi\WebUI\Views\MemberPage\MemberRequestListCrud.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUI.Models.AdViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591