#pragma checksum "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e0d399b39a372fec2d988b8d70f9323373bf283"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Report), @"mvc.1.0.view", @"/Views/Main/Report.cshtml")]
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
#line 1 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
using HandBook.DataBaseFolder;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e0d399b39a372fec2d988b8d70f9323373bf283", @"/Views/Main/Report.cshtml")]
    public class Views_Main_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HandBook.DataBaseFolder.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-append-version", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e0d399b39a372fec2d988b8d70f9323373bf2833992", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
 if (ViewData["CurrentUser"].ToString() == "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label> Текущий пользователь : Незарегистрированный пользователь</label>\r\n");
#nullable restore
#line 11 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label> Текущий пользователь : ");
#nullable restore
#line 14 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
                               Write(ViewData["CurrentUser"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 15 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<table>\r\n");
#nullable restore
#line 19 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
     foreach (var dep in (List<string>) ViewData["DepartmetList"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 22 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
           Write(dep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Тел номер</th>\r\n            <th>№ кабинета</th>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
         foreach (var o in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
             if(o.Department.Name == dep)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
                   Write(o.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
                                Write(o.Secondname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
                                              Write(o.Patronymic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
                   Write(o.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
                   Write(o.Cabinets.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 39 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
 if (ViewData["CurrentUser"].ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <form");
            BeginWriteAttribute("action", " action=\"", 1065, "\"", 1074, 0);
            EndWriteAttribute();
            WriteLiteral(@" method=""get"">
        <input value=""Добавить"" type=""submit"" formaction=""AddNewRow"" />
        <input value=""Изменить"" type=""submit"" formaction=""EditRow"" />
        <input value=""Удалить"" type=""submit"" formaction=""DeleteRow"" />
        <input value=""Поиск"" type=""submit"" formaction=""SelectEmployee"" />
        <input checked=""checked"" name=""selection"" value=""Department"" type=""radio"" /><span>Действия с отделами</span>
        <input name=""selection"" value=""Employee"" type=""radio"" /><span>Действия с сотрудниками</span>
    </form>
");
#nullable restore
#line 49 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\Report.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HandBook.DataBaseFolder.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
