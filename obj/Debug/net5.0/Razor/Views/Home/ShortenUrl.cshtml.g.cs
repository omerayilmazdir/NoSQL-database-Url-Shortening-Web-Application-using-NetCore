#pragma checksum "C:\Users\omera\OneDrive\Masaüstü\CoreIdentityWithMongoDB\Views\Home\ShortenUrl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6c3847ff88c1cd0c48c89c4e7b62e574924b94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShortenUrl), @"mvc.1.0.view", @"/Views/Home/ShortenUrl.cshtml")]
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
#line 1 "C:\Users\omera\OneDrive\Masaüstü\CoreIdentityWithMongoDB\Views\_ViewImports.cshtml"
using CoreIdentityWithMongoDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omera\OneDrive\Masaüstü\CoreIdentityWithMongoDB\Views\_ViewImports.cshtml"
using CoreIdentityWithMongoDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6c3847ff88c1cd0c48c89c4e7b62e574924b94", @"/Views/Home/ShortenUrl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae4ef662d3695327bbcd8c9769d37197d9e54569", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ShortenUrl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShortenedUrl>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omera\OneDrive\Masaüstü\CoreIdentityWithMongoDB\Views\Home\ShortenUrl.cshtml"
  
    ViewData["Title"] = "Kısaltılmış link";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div style=""width: 100%; padding: 30px; background-color: #e3f2fd;>


    <div class=""jumbotron"">
        <h1 class=""display-4"">İşleminiz tamam!</h1>
        <p class=""lead"">Kısaltılmış Url bilgileriniz.</p>
        <div>
            <div>Kısa kod: ");
#nullable restore
#line 15 "C:\Users\omera\OneDrive\Masaüstü\CoreIdentityWithMongoDB\Views\Home\ShortenUrl.cshtml"
                      Write(Model.ShortCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <span>Kısa Url: <a");
            BeginWriteAttribute("href", " href=\"", 435, "\"", 457, 1);
#nullable restore
#line 16 "C:\Users\omera\OneDrive\Masaüstü\CoreIdentityWithMongoDB\Views\Home\ShortenUrl.cshtml"
WriteAttributeValue("", 442, Model.ShortUrl, 442, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"");
            BeginWriteAttribute("onclick", " onclick=\"", 474, "\"", 516, 3);
            WriteAttributeValue("", 484, "updateItemCount(", 484, 16, true);
#nullable restore
#line 16 "C:\Users\omera\OneDrive\Masaüstü\CoreIdentityWithMongoDB\Views\Home\ShortenUrl.cshtml"
WriteAttributeValue("", 500, Model.ShortUrl, 500, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 515, ")", 515, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\omera\OneDrive\Masaüstü\CoreIdentityWithMongoDB\Views\Home\ShortenUrl.cshtml"
                                                                                                            Write(Model.ShortUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n            <div>Uzun Url: ");
#nullable restore
#line 17 "C:\Users\omera\OneDrive\Masaüstü\CoreIdentityWithMongoDB\Views\Home\ShortenUrl.cshtml"
                      Write(Model.OriginalUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
        </div>
        <hr class=""my-4"">
        <p>Bizi tercih ettiğiniz için teşekkürler.</p>
        <p class=""lead"">
            <a class=""btn btn-primary btn-lg"" href=""ShortUrl"" role=""button"">Link kısaltıcıya dön</a>
        </p>
    </div>
</div>


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShortenedUrl> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
