#pragma checksum "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e20d73863eb976135a9fd00b217a84829e431178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e20d73863eb976135a9fd00b217a84829e431178", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512d12e7964a2a334247619c605b94d11e7fa50e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SocNetwork_.ViewModels.PostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Photos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-xs-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<link rel=""stylesheet"" type=""text/css"" href=""//netdna.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
<style>
    .panel-shadow {
        box-shadow: rgba(0, 0, 0, 0.3) 7px 7px 7px;
    }

    .panel-white {
        border: 1px solid #dddddd;
    }

        .panel-white .panel-heading {
            color: #333;
            background-color: #fff;
            border-color: #ddd;
        }

        .panel-white .panel-footer {
            background-color: #fff;
            border-color: #ddd;
        }

    .post .post-heading {
        height: 95px;
        padding: 20px 15px;
    }

        .post .post-heading .avatar {
            width: 60px;
            height: 60px;
            display: block;
            margin-");
            WriteLiteral(@"right: 15px;
        }

        .post .post-heading .meta .title {
            margin-bottom: 0;
        }

            .post .post-heading .meta .title a {
                color: black;
            }

                .post .post-heading .meta .title a:hover {
                    color: #aaaaaa;
                }

        .post .post-heading .meta .time {
            margin-top: 8px;
            margin-left: 100px;
            color: #999;
        }

    .post .post-image .image {
        width: 100%;
        height: auto;
    }

    .post .post-description {
        padding: 15px;
    }

        .post .post-description p {
            font-size: 14px;
        }

        .post .post-description .stats {
            margin-top: 20px;
        }

            .post .post-description .stats .stat-item {
                display: inline-block;
                margin-right: 15px;
            }

                .post .post-description .stats .stat-item .icon {
                    margin-right: 8px;
                }

");
            WriteLiteral(@"    .post .post-footer {
        border-top: 1px solid #ddd;
        padding: 15px;
    }

        .post .post-footer .input-group-addon a {
            color: #454545;
        }

        .post .post-footer .comments-list {
            padding: 0;
            margin-top: 20px;
            list-style-type: none;
        }

            .post .post-footer .comments-list .comment {
                display: block;
                width: 100%;
                margin: 20px 0;
            }

                .post .post-footer .comments-list .comment .avatar {
                    width: 35px;
                    height: 35px;
                }

                .post .post-footer .comments-list .comment .comment-heading {
                    display: block;
                    width: 100%;
                }

                    .post .post-footer .comments-list .comment .comment-heading .user {
                        font-size: 14px;
                        font-weight: bold;
                        display: inline;
 ");
            WriteLiteral(@"                       margin-top: 0;
                        margin-right: 10px;
                    }

                    .post .post-footer .comments-list .comment .comment-heading .time {
                        font-size: 12px;
                        color: #aaa;
                        margin-top: 0;
                        display: inline;
                    }

                .post .post-footer .comments-list .comment .comment-body {
                    margin-left: 50px;
                }

                .post .post-footer .comments-list .comment > .comments-list {
                    margin-left: 50px;
                }
</style>
");
#nullable restore
#line 136 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-left\">\n        <h1 class=\"display-4\">Welcome</h1>\n        <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n    </div>\n");
#nullable restore
#line 142 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container text-center\">\n        <div class=\"row\">\n            <div class=\"col-sm-3 well\">\n                <div class=\"well\">\n                    <p>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20d73863eb976135a9fd00b217a84829e43117812317", async() => {
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
            WriteLiteral("\n                    </p>\n                    <img");
            BeginWriteAttribute("src", " src=\"", 4378, "\"", 4428, 2);
            WriteAttributeValue("", 4384, "data:image/png;base64,", 4384, 22, true);
#nullable restore
#line 153 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4406, Model.profilePicture, 4407, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle\" height=\"65\" width=\"65\" alt=\"Avatar\">\n                    <h5> <a style=\"color:blue\"");
            BeginWriteAttribute("href", " href=\'", 4532, "\'", 4596, 1);
#nullable restore
#line 154 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue("", 4539, Url.Action("UserViewPage", "Search", new {id=Model.id }), 4539, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 154 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                                                                            Write(Model.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 154 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                                                                                             Write(Model.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </h5>\n                </div>\n                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20d73863eb976135a9fd00b217a84829e43117815530", async() => {
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
            WriteLiteral("</p>\n                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20d73863eb976135a9fd00b217a84829e43117816913", async() => {
                WriteLiteral("chat");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n                <p><a href=\"#\">Link</a></p>\n            </div> \n            <div class=\"col-sm-7\">\n                <div class=\"row\">\n                    <div class=\"col-sm-12\">\n\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20d73863eb976135a9fd00b217a84829e43117818491", async() => {
                WriteLiteral(@"

                            <input class=""form-control"" type=""text"" name=""textForPost"" placeholder=""What's on your mind?"">

                            <div class=""form-group"">
                                <input type=""file"" class=""form-control"" name=""postFile"" />
                            </div>

                            <div class=""form-group"">
                                <button type=""submit"" class=""btn btn-primary col-xs-12"">Add</button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                    </div>\n                </div>\n                <div class=\"row\">\n\n");
#nullable restore
#line 181 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                     foreach (var item in Model.post)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""container bootstrap snippets bootdey"">
                            <div class=""col-sm-12"">
                                <div class=""panel panel-white post panel-shadow"">
                                    <div class=""post-heading"">
                                        <div class=""pull-left image"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 6192, "\"", 6257, 2);
            WriteAttributeValue("", 6198, "data:image/png;base64,", 6198, 22, true);
#nullable restore
#line 188 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6220, item.ApplicationUser.ProfilePicture, 6221, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" alt=""user profile image"">
                                        </div>
                                        <div class=""pull-left meta"">
                                            <div class=""title h5"">
                                                <h5> <a style=""color:blue""");
            BeginWriteAttribute("href", " href=\'", 6568, "\'", 6648, 1);
#nullable restore
#line 192 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue("", 6575, Url.Action("UserViewPage", "Search", new {id=@item.ApplicationUser.Id }), 6575, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 192 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                                                                                                                        Write(item.ApplicationUser.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 192 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                                                                                                                                                        Write(item.ApplicationUser.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </h5>\n                                            </div>\n                                            <h6 class=\"text-muted time\">");
#nullable restore
#line 194 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                                   Write(item.dateTimePost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                                        </div>\n                                    </div>\n                                    <div class=\"post-image\">\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 7067, "\"", 7109, 2);
            WriteAttributeValue("", 7073, "data:image/png;base64,", 7073, 22, true);
#nullable restore
#line 198 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7095, item.Picture, 7096, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\" alt=\"image post\">\n                                    </div>\n                                    <div class=\"post-description\">\n                                        <h4>Foto title</h4>\n                                        <p>");
#nullable restore
#line 202 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                      Write(item.textForPicture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        <div class=\"stats\">\n                                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 7492, "\"", 7519, 3);
            WriteAttributeValue("", 7502, "AddLike(", 7502, 8, true);
#nullable restore
#line 204 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue("", 7510, item.id, 7510, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7518, ")", 7518, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default stat-item\">\n                                                <i");
            BeginWriteAttribute("id", " id=\"", 7606, "\"", 7619, 1);
#nullable restore
#line 205 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue("", 7611, item.id, 7611, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-thumbs-up icon\">\n");
#nullable restore
#line 206 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                     if (item.LikedUsers.Count > 0)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 208 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                   Write(item.LikedUsers.Count);

#line default
#line hidden
#nullable disable
#nullable restore
#line 208 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                                              
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </i>
                                            </button>
                                        </div>
                                    </div>
                                    <div id=""PostFooter"" class=""post-footer"">

");
            WriteLiteral(@"                                        <div style=""display:inline-block"">
                                            <input style=""width:525px"" class=""form-control"" id=""inputComment"" placeholder=""Add a comment"" type=""text"">
                                        </div>
                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 8891, "\"", 8921, 3);
            WriteAttributeValue("", 8901, "AddComment(", 8901, 11, true);
#nullable restore
#line 223 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue("", 8912, item.id, 8912, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8920, ")", 8920, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"float:right \" ");
            WriteLiteral(" class=\"btn btn-outline-secondary\" type=\"submit\"><i class=\"fa fa-edit\"></i></button>\n\n                                        <ul");
            BeginWriteAttribute("id", " id=\"", 9100, "\"", 9113, 1);
#nullable restore
#line 225 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue("", 9105, item.id, 9105, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"comments-list\">\n");
#nullable restore
#line 226 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                             foreach (var item2 in item.CommentingUsers)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"comment\">\n                                                    <a class=\"pull-left\"");
            BeginWriteAttribute("href", " href=\'", 9414, "\'", 9492, 1);
#nullable restore
#line 229 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue("", 9421, Url.Action("UserViewPage", "Search", new {id=item2.CommentingUserId }), 9421, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                        <img class=\"avatar\"");
            BeginWriteAttribute("src", " src=\"", 9570, "\"", 9634, 2);
            WriteAttributeValue("", 9576, "data:image/png;base64,", 9576, 22, true);
#nullable restore
#line 230 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
WriteAttributeValue("", 9598, item2.CommentingUser.ProfilePicture, 9598, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""avatar"">
                                                    </a>
                                                    <div class=""comment-body"">
                                                        <div class=""comment-heading"">
                                                            <h4 class=""user"">");
#nullable restore
#line 234 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                                        Write(item2.CommentingUser.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 234 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                                                                        Write(item2.CommentingUser.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                                            <h5 class=\"time\">");
#nullable restore
#line 235 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                                        Write(item2.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                                        </div>\n                                                        <p>");
#nullable restore
#line 237 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                                      Write(item2.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                                    </div>\n                                                </li>\n");
#nullable restore
#line 240 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul>\n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 246 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-sm-2 well"">
                <div class=""thumbnail"">
                    <p>Upcoming Events:</p>
                    <img src=""https://www.voyagesdereve.ch/upload/images/Paris-Tour-Eiffel.jpg"" alt=""Paris"" width=""400"" height=""300"">
                    <p><strong>Paris</strong></p>
                    <p>Fri. 27 November 2015</p>
                    <button class=""btn btn-primary"">Info</button>
                </div>
                <div class=""well"">
                    <p>ADS</p>
                </div>
                <div class=""well"">
                    <p>ADS</p>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 266 "C:\Users\Zemfira\Documents\GitHub\SocialNetwork\SocNetwork_\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20d73863eb976135a9fd00b217a84829e43117833800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SocNetwork_.ViewModels.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
