#pragma checksum "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\Home\ViewIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c81d404f05a83d1f19ff215484c9bd1e237b7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewIdea), @"mvc.1.0.view", @"/Views/Home/ViewIdea.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewIdea.cshtml", typeof(AspNetCore.Views_Home_ViewIdea))]
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
#line 1 "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\_ViewImports.cshtml"
using bright_ideas;

#line default
#line hidden
#line 2 "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\_ViewImports.cshtml"
using bright_ideas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c81d404f05a83d1f19ff215484c9bd1e237b7c", @"/Views/Home/ViewIdea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818f15e5d0fff1cce9689f0b79e4eaff33d98bfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Idea>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c81d404f05a83d1f19ff215484c9bd1e237b7c3371", async() => {
                BeginContext(41, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(60, 196, true);
                WriteLiteral("    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Bright Ideas</title>\r\n");
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
            BeginContext(263, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(265, 712, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c81d404f05a83d1f19ff215484c9bd1e237b7c4877", async() => {
                BeginContext(271, 10, true);
                WriteLiteral("\r\n    <h3>");
                EndContext();
                BeginContext(282, 16, false);
#line 11 "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\Home\ViewIdea.cshtml"
   Write(Model.User.alias);

#line default
#line hidden
                EndContext();
                BeginContext(298, 23, true);
                WriteLiteral(" says: </h3>\r\n    <div>");
                EndContext();
                BeginContext(322, 13, false);
#line 12 "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\Home\ViewIdea.cshtml"
    Write(Model.TheIdea);

#line default
#line hidden
                EndContext();
                BeginContext(335, 294, true);
                WriteLiteral(@"</div>
    <br>
    <p>People who liked this post: </p>
    <table>
        <tr style=""padding: 5px; border: 1px solid black"">
            <th style=""padding: 5px; border: 1px solid black"">Alias</th>
            <th style=""padding: 5px; border: 1px solid black"">Name</th>
        </tr>
");
                EndContext();
#line 20 "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\Home\ViewIdea.cshtml"
         foreach(var likers in @Model.likeThis)
        {

#line default
#line hidden
                BeginContext(689, 87, true);
                WriteLiteral("            <tr>\r\n                <td style=\"padding: 5px; border: 1px solid black;\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 776, "\"", 807, 2);
                WriteAttributeValue("", 783, "/viewuser/", 783, 10, true);
#line 23 "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\Home\ViewIdea.cshtml"
WriteAttributeValue("", 793, likers.UserId, 793, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(808, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(810, 17, false);
#line 23 "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\Home\ViewIdea.cshtml"
                                                                                                 Write(likers.User.alias);

#line default
#line hidden
                EndContext();
                BeginContext(827, 78, true);
                WriteLiteral("</a></td>\r\n                <td style=\"padding: 5px; border: 1px solid black;\">");
                EndContext();
                BeginContext(906, 16, false);
#line 24 "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\Home\ViewIdea.cshtml"
                                                              Write(likers.User.name);

#line default
#line hidden
                EndContext();
                BeginContext(922, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 26 "C:\Users\ktari\Documents\Coding Dojo\c#\bright_ideas\Views\Home\ViewIdea.cshtml"
        }

#line default
#line hidden
                BeginContext(959, 11, true);
                WriteLiteral("    </ul>\r\n");
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
            BeginContext(977, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Idea> Html { get; private set; }
    }
}
#pragma warning restore 1591