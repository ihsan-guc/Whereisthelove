#pragma checksum "E:\Github\Whereisthelove\Admin\Views\People\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3da10acf7dede278600652d49cdf59b8c1f42f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Create), @"mvc.1.0.view", @"/Views/People/Create.cshtml")]
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
#line 1 "E:\Github\Whereisthelove\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Github\Whereisthelove\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3da10acf7dede278600652d49cdf59b8c1f42f0", @"/Views/People/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admin.Models.PeopleViewModel.PeopleCEViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Github\Whereisthelove\Admin\Views\People\Create.cshtml"
  
    ViewBag.Title = "İletişim Ekle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\Github\Whereisthelove\Admin\Views\People\Create.cshtml"
 using (Html.BeginForm("CreateConfirmed", "People", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Github\Whereisthelove\Admin\Views\People\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        ");
#nullable restore
#line 11 "E:\Github\Whereisthelove\Admin\Views\People\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "E:\Github\Whereisthelove\Admin\Views\People\Create.cshtml"
   Write(await Html.PartialAsync("_CreateEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 14 "E:\Github\Whereisthelove\Admin\Views\People\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admin.Models.PeopleViewModel.PeopleCEViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
