#pragma checksum "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\DeleteEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a5e8410187a72a96141581f775c1413d36187fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_DeleteEmployee), @"mvc.1.0.view", @"/Views/Main/DeleteEmployee.cshtml")]
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
#line 1 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\DeleteEmployee.cshtml"
using HandBook.DataBaseFolder;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a5e8410187a72a96141581f775c1413d36187fe", @"/Views/Main/DeleteEmployee.cshtml")]
    public class Views_Main_DeleteEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandBook.Views.Main.AddEmployeeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <form method=\"post\">\r\n        <label>Выберите сотрудника</label><br/>\r\n        <select name=\"employe\">\r\n");
#nullable restore
#line 7 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\DeleteEmployee.cshtml"
         foreach (var dep in (List<string>) ViewData["EmployeeList"])
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 291, "\"", 303, 1);
#nullable restore
#line 9 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\DeleteEmployee.cshtml"
WriteAttributeValue("", 299, dep, 299, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\DeleteEmployee.cshtml"
                            Write(dep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 10 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\DeleteEmployee.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select><br />\r\n        <label>");
#nullable restore
#line 12 "C:\Users\okoro\source\repos\HandBook\HandBook\Views\Main\DeleteEmployee.cshtml"
          Write(ViewData["Error Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n        <input type=\"submit\" value=\"Удалить\" />\r\n        <br />\r\n    </form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandBook.Views.Main.AddEmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
