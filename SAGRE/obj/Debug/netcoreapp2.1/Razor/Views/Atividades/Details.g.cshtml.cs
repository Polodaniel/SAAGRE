#pragma checksum "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7575cca7f967f417161ee84d93926831ef4f2a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Atividades_Details), @"mvc.1.0.view", @"/Views/Atividades/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Atividades/Details.cshtml", typeof(AspNetCore.Views_Atividades_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7575cca7f967f417161ee84d93926831ef4f2a6d", @"/Views/Atividades/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7dffafab25414f942597a0eddd6318cd3c0d339", @"/Views/_ViewImports.cshtml")]
    public class Views_Atividades_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SAGRE.Models.AtividadesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Boletim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
  
    ViewData["Title"] = "Detalhes da Atividade";

#line default
#line hidden
            BeginContext(96, 150, true);
            WriteLiteral("\r\n    <div class=\"col mt-2\">\r\n        <nav aria-label=\"breadcrumb\">\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(246, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "244bbb992ae641578fbb56de085540ac", async() => {
                BeginContext(290, 6, true);
                WriteLiteral("Ínicio");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(300, 51, true);
            WriteLiteral("</li>\r\n                <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(351, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cdb3ef021f4f0cb49e77eb760a34b5", async() => {
                BeginContext(398, 10, true);
                WriteLiteral("Atividades");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(412, 78, true);
            WriteLiteral("</li>\r\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
            EndContext();
            BeginContext(491, 17, false);
#line 12 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                                                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(508, 255, true);
            WriteLiteral("</li>\r\n            </ol>\r\n        </nav>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-header\">\r\n                        <h5> <i class=\"fas fa-people-carry mr-3\"></i> ");
            EndContext();
            BeginContext(764, 45, false);
#line 20 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                                                 Write(Html.DisplayFor(model => model.NomeAtividade));

#line default
#line hidden
            EndContext();
            BeginContext(809, 335, true);
            WriteLiteral(@"</h5>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <div class=""row"">
                                    <div class=""col-2 font-weight-bold"">
                                        ");
            EndContext();
            BeginContext(1145, 49, false);
#line 27 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.NomeAtividade));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 142, true);
            WriteLiteral(":\r\n                                    </div>\r\n                                    <div class=\"col\">\r\n                                        ");
            EndContext();
            BeginContext(1337, 45, false);
#line 30 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.NomeAtividade));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 291, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-2 font-weight-bold"">
                                        ");
            EndContext();
            BeginContext(1674, 54, false);
#line 36 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.DescricaoAtividade));

#line default
#line hidden
            EndContext();
            BeginContext(1728, 102, true);
            WriteLiteral(":\r\n                                    </div>\r\n                                    <div class=\"col\">\r\n");
            EndContext();
#line 40 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                             if (Model.DescricaoAtividade == null)
                                            {

#line default
#line hidden
            BeginContext(2005, 127, true);
            WriteLiteral("                                                <label class=\"font-italic font-weight-light\">Sem Descrição Cadastrado</label>\r\n");
            EndContext();
#line 43 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
            BeginContext(2325, 50, false);
#line 46 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.DescricaoAtividade));

#line default
#line hidden
            EndContext();
#line 46 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                                                                                   
                                            }

#line default
#line hidden
            BeginContext(2467, 436, true);
            WriteLiteral(@"                                    </div>
                                </div>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-2 font-weight-bold"">
                                        Status
                                    </div>
                                    <div class=""col"">
                                        ");
            EndContext();
            BeginContext(2904, 38, false);
#line 57 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2942, 292, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row mt-3"">
                            <div class=""col text-right"">
                                ");
            EndContext();
            BeginContext(3234, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62966c0f6f324cecad2333d197b81520", async() => {
                BeginContext(3289, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3299, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3333, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d1ab3a5b9e24089a83eeec313524be5", async() => {
                BeginContext(3410, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Atividades\Details.cshtml"
                                                       WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3420, 168, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SAGRE.Models.AtividadesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
