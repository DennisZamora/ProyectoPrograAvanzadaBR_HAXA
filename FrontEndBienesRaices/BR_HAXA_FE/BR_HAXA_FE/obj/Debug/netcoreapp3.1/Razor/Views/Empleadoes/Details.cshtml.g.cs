#pragma checksum "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bf5edf23691e478b771544e27571be190ee340f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleadoes_Details), @"mvc.1.0.view", @"/Views/Empleadoes/Details.cshtml")]
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
#line 1 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\_ViewImports.cshtml"
using BR_HAXA_FE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\_ViewImports.cshtml"
using BR_HAXA_FE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf5edf23691e478b771544e27571be190ee340f", @"/Views/Empleadoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03db8b125b3e3af220cc2fe107a3969d746d3a13", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleadoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BR_HAXA_FE.Models.Empleado>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Empleado</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CedulaIdentificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.CedulaIdentificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bf5edf23691e478b771544e27571be190ee340f9370", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\Universidad\Vll\PrograAvanzada\ProyectoPrograAvanzadaBR_HAXA\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE\Views\Empleadoes\Details.cshtml"
                           WriteLiteral(Model.IdEmpleado);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bf5edf23691e478b771544e27571be190ee340f11609", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BR_HAXA_FE.Models.Empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
