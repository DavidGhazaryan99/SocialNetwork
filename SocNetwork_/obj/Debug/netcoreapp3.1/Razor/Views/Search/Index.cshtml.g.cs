#pragma checksum "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e67ba3837c5ee62fc38c7ff5bc57cb05c0e0e44f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#line 1 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\_ViewImports.cshtml"
using SocNetwork_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\_ViewImports.cshtml"
using SocNetwork_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e67ba3837c5ee62fc38c7ff5bc57cb05c0e0e44f", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512d12e7964a2a334247619c605b94d11e7fa50e", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SocNetwork_.ViewModels.SearchPageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("example"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

<style>
    body {
        font-family: Arial;
    }

    * {
        box-sizing: border-box;
    }

    form.example input[type=text] {
        padding: 10px;
        font-size: 17px;
        border: 1px solid grey;
        float: left;
        width: 80%;
        background: #f1f1f1;
    }

    form.example button {
        float: left;
        width: 20%;
        padding: 10px;
        background: #2196F3;
        color: white;
        font-size: 17px;
        border: 1px solid grey;
        border-left: none;
        cursor: pointer;
    }

        form.example button:hover {
            background: #0b7dda;
        }

    form.example::after {
        content: """";
        clear: both;
        display: table;
    }
</style>
<style>
    body {
        margin-top: 20px;
        background: #FAFAFA;
    }
    /*===============");
            WriteLiteral(@"===================================
    Nearby People CSS
    ==================================================*/

    .people-nearby .google-maps {
        background: #f8f8f8;
        border-radius: 4px;
        border: 1px solid #f1f2f2;
        padding: 20px;
        margin-bottom: 20px;
    }

        .people-nearby .google-maps .map {
            height: 300px;
            width: 100%;
            border: none;
        }

    .people-nearby .nearby-user {
        padding: 20px 0;
        border-top: 1px solid #f1f2f2;
        border-bottom: 1px solid #f1f2f2;
        margin-bottom: 20px;
    }

    img.profile-photo-lg {
        height: 80px;
        width: 80px;
        border-radius: 50%;
    }
</style>
<div class=""container text-center"">
    <div class=""row"">
        <div class=""col-sm-3 well"">
            <div class=""well"">
");
#nullable restore
#line 87 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                 if (Model.FriendsRequest != null)
                {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
     foreach (var item in Model.FriendsRequest)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Friend Request</h3>\n                    <div class=\"w3-container w3-center\">\n\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2188, "\"", 2247, 2);
            WriteAttributeValue("", 2194, "data:image/png;base64,", 2194, 22, true);
#nullable restore
#line 94 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
WriteAttributeValue("", 2216, item.friendFrom.ProfilePicture, 2216, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Avatar\" style=\"width:80%\">\n                        <h5><a style=\"color:blue\"");
            BeginWriteAttribute("href", " href=\'", 2330, "\'", 2404, 1);
#nullable restore
#line 95 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
WriteAttributeValue("", 2337, Url.Action("UserViewPage", "Search", new {id=@item.friendFromId }), 2337, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 95 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                                                                                                         Write(item.friendFrom.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 95 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                                                                                                                                    Write(item.friendFrom.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </h5>\n                        <h6>");
#nullable restore
#line 96 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                       Write(item.RequestTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                        <div class=\"w3-section\">\n                            <input type=\"button\" value=\"Accept\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2634, "\"", 2725, 3);
            WriteAttributeValue("", 2644, "location.href=\'", 2644, 15, true);
#nullable restore
#line 98 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
WriteAttributeValue("", 2659, Url.Action("Accept", "Search", new { id = @item.friendFrom.Id }), 2659, 65, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2724, "\'", 2724, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                            <input type=\"button\" value=\"Decline\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2794, "\"", 2886, 3);
            WriteAttributeValue("", 2804, "location.href=\'", 2804, 15, true);
#nullable restore
#line 99 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
WriteAttributeValue("", 2819, Url.Action("Decline", "Search", new { id = @item.friendFrom.Id }), 2819, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2885, "\'", 2885, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                        </div>\n                    </div>");
#nullable restore
#line 101 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                           }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                 if (Model.FriendsRequest.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Friendship requests will be shown here</h3>");
#nullable restore
#line 104 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>

        <div class=""col-sm-7"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""panel panel-default text-left"">
                        <div class=""panel-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e67ba3837c5ee62fc38c7ff5bc57cb05c0e0e44f11811", async() => {
                WriteLiteral("\n                                <input type=\"text\" placeholder=\"Search..\" name=\"UserInputName\" id=\"UserInputName\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e67ba3837c5ee62fc38c7ff5bc57cb05c0e0e44f12224", async() => {
                    WriteLiteral("<i class=\"fa fa-search\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 121 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
             if (Model != null)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
 foreach (var item in Model.Users)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""people-nearby"">
                <div class=""nearby-user"">
                    <div class=""row"">
                        <div class=""col-md-2 col-sm-2"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 4107, "\"", 4156, 2);
            WriteAttributeValue("", 4113, "data:image/png;base64,", 4113, 22, true);
#nullable restore
#line 132 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
WriteAttributeValue(" ", 4135, item.ProfilePicture, 4136, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Red dot\" class=\"profile-photo-lg\">\n                        </div>\n                        <div class=\"col-md-7 col-sm-7\">\n                            <h5> <a style=\"color:blue\"");
            BeginWriteAttribute("href", " href=\'", 4339, "\'", 4403, 1);
#nullable restore
#line 135 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
WriteAttributeValue("", 4346, Url.Action("UserViewPage", "Search", new {id=@item.Id }), 4346, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 135 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                                                                                                   Write(item.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 135 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                                                                                                                   Write(item.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </h5>\n                            <p>Software Engineer</p>\n                        </div>\n                        <div class=\"col-md-3 col-sm-3\">\n");
#nullable restore
#line 139 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                             if (Model.UserFriends.Count != 0)
                            {
                                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                  foreach (var friend in Model.UserFriends)
                                 {
                                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                  if (item.Id == friend.userId)
                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <input type=\"button\" value=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4958, "\"", 5044, 3);
            WriteAttributeValue("", 4968, "location.href=\'", 4968, 15, true);
#nullable restore
#line 145 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
WriteAttributeValue("", 4983, Url.Action("DeleteFriend", "Friend", new { id = @item.Id }), 4983, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5043, "\'", 5043, 1, true);
            EndWriteAttribute();
            WriteLiteral(" /> ");
#nullable restore
#line 145 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                                                                                                                                               }
                                                             else
                                                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <input type=\"button\" value=\"Add Friend\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5252, "\"", 5335, 3);
            WriteAttributeValue("", 5262, "location.href=\'", 5262, 15, true);
#nullable restore
#line 148 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
WriteAttributeValue("", 5277, Url.Action("AddFriend", "Search", new { id = @item.Id }), 5277, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5334, "\'", 5334, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 148 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                                                                                                                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                                                                                                                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                                                                                                                                                                 }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"button\" value=\"Add Friend\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5477, "\"", 5560, 3);
            WriteAttributeValue("", 5487, "location.href=\'", 5487, 15, true);
#nullable restore
#line 151 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
WriteAttributeValue("", 5502, Url.Action("AddFriend", "Search", new { id = @item.Id }), 5502, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5559, "\'", 5559, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 152 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
#nullable restore
#line 161 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Search\Index.cshtml"
  
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SocNetwork_.ViewModels.SearchPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
