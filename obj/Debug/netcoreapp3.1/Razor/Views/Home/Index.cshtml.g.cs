#pragma checksum "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ac00edd3ac6aba6c36cda07a6e22f218401a674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac00edd3ac6aba6c36cda07a6e22f218401a674", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Interesse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("nome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mensagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmCadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Hotsite";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
  <div class=""row"">

    <div class=""col-md-4"">
      <div>
        <h1>Iniciativa Saúde da Cidade</h1>
        <p>
          Texto sobre vida saudável: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae
          legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae
          hendrerit.
        </p>
        <p>
          Texto sobre vida iniciativa: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae
          legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae
          hendrerit.
        </p>
      </div>
    </div>

    <div class=""col-md-6"">
      <img src=""https://cdn.pixabay.com/photo/2019/01/08/18/19/salad-3921790_960_720.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 852, "\"", 858, 0);
            EndWriteAttribute();
            WriteLiteral(@"
        style=""width: 140%; height:70%"">
    </div>
  </div>

  <div class=""row"">
    <div class=""col-md-4"">
      <div id=""frm"" style=""border-width: 1px;
        border-style: solid;
        border-color: rgb(22, 22, 22);
        display:grid;"">
        <h2 style=""margin-left:10px"">Entre em contato!:</h2>
        <p style=""margin-left:10px"">Nos mande uma mensagem e fique por dentro de nossos eventos</p>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ac00edd3ac6aba6c36cda07a6e22f218401a6747651", async() => {
                WriteLiteral("\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ac00edd3ac6aba6c36cda07a6e22f218401a6747925", async() => {
                    WriteLiteral("Nome:");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 42 "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ac00edd3ac6aba6c36cda07a6e22f218401a6749581", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 43 "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ac00edd3ac6aba6c36cda07a6e22f218401a67411282", async() => {
                    WriteLiteral("Email:");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 46 "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ac00edd3ac6aba6c36cda07a6e22f218401a67412941", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 47 "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ac00edd3ac6aba6c36cda07a6e22f218401a67414648", async() => {
                    WriteLiteral("Mensagem (opcional):");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 51 "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mensagem);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ac00edd3ac6aba6c36cda07a6e22f218401a67416324", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 52 "C:\Users\Jessica\Desktop\Codigos\Samuel_M2\Uc06\Ativ1_SamuelArruda\Ativ1_Samuel\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mensagem);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n            <input type=\"submit\" value=\"Enviar\" id=\"BtnSubmit\" style=\"margin-left: 70%;margin-bottom:20px;\">\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
    </div>

    <div class=""col-md-8"">
      <div class=""row"">



        <div class=""col-md-4"" style=""width: 120px;height:100px"">
          <div class=""col-md-4"" style=""margin-left:10%"">
            <div class=""card"" style=""width: 120px;height:100px"">
              <img");
            BeginWriteAttribute("alt", " alt=\"", 2195, "\"", 2201, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""https://cdn.pixabay.com/photo/2016/07/31/20/54/calendar-1559935_960_720.png""
                style=""width: 120px; height:100px"">

            </div>
            <div class=""card-body"">
              <a href=""#"" data-toggle=""modal"" data-target=""#Agenda"" class=""text-center"">Agenda de Eventos</a>
            </div>
          </div>
        </div>

        <div class=""col-md-4"" style=""width: 120px;height:100px"">
          <div class=""col-md-4"" style=""margin-left:10%"">
            <div class=""card"" style=""width: 120px;height:100px"">
              <img");
            BeginWriteAttribute("alt", " alt=\"", 2773, "\"", 2779, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""https://cdn.pixabay.com/photo/2020/08/03/09/43/medical-5459654_960_720.png""
                style=""width: 120px; height:100px"">

            </div>
            <div class=""card-body"">
              <a href=""#"" data-toggle=""modal"" data-target=""#Dicas"" class=""text-center"">Dicas de vida saudável</a>
            </div>
          </div>
        </div>


        <div class=""col-md-4"" style=""width: 120px;height:100px"">
          <div class=""col-md-4"" style=""margin-left:10%"">
            <div class=""card"" style=""width: 120px;height:100px"">
              <img");
            BeginWriteAttribute("alt", " alt=\"", 3356, "\"", 3362, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""https://cdn.pixabay.com/photo/2021/09/16/18/47/money-6630755_960_720.png""
                style=""width: 120px; height:100px"">

            </div>
            <div class=""card-body"">
              <a href=""#"" data-toggle=""modal"" data-target=""#Apoiadores"" class=""text-center"">Apoiadores</a>
            </div>
          </div>
        </div>

      </div>
    </div>

  </div>
</div>

<div class=""modal fade show"" id=""Agenda"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
  style=""padding-right: 17px;"" aria-modal=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"" style=""margin-left:195px;"">Agenda</h5>

      </div>
      <div class=""modal-body"">
        <div style=""margin-left:110px;text-align:center; width:50%;"">
          <p>10/10/10 10h10min - Evento 1</p>

          <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae </");
            WriteLiteral(@"p>
        </div>
        <br>
        <div style=""margin-left:110px;text-align:center; width:50%;"">
          <p>10/10/10 10h10min - Evento 1</p>

          <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae </p>
        </div>
        <div style=""margin-left:110px;text-align:center; width:50%;"">
          <p>10/10/10 10h10min - Evento 1</p>

          <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae </p>
        </div>

      </div>

    </div>
  </div>
</div>

<div class=""modal fade"" id=""Dicas"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
  style=""display: none;"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 id=""exampleModalLabel"" class=""modal-title"" style=""margin-left:125px;"">Dicas de vida saúdavel</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">

        </button>
      </div");
            WriteLiteral(@">
      <div class=""modal-body"">
        <div style=""margin-left:110px;text-align:left; width:50%;"">


          <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae lengendos ar vix ad puten delectus
            delicata usu. Vidit dissentiet eos.
          </p>
          <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae lengendos ar vix ad puten delectus
            delicata usu. Vidit dissentiet eos.
          </p>
          <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae lengendos ar vix ad puten delectus
            delicata usu. Vidit dissentiet eos.
          </p>
        </div>
        <br>


      </div>

    </div>
  </div>
</div>


<div class=""modal fade"" id=""Apoiadores"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
  style=""display: none;"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 i");
            WriteLiteral(@"d=""exampleModalLabel"" class=""modal-title"" style=""margin-left:195px;"">Apoiadores</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">

        </button>
      </div>

      <div class=""row"" style=""position: static;float:left;margin-bottom:30px"">
        <img");
            BeginWriteAttribute("alt", " alt=\"", 6736, "\"", 6742, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid col-md-4""
          src=""https://cdn.pixabay.com/photo/2021/07/16/20/49/lion-6471831_960_720.png"">

        <div class=""col-md-6"" style=""float: right;"">
          <h5>Lions Corp®</h5>
          <h7>Empresa multinacional de comercio de produtos eletrônicos de consumo, software de computador e
            computadores pessoais.</h7>
        </div>

      </div>

      <div class=""row"" style=""position: static;float:left;margin-bottom:30px"">
        <img");
            BeginWriteAttribute("alt", " alt=\"", 7227, "\"", 7233, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid col-md-4""
          src=""https://cdn.pixabay.com/photo/2017/06/02/19/21/moose-2367114_960_720.png"">

        <div class=""col-md-6"" style=""float: right;"">
          <h5>Moose.com®</h5>
          <h7>Empresa expecializada em artigos esportivos e dicas de saude</h7>
        </div>

      </div>

      <div class=""row"" style=""position: static;float:left;margin-bottom:30px"">
        <img");
            BeginWriteAttribute("alt", " alt=\"", 7648, "\"", 7654, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid col-md-4""
          src=""https://cdn.pixabay.com/photo/2013/07/13/10/52/four-leaf-clover-157968_960_720.png"">

        <div class=""col-md-6"" style=""float: right;"">
          <h5>4-Leaf Bank®</h5>
          <h7>Empresa expecializada em stream e marketing digital</h7>
        </div>

      </div>


      <div class=""row"" style=""position: static;float:left;margin-bottom:30px"">
        <img");
            BeginWriteAttribute("alt", " alt=\"", 8074, "\"", 8080, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid col-md-4""
          src=""https://cdn.pixabay.com/photo/2020/01/21/17/54/bear-4783522_960_720.png"">

        <div class=""col-md-6"" style=""float: right;"">
          <h5>BearDream</h5>
          <h7>Eempresa expecializada em acessoria e investimentos online</h7>
        </div>

      </div><br>
    </div>

  </div>
</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Interesse> Html { get; private set; }
    }
}
#pragma warning restore 1591
