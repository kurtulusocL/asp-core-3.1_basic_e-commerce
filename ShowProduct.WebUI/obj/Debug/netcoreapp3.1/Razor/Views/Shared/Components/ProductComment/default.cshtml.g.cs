#pragma checksum "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\ProductComment\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee47afa3a8eccd220d706bcae55a3bcda4070212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductComment_default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductComment/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee47afa3a8eccd220d706bcae55a3bcda4070212", @"/Views/Shared/Components/ProductComment/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11add9a650a383c1f7977984abb5db93c5996ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductComment_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/statics/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height:50px;max-width:50px;min-height:50px;min-width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\ProductComment\default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\ProductComment\default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"reviews-submitted\">\r\n        <div class=\"reviewer\">");
#nullable restore
#line 9 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\ProductComment\default.cshtml"
                         Write(item.NameSuname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <span>");
#nullable restore
#line 9 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\ProductComment\default.cshtml"
                                                  Write(item.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee47afa3a8eccd220d706bcae55a3bcda40702127290", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\ProductComment\default.cshtml"
AddHtmlAttributeValue("", 371, item.NameSuname, 371, 16, false);

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
            WriteLiteral("\r\n            ");
#nullable restore
#line 12 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\ProductComment\default.cshtml"
       Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        ");
#nullable restore
#line 14 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\ProductComment\default.cshtml"
   Write(await Component.InvokeAsync("CommentHit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\ProductComment\default.cshtml"
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
