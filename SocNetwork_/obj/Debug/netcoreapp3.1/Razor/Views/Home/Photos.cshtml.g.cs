#pragma checksum "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\Home\Photos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fdeca93df53fbdf06a0ef8f470c519055ddaddb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Photos), @"mvc.1.0.view", @"/Views/Home/Photos.cshtml")]
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
#line 1 "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\_ViewImports.cshtml"
using SocNetwork_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\_ViewImports.cshtml"
using SocNetwork_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fdeca93df53fbdf06a0ef8f470c519055ddaddb", @"/Views/Home/Photos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da3adcc7f04ed252987a8211bd4af85c79a5ddb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Photos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SocNetwork_.Models.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Photos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<style>
body {font-family: Arial, Helvetica, sans-serif;}

/* The Modal (background) */
.modal {
  display: none; /* Hidden by default */
  position: fixed; /* Stay in place */
  z-index: 1; /* Sit on top */
  padding-top: 100px; /* Location of the box */
  left: 0;
  top: 0;
  width: 100%; /* Full width */
  height: 100%; /* Full height */
  overflow: auto; /* Enable scroll if needed */
  background-color: rgb(0,0,0); /* Fallback color */
  background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
}

/* Modal Content */
.modal-content {
  position: relative;
  background-color: #fefefe;
  margin: auto;
  padding: 0;
  border: 1px solid #888;
  width: 80%;
  box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);
  -webkit-animation-name: animatetop;
  -webkit-animation-duration: 0.4s;
  animation-name: animatetop;
  animation-duration: 0.4s
}
/* The Close Button */
.close {
  color: white;
");
            WriteLiteral(@"  float: right;
  font-size: 28px;
  font-weight: bold;
}

.close:hover,
.close:focus {
  color: #000;
  text-decoration: none;
  cursor: pointer;
}

.modal-header {
  padding: 2px 16px;
  background-color: #5cb85c;
  color: white;
}

.modal-body {padding: 2px 16px;}

.modal-footer {
  padding: 2px 16px;
  background-color: #5cb85c;
  color: white;
}
</style>
<style>

    .img-grid-list {
        margin: -1px;
        list-style-type: none;
    }

    .img-grid-list {
        padding: 0;
    }

        .img-grid-list > li {
            float: left;
            padding: 10px;
        }

            .img-grid-list > li a {
                position: relative;
                overflow: hidden;
                padding-top: 75%;
                display: block;
            }

                .img-grid-list > li a img {
                    position: absolute;
                    right: 0;
                    top: 0;
                    bottom: 0;
                 ");
            WriteLiteral("   left: 0;\r\n                }\r\n</style>\r\n<div class=\"container text-center\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-3 well\">\r\n            <div class=\"well\">\r\n                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fdeca93df53fbdf06a0ef8f470c519055ddaddb7059", async() => {
                WriteLiteral("My Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </p>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2562, "\"", 2612, 2);
            WriteAttributeValue("", 2568, "data:image/png;base64,", 2568, 22, true);
#nullable restore
#line 107 "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\Home\Photos.cshtml"
WriteAttributeValue(" ", 2590, Model.ProfilePicture, 2591, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle\" height=\"65\" width=\"65\" alt=\"Avatar\">\r\n                <p>\r\n                    ");
#nullable restore
#line 109 "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\Home\Photos.cshtml"
               Write(Model.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 109 "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\Home\Photos.cshtml"
                                Write(Model.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
            <div class=""well"">
                <p><a href=""#"">Interests</a></p>
                <p>
                    <span class=""label label-default"">News</span>
                    <span class=""label label-success"">Labels</span>
                    <span class=""label label-info"">Football</span>
                    <span class=""label label-warning"">Gaming</span>
                    <span class=""label label-danger"">Friends</span>
                </p>
            </div>
            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fdeca93df53fbdf06a0ef8f470c519055ddaddb10204", async() => {
                WriteLiteral("Photos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n            <p><a href=\"#\">Link</a></p>\r\n            <p><a href=\"#\">Link</a></p>\r\n        </div>\r\n        <div class=\"col-sm-7\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12\">\r\n                    <div><b>Photos (");
#nullable restore
#line 129 "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\Home\Photos.cshtml"
                               Write(Model.UserPictures.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</b></div>\r\n                    <ul class=\"img-grid-list\">\r\n");
#nullable restore
#line 131 "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\Home\Photos.cshtml"
                         foreach (var item in @Model.UserPictures)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3840, "\"", 3882, 2);
            WriteAttributeValue("", 3846, "data:image/png;base64,", 3846, 22, true);
#nullable restore
#line 134 "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\Home\Photos.cshtml"
WriteAttributeValue(" ", 3868, item.Picture, 3869, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-portrait\" style=\"width:150px;height:150px\">\r\n                            </li>\r\n");
#nullable restore
#line 136 "C:\Users\Arus\Documents\GitHub\SocialNetwork\SocialNetwork\SocNetwork_\Views\Home\Photos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

    <h2>Animated Modal with Header and Footer</h2>

    <!-- Trigger/Open The Modal -->
    <button id=""myBtn"">Open Modal</button>

    <!-- The Modal -->
    <div id=""myModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <span class=""close"">&times;</span>
                <h2>Modal Header</h2>
            </div>
            <div class=""modal-body"">
                <p>Some text in the Modal Body</p>
                <p>Some other text...</p>
            </div>
            <div class=""modal-footer"">
                <h3>Modal Footer</h3>
            </div>
        </div>

    </div>

    <script>
        // Get the modal
        var modal = document.getElementById(""myModal"");

        // Get the button that opens the modal
        var btn = document.getElementById(""myBtn"");

        ");
            WriteLiteral(@"// Get the <span> element that closes the modal
        var span = document.getElementsByClassName(""close"")[0];

        // When the user clicks the button, open the modal
        btn.onclick = function () {
            modal.style.display = ""block"";
        }

        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = ""none"";
        }

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = ""none"";
            }
        }
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SocNetwork_.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
