#pragma checksum "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c98387e8d3770305c96a25e112095f46ae40fd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c98387e8d3770305c96a25e112095f46ae40fd3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7dffafab25414f942597a0eddd6318cd3c0d339", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(185, 523, true);
            WriteLiteral(@"
<div class=""col mt-2 m-0"">

    <div class=""row"">
        <div class=""col-sm col-md col-lg col w-100 pr-0"">
            <nav aria-label=""breadcrumb w-100 pr-0"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""#"">Ínicio</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page""></li>
                </ol>
            </nav>
        </div>
    </div>

    <div class=""row"">

        <div class=""col-sm col-md-8 col-lg-8 col-12"">

");
            EndContext();
#line 27 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
              
                var Config = @UserManager.GetUserName(User).ToString();

                Config = Config.Replace("_", " ")
                .Replace("-", " ")
                .Replace(".", " ");

                var Indice = Config.IndexOf("@");

                Config = Config.Substring(0, Indice);

                var Nome = Config;

            

#line default
#line hidden
            BeginContext(1088, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1760, 193, true);
            WriteLiteral("\r\n            <div class=\"row pl-3 mb-4\" style=\"height: 94%\">\r\n                <div class=\"col-sm col col-md col-lg  card pt-3 pl-3 bg-white\">\r\n                    <h2 class=\"\"> <span class=\"\">");
            EndContext();
            BeginContext(1954, 15, false);
#line 53 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                            Write(ViewBag.Horario);

#line default
#line hidden
            EndContext();
            BeginContext(1969, 32, true);
            WriteLiteral(",<span class=\"text-capitalize\"> ");
            EndContext();
            BeginContext(2002, 4, false);
#line 53 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                                            Write(Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2006, 862, true);
            WriteLiteral(@"!</span></span></h2>
                    <hr class=""mt-2"" />
                    <p class=""lead mb-4"">Seja Bem Vindo(a) ao Sistema de Análise e Apoio a Gestão de Risco Ergonômico com base nos apontamentos realizado pelo Avaliador.</p>
                </div>
            </div>
        </div>

        <div class=""col-sm col col-md col-lg w-100 pr-0"">
            <div class=""row"">
                <div class=""col small"">
                    <div class=""card"">
                        <div class=""card-header p-2"">Informação</div>
                        <div class=""card-body p-0"">
                            <div class=""row  p-1 alert alert-light ml-0 mr-0 mb-0 rounded-0 text-dark"">
                                <div class=""col"">Total Setores da Emp.</div>
                                <div class=""col-3 text-right mr-3 font-weight-bold"">");
            EndContext();
            BeginContext(2869, 18, false);
#line 68 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                               Write(ViewBag.TotalSetor);

#line default
#line hidden
            EndContext();
            BeginContext(2887, 308, true);
            WriteLiteral(@"</div>
                            </div>
                            <div class=""row p-1 alert alert-light ml-0 mr-0 mb-0 rounded-0 text-dark"">
                                <div class=""col"">Total Local da Emp.</div>
                                <div class=""col-3 text-right mr-3 font-weight-bold"">");
            EndContext();
            BeginContext(3196, 18, false);
#line 72 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                               Write(ViewBag.TotalLocal);

#line default
#line hidden
            EndContext();
            BeginContext(3214, 312, true);
            WriteLiteral(@"</div>
                            </div>
                            <div class=""row p-1 alert alert-light ml-0 mr-0 mb-0 rounded-0 text-dark"">
                                <div class=""col"">Total Atividade da Emp.</div>
                                <div class=""col-3 text-right mr-3 font-weight-bold"">");
            EndContext();
            BeginContext(3527, 22, false);
#line 76 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                               Write(ViewBag.TotalAtividade);

#line default
#line hidden
            EndContext();
            BeginContext(3549, 309, true);
            WriteLiteral(@"</div>
                            </div>
                            <div class=""row p-1 alert alert-light ml-0 mr-0 rounded-0 text-dark"">
                                <div class=""col"">Total Avaliadores da Emp.</div>
                                <div class=""col-3 text-right mr-3 font-weight-bold"">");
            EndContext();
            BeginContext(3859, 24, false);
#line 80 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                               Write(ViewBag.TotalAvaliadores);

#line default
#line hidden
            EndContext();
            BeginContext(3883, 150, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
            EndContext();
#line 87 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
              
                var Hora = string.Empty;
                var Data = string.Empty;

                if (!Equals(@ViewBag.UltimoBoletim, null))
                {

#line default
#line hidden
            BeginContext(4214, 589, true);
            WriteLiteral(@"                    <div class=""row mt-3 mb-4"">
                        <div class=""col small"">
                            <div class=""card"">
                                <div class=""card-header p-2"">Ultimo Boletim</div>
                                <div class=""card-body p-0"">
                                    <div class=""row p-1 alert alert-info ml-0 mr-0 mb-0 rounded-0 border-bottom-0 text-dark"">
                                        <div class=""col"">Boletins Lançados</div>
                                        <div class=""col text-right mr-3 font-weight-bold"">");
            EndContext();
            BeginContext(4804, 21, false);
#line 100 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                                     Write(ViewBag.TotalBoletins);

#line default
#line hidden
            EndContext();
            BeginContext(4825, 329, true);
            WriteLiteral(@"</div>
                                    </div>
                                    <div class=""row p-1 alert alert-light ml-0 mr-0 mb-0 rounded-0 text-dark"">
                                        <div class=""col"">N° Boletim</div>
                                        <div class=""col text-right mr-3 font-weight-bold"">");
            EndContext();
            BeginContext(5155, 37, false);
#line 104 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                                     Write(ViewBag.UltimoBoletim.CodigoFormatado);

#line default
#line hidden
            EndContext();
            BeginContext(5192, 54, true);
            WriteLiteral("</div>\r\n                                    </div>\r\n\r\n");
            EndContext();
#line 107 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                      
                                        var data = @ViewBag.UltimoBoletim.Data;
                                        Data = Convert.ToDateTime(data).ToShortDateString();
                                        Hora = @ViewBag.UltimoBoletim.HoraInicio + " - " + @ViewBag.UltimoBoletim.HoraTermino;
                                    

#line default
#line hidden
            BeginContext(5628, 287, true);
            WriteLiteral(@"
                                    <div class=""row p-1 alert alert-light ml-0 mr-0 mb-0 rounded-0 text-dark"">
                                        <div class=""col"">Data de Lançamento</div>
                                        <div class=""col text-right mr-3 font-weight-bold"">");
            EndContext();
            BeginContext(5916, 4, false);
#line 115 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                                     Write(Data);

#line default
#line hidden
            EndContext();
            BeginContext(5920, 338, true);
            WriteLiteral(@"</div>
                                    </div>
                                    <div class=""row p-1 alert alert-light ml-0 mr-0 mb-0 rounded-0 text-dark"">
                                        <div class=""col"">Horario Inic./Term.</div>
                                        <div class=""col text-right mr-3 font-weight-bold"">");
            EndContext();
            BeginContext(6259, 4, false);
#line 119 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                                     Write(Hora);

#line default
#line hidden
            EndContext();
            BeginContext(6263, 336, true);
            WriteLiteral(@"</div>
                                    </div>
                                    <div class=""row p-1 alert alert-light ml-0 mr-0 mb-0 rounded-0 text-dark"">
                                        <div class=""col"">Nome do Avaliador</div>
                                        <div class=""col text-right mr-3 font-weight-bold"">");
            EndContext();
            BeginContext(6600, 32, false);
#line 123 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                                                                                     Write(ViewBag.UltimoBoletim.NomeFiscal);

#line default
#line hidden
            EndContext();
            BeginContext(6632, 188, true);
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 129 "C:\Users\danie\Desktop\TCC_SQLite\SAGRE\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(6854, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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