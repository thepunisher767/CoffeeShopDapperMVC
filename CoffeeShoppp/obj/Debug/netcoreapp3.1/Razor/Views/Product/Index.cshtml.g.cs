#pragma checksum "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a879c0356ad3f05fdd5296771e89bf7ad789c8f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a879c0356ad3f05fdd5296771e89bf7ad789c8f3", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e95aca42e86a2ea5abace49bc44feeccb592ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\Product\Index.cshtml"
 foreach (Product product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 72, "\"", 111, 2);
            WriteAttributeValue("", 79, "/Product/Details?_id=", 79, 21, true);
#nullable restore
#line 6 "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\Product\Index.cshtml"
WriteAttributeValue("", 100, product.id, 100, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\Product\Index.cshtml"
                                          Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br /><br />\r\n");
#nullable restore
#line 7 "C:\devbuild4\CoffeeShoppp\CoffeeShoppp\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
