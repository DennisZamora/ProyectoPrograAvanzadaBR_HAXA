#pragma checksum "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b22578eaba4a199bd8424d002d70760243f6a6ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\_ViewImports.cshtml"
using BR_HAXA_FE.WIZARD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\_ViewImports.cshtml"
using BR_HAXA_FE.WIZARD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22578eaba4a199bd8424d002d70760243f6a6ac", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b81e4be85c374477e6b170aa6c93c40b3ca1610", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BR_HAXA_FE.WIZARD.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22578eaba4a199bd8424d002d70760243f6a6ac4964", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CedulaIdentificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdRolNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CedulaIdentificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdRolNavigation.IdRol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22578eaba4a199bd8424d002d70760243f6a6ac13220", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
                                       WriteLiteral(item.IdUsuario);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22578eaba4a199bd8424d002d70760243f6a6ac15485", async() => {
                WriteLiteral("Details");
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
#nullable restore
#line 71 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
                                          WriteLiteral(item.IdUsuario);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22578eaba4a199bd8424d002d70760243f6a6ac17756", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
                                         WriteLiteral(item.IdUsuario);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.WIZARD\Views\Usuarios\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BR_HAXA_FE.WIZARD.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591