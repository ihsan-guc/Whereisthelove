#pragma checksum "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\Anasayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b81cee383c64100e496247ad7b4646557c435e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_Index), @"mvc.1.0.view", @"/Views/Anasayfa/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b81cee383c64100e496247ad7b4646557c435e9", @"/Views/Anasayfa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Anasayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\EysanGuc\source\repos\Whereisthelove\Admin\Views\Anasayfa\Index.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b81cee383c64100e496247ad7b4646557c435e93440", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css""
          integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"" />
    <link rel=""stylesheet"" href=""/css/style.css"">
    <title>Where Is The Love</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b81cee383c64100e496247ad7b4646557c435e94847", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""#"">WITL</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                    aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">Ana Sayfa <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Neler Oluyor ? </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""");
                WriteLiteral(@">İletişim</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class=""container mt-5 home-page"">
        <div class=""row"">
            <div class=""row w-100"">
                <div class=""col-lg-2 text-center"">
                    <a href=""tıklandığında dbden sadece 2021 deki veriler gelir"">2021</a>
                </div>
                <div class=""col-lg-2 text-center"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 1997, "\"", 2004, 0);
                EndWriteAttribute();
                WriteLiteral(">2020</a>\r\n                </div>\r\n                <div class=\"col-lg-2 text-center\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 2114, "\"", 2121, 0);
                EndWriteAttribute();
                WriteLiteral(">2019</a>\r\n                </div>\r\n                <div class=\"col-lg-2 text-center\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 2231, "\"", 2238, 0);
                EndWriteAttribute();
                WriteLiteral(">2018</a>\r\n                </div>\r\n                <div class=\"col-lg-2 text-center\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 2348, "\"", 2355, 0);
                EndWriteAttribute();
                WriteLiteral(">2017</a>\r\n                </div>\r\n                <div class=\"col-lg-2 text-center\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 2465, "\"", 2472, 0);
                EndWriteAttribute();
                WriteLiteral(@">2016</a>
                </div>
            </div>
            <div class=""col-lg-12"">
                <div class=""row"">
                    <div class=""col-lg-3"">
                        <a href=""/Anasayfa/SinglePage"">
                            <div class=""card"">
                                <div class=""card-body text-center""
                                     style=""background-image: url(https://ichef.bbci.co.uk/news/640/cpsprodpb/92A6/production/_116324573_sh0upmrbfuqj0dkgbhbhxa.jpg);"">
                                    <h5 class=""card-title fixed-bottom d-none""> Feyza Nur Saydam</h5>
                                </div>
                            </div>
                        </a>
                    </div>

                    <div class=""col-lg-3"">
                        <a href=""Anasayfa/SinglePage"">
                            <div class=""card"">
                                <div class=""card-body text-center""
                                     style=""background-i");
                WriteLiteral(@"mage: url(https://ichef.bbci.co.uk/news/640/cpsprodpb/92A6/production/_116324573_sh0upmrbfuqj0dkgbhbhxa.jpg);"">
                                    <h5 class=""card-title fixed-bottom d-none""> Feyza Nur Saydam</h5>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class=""col-lg-3"">
                        <a href=""Anasayfa/SinglePage"">
                            <div class=""card"">
                                <div class=""card-body text-center""
                                     style=""background-image: url(https://ichef.bbci.co.uk/news/640/cpsprodpb/92A6/production/_116324573_sh0upmrbfuqj0dkgbhbhxa.jpg);"">
                                    <h5 class=""card-title fixed-bottom d-none""> Feyza Nur Saydam</h5>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class=""col-lg-3"">
        ");
                WriteLiteral(@"                <a href=""Anasayfa/SinglePage"">
                            <div class=""card"">
                                <div class=""card-body text-center""
                                     style=""background-image: url(https://ichef.bbci.co.uk/news/640/cpsprodpb/92A6/production/_116324573_sh0upmrbfuqj0dkgbhbhxa.jpg);"">
                                    <h5 class=""card-title fixed-bottom d-none""> Feyza Nur Saydam</h5>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class=""col-lg-3"">
                        <a href=""Anasayfa/SinglePage"">
                            <div class=""card"">
                                <div class=""card-body text-center""
                                     style=""background-image: url(https://ichef.bbci.co.uk/news/640/cpsprodpb/92A6/production/_116324573_sh0upmrbfuqj0dkgbhbhxa.jpg);"">
                                    <h5 class=""card-title fixed-botto");
                WriteLiteral(@"m d-none""> Feyza Nur Saydam</h5>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class=""col-lg-3"">
                        <a href=""Anasayfa/SinglePage"">
                            <div class=""card"">
                                <div class=""card-body text-center""
                                     style=""background-image: url(https://ichef.bbci.co.uk/news/640/cpsprodpb/92A6/production/_116324573_sh0upmrbfuqj0dkgbhbhxa.jpg);"">
                                    <h5 class=""card-title fixed-bottom d-none""> Feyza Nur Saydam</h5>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class=""col-lg-3"">
                        <a href=""Anasayfa/SinglePage"">
                            <div class=""card"">
                                <div class=""card-body text-center""
                  ");
                WriteLiteral(@"                   style=""background-image: url(https://ichef.bbci.co.uk/news/640/cpsprodpb/92A6/production/_116324573_sh0upmrbfuqj0dkgbhbhxa.jpg);"">
                                    <h5 class=""card-title fixed-bottom d-none""> Feyza Nur Saydam</h5>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class=""col-lg-3"">
                        <a href=""Anasayfa/SinglePage"">
                            <div class=""card"">
                                <div class=""card-body text-center""
                                     style=""background-image: url(https://ichef.bbci.co.uk/news/640/cpsprodpb/92A6/production/_116324573_sh0upmrbfuqj0dkgbhbhxa.jpg);"">
                                    <h5 class=""card-title fixed-bottom d-none""> Feyza Nur Saydam</h5>
                                </div>
                            </div>
                        </a>
                    </div>

            ");
                WriteLiteral(@"    </div>


            </div>
        </div>
    </div>
    <!-- Footer -->
    <footer class=""bg-light text-center text-lg-start mt-5"">
        <!-- Grid container -->
        <div class=""container p-4"">
            <!--Grid row-->
            <div class=""row"">
                <!--Grid column-->
                <div class=""col-lg-6 col-md-12 mb-4 mb-md-0"">
                    <h5 class=""text-uppercase"">Footer Content</h5>

                    <p>
                        Lorem ipsum dolor sit amet consectetur, adipisicing elit. Iste atque ea quis
                        molestias. Fugiat pariatur maxime quis culpa corporis vitae repudiandae aliquam
                        voluptatem veniam, est atque cumque eum delectus sint!
                    </p>
                </div>
                <!--Grid column-->
                <!--Grid column-->
                <div class=""col-lg-3 col-md-6 mb-4 mb-md-0"">
                    <h5 class=""text-uppercase"">Faydalı Numaralar</h5>

         ");
                WriteLiteral(@"           <ul class=""list-unstyled mb-0"">
                        <li>
                            <a href=""#!"" class=""text-dark"">Numara 1</a>
                        </li>
                        <li>
                            <a href=""#!"" class=""text-dark"">Numara 2</a>
                        </li>
                        <li>
                            <a href=""#!"" class=""text-dark"">Numara 3</a>
                        </li>
                        <li>
                            <a href=""#!"" class=""text-dark"">Numara 4</a>
                        </li>
                    </ul>
                </div>
                <!--Grid column-->
                <!--Grid column-->
                <div class=""col-lg-3 col-md-6 mb-4 mb-md-0"">
                    <h5 class=""text-uppercase mb-0"">Faydalı Linkler</h5>

                    <ul class=""list-unstyled"">
                        <li>
                            <a href=""#!"" class=""text-dark"">Link 1</a>
                        </li>
   ");
                WriteLiteral(@"                     <li>
                            <a href=""#!"" class=""text-dark"">Link 2</a>
                        </li>
                        <li>
                            <a href=""#!"" class=""text-dark"">Link 3</a>
                        </li>
                        <li>
                            <a href=""#!"" class=""text-dark"">Link 4</a>
                        </li>
                    </ul>
                </div>
                <!--Grid column-->
            </div>
            <!--Grid row-->
        </div>
        <!-- Grid container -->
        <!-- Copyright -->
        <div class=""text-center p-3"" style=""background-color: rgba(0, 0, 0, 0.2)"">
            © 2020 Copyright:
            <a class=""text-dark"" href=""https://whereisthelove.com"">WhereIsTheLove.com</a>
        </div>
        <!-- Copyright -->
    </footer>
    <!-- Footer -->
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
            integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qp");
                WriteLiteral(@"g6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""
            integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
            crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
