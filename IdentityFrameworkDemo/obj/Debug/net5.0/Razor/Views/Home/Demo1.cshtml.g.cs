#pragma checksum "D:\PerkMinds\Dot Net Core With MVC\IdentityFrameworkDemo\Views\Home\Demo1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05af4daafa0cd8e2e0415127d3be6f02b1a88cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Demo1), @"mvc.1.0.view", @"/Views/Home/Demo1.cshtml")]
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
#line 1 "D:\PerkMinds\Dot Net Core With MVC\IdentityFrameworkDemo\Views\_ViewImports.cshtml"
using IdentityFrameworkDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PerkMinds\Dot Net Core With MVC\IdentityFrameworkDemo\Views\_ViewImports.cshtml"
using IdentityFrameworkDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05af4daafa0cd8e2e0415127d3be6f02b1a88cf4", @"/Views/Home/Demo1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"683ebb17354bdbc936d0d9ba7318216aede77fbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Demo1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05af4daafa0cd8e2e0415127d3be6f02b1a88cf43125", async() => {
                WriteLiteral(@"
    <style>
        .myClass {
            color: white;
            background-color: DodgerBlue;
            padding: 20px;
            text-align: center;
            margin: 10px;
        }
    </style>

    <h1>The template Element</h1>

    <p>This example fills the web page with one new div element for each item in an array.</p>
    <p>The HTML code of each div element is inside the template element.</p>

    <p>Click the button below to display the hidden content from the template element.</p>

    <button onclick=""showContent()"">Show hidden content</button>

    <template>
        <div class=""myClass"">I like: </div>
    </template>

    <script>
var myArr = [""Audi"", ""BMW"", ""Ford"", ""Honda"", ""Jaguar"", ""Nissan""];

function showContent() {
  var temp, item, a, i;
  temp = document.getElementsByTagName(""template"")[0];
  //get the div element from the template:
  item = temp.content.querySelector(""div"");
  //for each item in the array:
  for (i = 0; i < myArr.length; i++) ");
                WriteLiteral(@"{
    //Create a new node, based on the template:
    a = document.importNode(item, true);
    //Add data from the array:
    a.textContent += myArr[i];
    //append the new node wherever you like:
    document.body.appendChild(a);
  }
}
    </script>

");
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
            WriteLiteral("\r\n</html>\r\n");
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
