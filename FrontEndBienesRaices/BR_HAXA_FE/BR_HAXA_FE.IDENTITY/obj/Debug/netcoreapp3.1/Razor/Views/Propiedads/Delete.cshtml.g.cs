#pragma checksum "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9acbfca8093d9f8f4f263edf2f1fbda71c5cef14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Propiedads_Delete), @"mvc.1.0.view", @"/Views/Propiedads/Delete.cshtml")]
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
#line 1 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\_ViewImports.cshtml"
using BR_HAXA_FE.IDENTITY;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\_ViewImports.cshtml"
using BR_HAXA_FE.IDENTITY.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acbfca8093d9f8f4f263edf2f1fbda71c5cef14", @"/Views/Propiedads/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12233077c790fb72f205db9c9eb0a1ad96516f37", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Propiedads_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BR_HAXA_FE.IDENTITY.Models.Propiedad>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Propiedad</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Distrito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Distrito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pisos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pisos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.M2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.M2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Habitacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Habitacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Baños));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Baños));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Garage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Garage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdCategoriaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdCategoriaNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdEstadoNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdUsuarioNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdUsuarioNavigation.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9acbfca8093d9f8f4f263edf2f1fbda71c5cef1418189", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9acbfca8093d9f8f4f263edf2f1fbda71c5cef1418456", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 107 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdPropiedad);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9acbfca8093d9f8f4f263edf2f1fbda71c5cef1420358", async() => {
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BR_HAXA_FE.IDENTITY.Models.Propiedad> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591