#pragma checksum "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cd0a7dfca8a9197f6f714b4fed756150d90b46f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Local_Delete), @"mvc.1.0.view", @"/Views/Local/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Local/Delete.cshtml", typeof(AspNetCore.Views_Local_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cd0a7dfca8a9197f6f714b4fed756150d90b46f", @"/Views/Local/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7dffafab25414f942597a0eddd6318cd3c0d339", @"/Views/_ViewImports.cshtml")]
    public class Views_Local_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SAGRE.Models.LocalModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Local", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
  
    ViewData["Title"] = "Delete o Local da Empresa";

#line default
#line hidden
            BeginContext(95, 150, true);
            WriteLiteral("\r\n    <div class=\"col mt-2\">\r\n        <nav aria-label=\"breadcrumb\">\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(245, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e78007b5d38c42dd8fd0eb378fcf8268", async() => {
                BeginContext(289, 6, true);
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
            BeginContext(299, 51, true);
            WriteLiteral("</li>\r\n                <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(350, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95baf47c4c3648b3a147ad7bb933a4ab", async() => {
                BeginContext(395, 5, true);
                WriteLiteral("Local");
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
            BeginContext(404, 78, true);
            WriteLiteral("</li>\r\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
            EndContext();
            BeginContext(483, 17, false);
#line 12 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                                                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(500, 254, true);
            WriteLiteral("</li>\r\n            </ol>\r\n        </nav>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-header\">\r\n                        <h5> <i class=\"fas fa-layer-group mr-3\"></i> ");
            EndContext();
            BeginContext(755, 36, false);
#line 20 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                                                Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(791, 335, true);
            WriteLiteral(@"</h5>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <div class=""row"">
                                    <div class=""col-2 font-weight-bold"">
                                        ");
            EndContext();
            BeginContext(1127, 40, false);
#line 27 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 142, true);
            WriteLiteral(":\r\n                                    </div>\r\n                                    <div class=\"col\">\r\n                                        ");
            EndContext();
            BeginContext(1310, 36, false);
#line 30 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 291, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-2 font-weight-bold"">
                                        ");
            EndContext();
            BeginContext(1638, 41, false);
#line 36 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Sigla));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 142, true);
            WriteLiteral(":\r\n                                    </div>\r\n                                    <div class=\"col\">\r\n                                        ");
            EndContext();
            BeginContext(1822, 37, false);
#line 39 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.Sigla));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 291, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-2 font-weight-bold"">
                                        ");
            EndContext();
            BeginContext(2151, 45, false);
#line 45 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2196, 102, true);
            WriteLiteral(":\r\n                                    </div>\r\n                                    <div class=\"col\">\r\n");
            EndContext();
#line 49 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                             if (Model.Descricao == null)
                                            {

#line default
#line hidden
            BeginContext(2464, 127, true);
            WriteLiteral("                                                <label class=\"font-italic font-weight-light\">Sem Descrição Cadastrado</label>\r\n");
            EndContext();
#line 52 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
            BeginContext(2784, 41, false);
#line 55 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                           Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
#line 55 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                                                                          
                                            }

#line default
#line hidden
            BeginContext(2917, 435, true);
            WriteLiteral(@"                                    </div>
                                </div>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-2 font-weight-bold"">
                                        Setor
                                    </div>
                                    <div class=""col"">
                                        ");
            EndContext();
            BeginContext(3353, 42, false);
#line 66 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.Setor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3395, 438, true);
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
            BeginContext(3834, 38, false);
#line 75 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3872, 292, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row mt-3"">
                            <div class=""col text-right"">
                                ");
            EndContext();
            BeginContext(4164, 351, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1913dfd7816446c94ff8db719191604", async() => {
                BeginContext(4190, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(4228, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdf5b08c8870447a83086f521125b275", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 83 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Local\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4264, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(4302, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "435513edb0ea4f0da41940115374542b", async() => {
                    BeginContext(4357, 6, true);
                    WriteLiteral("Voltar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4367, 141, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" value=\"Excluir\" class=\"btn btn-danger btn-sm\" />\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4515, 168, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SAGRE.Models.LocalModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
