#pragma checksum "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13c0f50a90c67037a6cb5b9752e4f0bec9fa4e28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Local_Details), @"mvc.1.0.view", @"/Views/Local/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Local/Details.cshtml", typeof(AspNetCore.Views_Local_Details))]
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
#line 1 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\_ViewImports.cshtml"
using SAGRE;

#line default
#line hidden
#line 2 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\_ViewImports.cshtml"
using SAGRE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13c0f50a90c67037a6cb5b9752e4f0bec9fa4e28", @"/Views/Local/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7dffafab25414f942597a0eddd6318cd3c0d339", @"/Views/_ViewImports.cshtml")]
    public class Views_Local_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SAGRE.Models.LocalModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do Local";

#line default
#line hidden
            BeginContext(87, 230, true);
            WriteLiteral("\r\n<div class=\"col mt-2\">\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\"><a href=\"#\">Ínicio</a></li>\r\n            <li class=\"breadcrumb-item active\" aria-current=\"page\">");
            EndContext();
            BeginContext(318, 17, false);
#line 11 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                                                              Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(335, 226, true);
            WriteLiteral("</li>\r\n        </ol>\r\n    </nav>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h5> <i class=\"fas fa-layer-group mr-3\"></i> ");
            EndContext();
            BeginContext(562, 36, false);
#line 19 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(598, 307, true);
            WriteLiteral(@"</h5>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""row"">
                                <div class=""col-2 font-weight-bold"">
                                    ");
            EndContext();
            BeginContext(906, 40, false);
#line 26 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(946, 130, true);
            WriteLiteral(":\r\n                                </div>\r\n                                <div class=\"col\">\r\n                                    ");
            EndContext();
            BeginContext(1077, 36, false);
#line 29 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 267, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <hr />
                            <div class=""row"">
                                <div class=""col-2 font-weight-bold"">
                                    ");
            EndContext();
            BeginContext(1381, 41, false);
#line 35 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Sigla));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 130, true);
            WriteLiteral(":\r\n                                </div>\r\n                                <div class=\"col\">\r\n                                    ");
            EndContext();
            BeginContext(1553, 37, false);
#line 38 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Sigla));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 267, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <hr />
                            <div class=""row"">
                                <div class=""col-2 font-weight-bold"">
                                    ");
            EndContext();
            BeginContext(1858, 45, false);
#line 44 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1903, 94, true);
            WriteLiteral(":\r\n                                </div>\r\n                                <div class=\"col\">\r\n");
            EndContext();
#line 48 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                                         if (Model.Descricao == null)
                                        {

#line default
#line hidden
            BeginContext(2151, 123, true);
            WriteLiteral("                                            <label class=\"font-italic font-weight-light\">Sem Descrição Cadastrado</label>\r\n");
            EndContext();
#line 51 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(2451, 41, false);
#line 54 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                                                                                      
                                        }

#line default
#line hidden
            BeginContext(2576, 399, true);
            WriteLiteral(@"                                </div>
                            </div>
                            <hr />
                            <div class=""row"">
                                <div class=""col-2 font-weight-bold"">
                                    Setor
                                </div>
                                <div class=""col"">
                                    ");
            EndContext();
            BeginContext(2976, 42, false);
#line 65 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Setor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3018, 402, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <hr />
                            <div class=""row"">
                                <div class=""col-2 font-weight-bold"">
                                    Status
                                </div>
                                <div class=""col"">
                                    ");
            EndContext();
            BeginContext(3421, 38, false);
#line 74 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3459, 264, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row mt-3"">
                        <div class=""col text-right"">
                            ");
            EndContext();
            BeginContext(3723, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5487fc88fb624e5fbe5d551af7567745", async() => {
                BeginContext(3778, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3788, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3818, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "239b17e398c1409aa41344f1a4257a06", async() => {
                BeginContext(3895, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Details.cshtml"
                                                   WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3905, 142, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SAGRE.Models.LocalModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
