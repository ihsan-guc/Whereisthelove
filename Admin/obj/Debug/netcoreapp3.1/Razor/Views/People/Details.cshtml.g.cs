#pragma checksum "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc26cb984c1008a6b1b5cb45b39e08426e21a6c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Details), @"mvc.1.0.view", @"/Views/People/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be986a1e2018e5ae6101bd352466e6a7da6d438", @"/Views/People/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Whereisthelove.Data.Domain.Entities.People>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card shadow-sm\">\r\n            <div class=\"card-body\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-4\">\r\n");
#nullable restore
#line 9 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\Details.cshtml"
                              var Fotograf = "";
                                if (Model.Image != null)
                                    Fotograf = "http://localhost:50000/Images/" + Model.Image;
                                else
                                    Fotograf = "";
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"width:100%; text-align:center\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 736, "\"", 751, 1);
#nullable restore
#line 10 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\Details.cshtml"
WriteAttributeValue("", 417, Model.Image, 417, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-thumbnail"" alt=""..."">
                            </div>
                        </div>
                        <div class=""col-md-8"">
                            <ul class=""list-group"">
                                <li class=""list-group-item"">
                                    Ad:
                                    <span class=""float-right"">");
#nullable restore
#line 17 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\Details.cshtml"
                                                         Write(Html.DisplayFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Soyadı:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 21 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\Details.cshtml"
                                                         Write(Html.DisplayFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Başlık:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 25 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\Details.cshtml"
                                                         Write(Html.DisplayFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Haber:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 29 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\Details.cshtml"
                                                         Write(Html.DisplayFor(m => m.News));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Açıklama:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 33 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\Details.cshtml"
                                                         Write(Html.DisplayFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Detay:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 37 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\Details.cshtml"
                                                         Write(Html.DisplayFor(m => m.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Whereisthelove.Data.Domain.Entities.People> Html { get; private set; }
    }
}
#pragma warning restore 1591
