#pragma checksum "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\RelatorioCompleto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89404ae645f04436ca1427df48bd5479928d5c77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RelatorioCompleto_Index), @"mvc.1.0.view", @"/Views/RelatorioCompleto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RelatorioCompleto/Index.cshtml", typeof(AspNetCore.Views_RelatorioCompleto_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89404ae645f04436ca1427df48bd5479928d5c77", @"/Views/RelatorioCompleto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7dffafab25414f942597a0eddd6318cd3c0d339", @"/Views/_ViewImports.cshtml")]
    public class Views_RelatorioCompleto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-sm custom-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SetorSelecionado"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("javascript: BuscaLocal(this.value);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("LocalSelecionado"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AtividadeSelecionado"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\RelatorioCompleto\Index.cshtml"
  
    ViewData["Title"] = "Relatório Completo";

#line default
#line hidden
            BeginContext(54, 136, true);
            WriteLiteral("\r\n<div class=\"col mt-2\">\r\n\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(190, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ac9e72244a4c28bca1edcd9a65d7c7", async() => {
                BeginContext(234, 6, true);
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
            BeginContext(244, 74, true);
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item active\" aria-current=\"page\">");
            EndContext();
            BeginContext(319, 17, false);
#line 10 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\RelatorioCompleto\Index.cshtml"
                                                              Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(336, 2936, true);
            WriteLiteral(@"</li>
        </ol>
    </nav>

    <div class=""row"">
        <div class=""col-sm -12 col-lg-12 col-md col-lg"">
            <div class=""bg-white mb-2"" style=""background-color: white"">
                <div class="" border bg-dark text-light p-2 mb-0 align-middle"" role=""alert"" data-toggle=""collapse"" href=""#CaixaBusca"" aria-expanded=""false"" aria-controls=""CaixaBusca"">
                    <div class=""row"">
                        <div class=""col-sm col col-md col-lg"">
                            <i class=""fas fa-search mr-3 ml-3 small align-middle""></i> Opções de Busca por Avaliador
                        </div>
                    </div>
                </div>
                <div class=""collapse show"" id=""CaixaBusca"">
                    <div class=""border border-top-0 mt-0 mb-0 p-2"">
                        <div class=""row mt-0 mb-0 small font-weight-bold "">
                            <div class=""col-sm-12 col-12 col-md col-lg"">
                                <label class=""control-label mb-0");
            WriteLiteral(@" small font-weight-bold"">Código</label>
                                <input type=""number"" class=""form-control form-control form-control-sm"" min=""0"" id=""txtCodigo"" />
                            </div>
                            <div class=""col-sm-12 col-12 col-md col-lg"">
                                <div class=""form-group"">
                                    <label class=""control-label mb-0 small font-weight-bold"">Data Ínicial</label>
                                    <input type=""date"" class=""form-control form-control-sm"" id=""CampoDataInicial"" />
                                </div>
                            </div>
                            <div class=""col-sm-12 col-12 col-md col-lg"">
                                <div class=""form-group"">
                                    <label class=""control-label mb-0 small font-weight-bold"">Data Final</label>
                                    <input type=""date"" class=""form-control form-control-sm"" id=""CampoDataFinal"" />
               ");
            WriteLiteral(@"                 </div>
                            </div>
                            <div class=""col-sm-12 col-12 col-md-5 col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""control-label mb-0 small font-weight-bold"">Nome do Avaliador</label>
                                    <input class=""form-control form-control-sm"" value="" "" id=""NomeAvaliador"" />
                                </div>
                            </div>
                        </div>

                        <div class=""row mt-0 mb-0 p-0 small"">
                            <div class=""col-sm-12 col-12 col-md-6 col-lg-6 mt-0"">
                                <div class=""form-group"">
                                    <label class=""control-label mb-0 small font-weight-bold"">Setor</label>
                                    ");
            EndContext();
            BeginContext(3272, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6f38b22e7a441c289e4a6c3d17d81c7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 55 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\RelatorioCompleto\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Setor;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3436, 354, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-sm-12 col-12 col-md col-lg"">
                                <div class=""form-group"">
                                    <label class=""control-label mb-0 small font-weight-bold"">Local</label>
                                    ");
            EndContext();
            BeginContext(3790, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eded50fcd2444f7aa1615f9ecf644ac", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 61 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\RelatorioCompleto\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Local;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3907, 358, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-sm-12 col-12 col-md col-lg"">
                                <div class=""form-group"">
                                    <label class=""control-label mb-0 small font-weight-bold"">Atividade</label>
                                    ");
            EndContext();
            BeginContext(4265, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c61fde8ae14dff993aa06a1bb170a0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 67 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\RelatorioCompleto\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Atividade;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4390, 894, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col text-right"">
                                <button class=""btn btn-success btn-sm"" onclick=""RealizarBusca()"">Buscar</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""border bg-white mt-2 mb-2 text-center font-italic"" id=""MsgVazio"">
                <h6 class=""pl-2 pt-2 pb-1 text-muted font-weight-bold small"">Sem Dados de Relatório ! Realize uma nova Busca.</h6>
            </div>

            <div id=""AreaBaseResultadoBusca"">
                <div class=""resultado"" id=""AreaResultadoBusca""></div>
            </div>

        </div>
    </div>

</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5302, 2507, true);
                WriteLiteral(@"

    <script>

        function RealizarBusca() {

            var Filtros = {
                codigo: $('#txtCodigo').val(),
                datainicial: $('#CampoDataInicial').val(),
                datafinal: $('#CampoDataFinal').val(),
                nomeavaliador: $('#NomeAvaliador').val(),
                setor: $('#SetorSelecionado').val(),
                local: $('#LocalSelecionado').val(),
                nomelocal: $('#LocalSelecionado option:Selected').text(),
                atividade: $('#AtividadeSelecionado').val(),
            };

            $.ajax({
                type: ""GET"",
                url: ""/RelatorioCompleto/BuscarBoletins"",
                data: Filtros,
                dataType: ""html"",
                success: function (response) {

                    var MsgVazio = $('#MsgVazio');
                    var AreaBaseResultadoBusca = $('#AreaBaseResultadoBusca');
                    var AreaResultadoBusca = $('#AreaResultadoBusca');

                 ");
                WriteLiteral(@"   var html = response.replace(""\"""", """");
                    html = html.replace(""\"""", """");

                    MsgVazio.remove();

                    AreaResultadoBusca.remove();

                    AreaBaseResultadoBusca.append(""<div class=\""resultado\"" id=\""AreaResultadoBusca\""></div>"");

                    var AreaResultadoBusca = $('#AreaResultadoBusca');
                    AreaResultadoBusca.append(html);
                }
            });
        }

        function BuscaLocal(CodSetor) {
            $.ajax({
                type: ""GET"",
                url: ""/RelatorioCompleto/BuscaLocal"",
                data: { CodSetor },
                dataType: ""html"",
                success: function (response) {

                    locais = JSON.parse(response);

                    // Limpo o Combobox
                    $('#LocalSelecionado').empty();

                    $(""#LocalSelecionado"").append($('<option>', {
                        value: 0,
                     ");
                WriteLiteral(@"   text: """"
                    }));

                    // Adiciona as demais linhas (dinâmico).
                    $.each(locais, function (id, locais) {
                        $(""#LocalSelecionado"").append($('<option>', {
                            value: locais.iD_Local,
                            text: locais.nome
                        }));
                    });

                }
            });

        }

    </script>

");
                EndContext();
            }
            );
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
