#pragma checksum "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "515d53c5e11fc850ddd8c28a3d74e73cdf028009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
#line 1 "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\_ViewImports.cshtml"
using CoffeeShoppp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\_ViewImports.cshtml"
using CoffeeShoppp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515d53c5e11fc850ddd8c28a3d74e73cdf028009", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e95aca42e86a2ea5abace49bc44feeccb592ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 3 "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\Admin\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 3 "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\Admin\Details.cshtml"
             Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - $");
#nullable restore
#line 3 "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\Admin\Details.cshtml"
                                   Write(Math.Round(Model.Price, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<br />\r\n<br />\r\n<a href=\"/Admin\"/>Return to Admin</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
