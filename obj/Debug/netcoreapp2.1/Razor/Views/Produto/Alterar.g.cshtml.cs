#pragma checksum "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\Produto\Alterar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "158fe839c03660f63d860b37770f0abbd841c7fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Alterar), @"mvc.1.0.view", @"/Views/Produto/Alterar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Alterar.cshtml", typeof(AspNetCore.Views_Produto_Alterar))]
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
#line 1 "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\_ViewImports.cshtml"
using EcommerceEcoville;

#line default
#line hidden
#line 2 "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\_ViewImports.cshtml"
using EcommerceEcoville.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158fe839c03660f63d860b37770f0abbd841c7fe", @"/Views/Produto/Alterar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a76ac689cbeeb2837cd4e3d868017d5e2ceb33c", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Alterar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alterar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\Produto\Alterar.cshtml"
  
    Produto p = ViewBag.Produto;

#line default
#line hidden
            BeginContext(38, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(63, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f80ac97e0c4b4441907d7d8b27e509b2", async() => {
                BeginContext(69, 86, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Alterar</title>\n");
                EndContext();
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
            EndContext();
            BeginContext(162, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(163, 716, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5265dede2e8a42358dd476b757bb72e2", async() => {
                BeginContext(169, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(174, 697, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a484c3bc97944246a0db54833c6a89dc", async() => {
                    BeginContext(215, 30, true);
                    WriteLiteral("\n\n        <input type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 245, "\"", 265, 1);
#line 15 "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 253, p.ProdutoId, 253, 12, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(266, 83, true);
                    WriteLiteral(" name=\"hdnId\" />\n        <label>Id:</label>\n        <input type=\"text\" name=\"txtId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 349, "\"", 369, 1);
#line 17 "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 357, p.ProdutoId, 357, 12, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(370, 93, true);
                    WriteLiteral(" readonly=\"\" /><br />\n\n        <label>Nome:</label>\n        <input type=\"text\" name=\"txtNome\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 463, "\"", 478, 1);
#line 20 "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 471, p.Nome, 471, 7, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(479, 90, true);
                    WriteLiteral(" /><br />\n        <label>Descrição:</label>\n        <input type=\"text\" name=\"txtDescricao\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 569, "\"", 589, 1);
#line 22 "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 577, p.Descricao, 577, 12, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(590, 82, true);
                    WriteLiteral(" /><br />\n        <label>Preço:</label>\n        <input type=\"text\" name=\"txtPreco\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 672, "\"", 688, 1);
#line 24 "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 680, p.Preco, 680, 8, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(689, 92, true);
                    WriteLiteral(" /><br />\n        <label>Quantidade:</label>\n        <input type=\"text\" name=\"txtQuantidade\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 781, "\"", 802, 1);
#line 26 "D:\ADS - UP\08 - DESENVOLVIMENTO DE SISTEMAS MICROSOFT\Projeto\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 789, p.Quantidade, 789, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(803, 61, true);
                    WriteLiteral(" /><br />\n        <input type=\"submit\" value=\"Salvar\" />\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(871, 1, true);
                WriteLiteral("\n");
                EndContext();
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
            EndContext();
            BeginContext(879, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
