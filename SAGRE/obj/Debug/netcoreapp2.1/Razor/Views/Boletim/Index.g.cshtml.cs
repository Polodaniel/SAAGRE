#pragma checksum "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "642a633e23b7810b0311884672ecde562c4c26c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boletim_Index), @"mvc.1.0.view", @"/Views/Boletim/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Boletim/Index.cshtml", typeof(AspNetCore.Views_Boletim_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"642a633e23b7810b0311884672ecde562c4c26c2", @"/Views/Boletim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7dffafab25414f942597a0eddd6318cd3c0d339", @"/Views/_ViewImports.cshtml")]
    public class Views_Boletim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SAGRE.Models.BoletimModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:2px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Visualizar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:2px; padding-left:4px;padding-right:4px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Excluir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
  
    ViewData["Title"] = "Lançar Boletim";

#line default
#line hidden
            BeginContext(99, 489, true);
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/buttons/1.5.6/css/buttons.bootstrap4.min.css"" />
<link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"" />

<div class=""col mt-2"">

    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""#"">Ínicio</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(589, 17, false);
#line 15 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                                                              Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(606, 208, true);
            WriteLiteral("</li>\r\n        </ol>\r\n    </nav>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"row mb-3\">\r\n                <div class=\"col-sm-12 col-12 col-md-2 col-lg-2\">\r\n                    ");
            EndContext();
            BeginContext(814, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f1c15f8b4b04e2aae398cf2d2790694", async() => {
                BeginContext(861, 14, true);
                WriteLiteral("Adicionar Novo");
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
            BeginContext(879, 349, true);
            WriteLiteral(@"
                </div>
            </div>

            <div class=""table-responsive"">
                <table class=""table table-hover table-sm small "" id=""table_id"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th class=""p-2"" style=""width:55px;"">
                                ");
            EndContext();
            BeginContext(1229, 38, false);
#line 32 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 135, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th class=\"p-2\" style=\"width:15px;\">\r\n                                ");
            EndContext();
            BeginContext(1403, 40, false);
#line 35 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 136, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th class=\"p-2\" style=\"width:120px;\">\r\n                                ");
            EndContext();
            BeginContext(1580, 41, false);
#line 38 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Setor));

#line default
#line hidden
            EndContext();
            BeginContext(1621, 136, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th class=\"p-2\" style=\"width:120px;\">\r\n                                ");
            EndContext();
            BeginContext(1758, 41, false);
#line 41 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Local));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 136, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th class=\"p-2\" style=\"width:120px;\">\r\n                                ");
            EndContext();
            BeginContext(1936, 45, false);
#line 44 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Atividade));

#line default
#line hidden
            EndContext();
            BeginContext(1981, 119, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th class=\"p-2\">\r\n                                    ");
            EndContext();
            BeginContext(2101, 45, false);
#line 47 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2146, 234, true);
            WriteLiteral("\r\n                                </th>\r\n                            <th class=\"p-2\" style=\"width:50px;\"></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody style=\"background-color: white\">\r\n");
            EndContext();
#line 53 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2461, 93, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"align-middle\">\r\n");
            EndContext();
            BeginContext(2634, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2671, 50, false);
#line 58 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CodigoFormatado));

#line default
#line hidden
            EndContext();
            BeginContext(2721, 100, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"align-middle\">\r\n");
            EndContext();
#line 61 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                                       var DataFormatada = Convert.ToDateTime(item.Data); 

#line default
#line hidden
            BeginContext(2914, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2953, 33, false);
#line 63 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                               Write(DataFormatada.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2986, 138, true);
            WriteLiteral("\r\n\r\n                                </td>\r\n                                <td class=\"align-middle\">\r\n                                    ");
            EndContext();
            BeginContext(3125, 40, false);
#line 67 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Setor));

#line default
#line hidden
            EndContext();
            BeginContext(3165, 157, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"align-middle\" style=\"width:200px;\">\r\n                                    ");
            EndContext();
            BeginContext(3323, 40, false);
#line 70 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Local));

#line default
#line hidden
            EndContext();
            BeginContext(3363, 136, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"align-middle\">\r\n                                    ");
            EndContext();
            BeginContext(3500, 44, false);
#line 73 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Atividade));

#line default
#line hidden
            EndContext();
            BeginContext(3544, 140, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"align-middle\">\r\n                                        ");
            EndContext();
            BeginContext(3685, 44, false);
#line 76 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(3729, 139, true);
            WriteLiteral("\r\n                                    </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(3868, 272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bd5ff93d60640068ee4df3c123519db", async() => {
                BeginContext(4030, 106, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-eye\"></i>\r\n                                    ");
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
#line 79 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4437, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(4473, 310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1baac2457d8a4b6d929f587103d4f9a3", async() => {
                BeginContext(4667, 112, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-trash-alt\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4783, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 90 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Boletim\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4886, 116, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5020, 3616, true);
                WriteLiteral(@"

    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.js""></script>
    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.19/js/dataTables.bootstrap4.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.5.6/js/dataTables.buttons.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.5.6/js/buttons.html5.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.5.6/js/buttons.print.min.js""></script>
    <script type=""text/javascript"" src=""https://");
                WriteLiteral(@"cdn.datatables.net/buttons/1.5.6/js/buttons.bootstrap4.min.js""></script>

    <script>
        $(document).ready(function () {
            $('#table_id').DataTable();
        });
    </script>

    <script type=""text/javascript"">
        $(""#table_id"").dataTable({
            pageLength: 5,
            lengthMenu: [[20, 50, 100, -1], [""Pouco"", ""Médio"", ""Muito"", ""Todos""]],
            ""bJQueryUI"": true,
            ""aaSorting"": [[0, ""desc""]],
            ""oLanguage"": {
                ""sProcessing"": ""Processando..."",
                ""sLengthMenu"": ""Mostrar _MENU_ registros"",
                ""sZeroRecords"": ""Não foram encontrados resultados"",
                ""sInfo"": ""Mostrando de _START_ até _END_ de _TOTAL_ registros"",
                ""sInfoEmpty"": ""Mostrando de 0 até 0 de 0 registros"",
                ""sInfoFiltered"": """",
                ""sInfoPostFix"": """",
                ""sSearch"": ""Buscar:"",
                ""sUrl"": """",
                ""oPaginate"": {
                    ""sFirst"": """);
                WriteLiteral(@"Primeiro"",
                    ""sPrevious"": ""Anterior"",
                    ""sNext"": ""Seguinte"",
                    ""sLast"": ""Último""
                }
            },
            responsive: true,
            dom: 'Bfrtip',
            buttons: [
                {
                    extend: 'copy',
                    //text: 'Copiar',
                    text: '<i class=""fa fa-files-o""></i>',
                    titleAttr: 'Copiar',

                },
                {
                    extend: 'excel',
                    //text: 'Excel',
                    text: '<i class=""fa fa-file-excel-o""></i>',
                    titleAttr: 'Converter para Excel',
                    messageTop: 'The information in this table is copyright to Sirius Cybernetics Corp.'
                },
                {
                    extend: 'pdf',
                    //text: 'PDF',
                    text: '<i class=""fa fa-file-pdf-o""></i>',
                    titleAttr: 'Converter para PDF',");
                WriteLiteral(@"
                    //messageTop: 'Grupo de Riscos Cadastrados',
                    title: 'Boletins Cadastrados',
                    orientation: 'A4',
                    pageSize: 'LEGAL',
                    download: 'open',
                    messageBottom: null
                },
                {
                    extend: 'print',
                    text: 'Imprimir',
                    titleAttr: 'Imprimir',
                    messageBottom: null
                }
            ]
        })

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SAGRE.Models.BoletimModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
