#pragma checksum "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b7ad7f6ac8a9068d015190ff345e50af89447fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Propiedads_Index), @"mvc.1.0.view", @"/Views/Propiedads/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b7ad7f6ac8a9068d015190ff345e50af89447fc", @"/Views/Propiedads/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12233077c790fb72f205db9c9eb0a1ad96516f37", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Propiedads_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BR_HAXA_FE.IDENTITY.Models.Propiedad>>
    #nullable disable
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
#line 3 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b7ad7f6ac8a9068d015190ff345e50af89447fc5070", async() => {
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
#line 16 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Distrito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pisos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.M2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Habitacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ba??os));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Garage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCategoriaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdUsuarioNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 64 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Distrito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pisos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.M2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Habitacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ba??os));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Garage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCategoriaNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEstadoNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdUsuarioNavigation.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b7ad7f6ac8a9068d015190ff345e50af89447fc19463", async() => {
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
#line 112 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
                                       WriteLiteral(item.IdPropiedad);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b7ad7f6ac8a9068d015190ff345e50af89447fc21743", async() => {
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
#line 113 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
                                          WriteLiteral(item.IdPropiedad);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b7ad7f6ac8a9068d015190ff345e50af89447fc24029", async() => {
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
#line 114 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
                                         WriteLiteral(item.IdPropiedad);

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
#line 117 "C:\Users\oscar\Documents\7mo Cuat\3. Programacion Avanzada Web\Proyecto\ProyectoPrograAvanzadaBR_HAXA\FrontEndBienesRaices\BR_HAXA_FE\BR_HAXA_FE.IDENTITY\Views\Propiedads\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BR_HAXA_FE.IDENTITY.Models.Propiedad>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
