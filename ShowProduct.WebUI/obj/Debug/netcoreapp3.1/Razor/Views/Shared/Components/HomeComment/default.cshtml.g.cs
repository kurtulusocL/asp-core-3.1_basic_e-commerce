#pragma checksum "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae2ec8c583194693661b0426b36fe01f600dd37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomeComment_default), @"mvc.1.0.view", @"/Views/Shared/Components/HomeComment/default.cshtml")]
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
#line 1 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\_ViewImports.cshtml"
using ShowProduct.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\_ViewImports.cshtml"
using ShowProduct.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\_ViewImports.cshtml"
using ShowProduct.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\_ViewImports.cshtml"
using ShowProduct.Core.CrossCuttingConcert.Toolbox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\_ViewImports.cshtml"
using ShowProduct.Core.CrossCuttingConcert.DTOs.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\_ViewImports.cshtml"
using ShowProduct.Core.CrossCuttingConcert.DTOs.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\_ViewImports.cshtml"
using ShowProduct.Core.CrossCuttingConcert.Identities.MicrosoftIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\_ViewImports.cshtml"
using ShowProduct.Core.CrossCuttingConcert.DTOs.Entities.UpdateModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae2ec8c583194693661b0426b36fe01f600dd37", @"/Views/Shared/Components/HomeComment/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11add9a650a383c1f7977984abb5db93c5996ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomeComment_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/statics/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height:150px;max-width:150px;min-height:150px;min-width:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6\">\r\n        <div class=\"review-slider-item\">\r\n            <div class=\"review-img\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aae2ec8c583194693661b0426b36fe01f600dd377372", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
AddHtmlAttributeValue("", 268, item.NameSuname, 268, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"review-text\">\r\n                <h2>");
#nullable restore
#line 14 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
               Write(item.NameSuname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 15 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
                 if (item.ProductId != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aae2ec8c583194693661b0426b36fe01f600dd379812", async() => {
                WriteLiteral("\r\n                        <h3>Product: ");
#nullable restore
#line 18 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
                                Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
                                                                      WriteLiteral(item.ProductId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"ratting\">\r\n                   ");
#nullable restore
#line 22 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
              Write(item.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <p>\r\n                    ");
#nullable restore
#line 25 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
               Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HomeComment\default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
