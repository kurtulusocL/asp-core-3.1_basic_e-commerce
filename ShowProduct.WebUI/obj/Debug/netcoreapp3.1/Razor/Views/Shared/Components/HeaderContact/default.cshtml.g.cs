#pragma checksum "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HeaderContact\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47dce10c0eb72833f54f2db5d5e1fd27e6afc19e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderContact_default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderContact/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47dce10c0eb72833f54f2db5d5e1fd27e6afc19e", @"/Views/Shared/Components/HeaderContact/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11add9a650a383c1f7977984abb5db93c5996ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeaderContact_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HeaderContact\default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HeaderContact\default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <i class=\"fa fa-envelope\"></i>\r\n            ");
#nullable restore
#line 11 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HeaderContact\default.cshtml"
       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            <i class=\"fa fa-phone-alt\"></i>\r\n            ");
#nullable restore
#line 15 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HeaderContact\default.cshtml"
       Write(item.Whatsapp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\kurtulusocL\Documents\codeProject\Mvc\#Finishing\ShowProduct\ShowProduct.WebUI\Views\Shared\Components\HeaderContact\default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591