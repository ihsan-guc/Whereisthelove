#pragma checksum "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c20cfe6da020f6cd80cf749b1e8d2436ebd9476"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_PeopleDelete), @"mvc.1.0.view", @"/Views/People/PeopleDelete.cshtml")]
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
#line 1 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c20cfe6da020f6cd80cf749b1e8d2436ebd9476", @"/Views/People/PeopleDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_People_PeopleDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Whereisthelove.Data.Domain.Entities.People>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
 using (Html.BeginForm("DeleteConfirmed", "People", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
Write(Html.HiddenFor(p => p.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card shadow-sm\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                          var Fotograf = "";
                            if (Model.Image != null)
                                Fotograf = "http://localhost:50000/Images/" + Model.Image;
                            else
                                Fotograf = "";
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4\">\r\n                            <div style=\"width:100%; text-align:center\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 795, "\"", 810, 1);
#nullable restore
#line 19 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
WriteAttributeValue("", 801, Fotograf, 801, 9, false);

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
#line 26 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Soyadı:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 30 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Başlık:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 34 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Haber:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 38 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.News));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Açıklama:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 42 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Detay:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 46 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Ölüm Yeri:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 50 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.PlaceDeath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Neden Öldürüldü:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 54 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.WhyKilled));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Kim tarafından öldürüldü:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 58 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.ByWhom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Korunma talebi:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 62 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.IsProtection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Öldürülme şekli:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 66 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.WayKilled));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Failin durumu:\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 70 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"list-group-item\">\r\n                                    Haberin Kaynağı :\r\n                                    <span class=\"float-right\">");
#nullable restore
#line 74 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
                                                         Write(Html.DisplayFor(m => m.SourceLink));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""float-right mt-2"">
        <button class=""btn btn-outline-primary"" type=""submit""> Silin </button>
    </div>
    <div class=""float-right mt-2"">
        <a class=""btn btn-outline-success""");
            BeginWriteAttribute("href", " href=\"", 4700, "\"", 4737, 1);
#nullable restore
#line 87 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
WriteAttributeValue("", 4707, Url.Action("Index", "People"), 4707, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Geri </a>\r\n    </div>\r\n");
#nullable restore
#line 89 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\People\PeopleDelete.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Whereisthelove.Data.Domain.Entities.People> Html { get; private set; }
    }
}
#pragma warning restore 1591
