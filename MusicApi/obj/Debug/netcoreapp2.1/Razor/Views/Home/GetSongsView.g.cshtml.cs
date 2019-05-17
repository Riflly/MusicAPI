#pragma checksum "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "288727351c8be99fcde48d58af6bd8aba42ba2b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetSongsView), @"mvc.1.0.view", @"/Views/Home/GetSongsView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetSongsView.cshtml", typeof(AspNetCore.Views_Home_GetSongsView))]
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
#line 1 "C:\MusicProject\MusicAPI\MusicApi\Views\_ViewImports.cshtml"
using MusicApi;

#line default
#line hidden
#line 2 "C:\MusicProject\MusicAPI\MusicApi\Views\_ViewImports.cshtml"
using MusicApi.Models;

#line default
#line hidden
#line 3 "C:\MusicProject\MusicAPI\MusicApi\Views\_ViewImports.cshtml"
using MusicApi.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288727351c8be99fcde48d58af6bd8aba42ba2b0", @"/Views/Home/GetSongsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66fd6e91688898acb3c8d2088d5cf09a459845", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetSongsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserPlaylistCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
  
    ViewData["Title"] = "GetSongsView";
    Layout = "~/Views/Shared/_Layout.cshtml";

    string link = String.Empty;
    int id = 0;

#line default
#line hidden
            BeginContext(164, 589, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.19/css/dataTables.foundation.min.css"" />

<style>
    table, th, td {
        border: 0.5px solid white !important;
    }
    /*td {
        height: 40px;
    }*/
    tr {
        background-color: #363636 !important;
        color: white;
    }

    th {
        background-color: #363636 !important;
        color: white;
    }

    #changeColor {
        background-color: #ff0000 !important;
        color: #ff6a00 !important;
    }
</style>

<div class=""row"">
    <div class=""large-5 columns"">
");
            EndContext();
#line 37 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
          
            string imgMusic = string.Format("data:image/gif;base64,{0}", Convert.ToBase64String(Model.Songs.ToList()[0].Album.AlbumPicture.PictureOne));

#line default
#line hidden
            BeginContext(919, 34, true);
            WriteLiteral("            <img class=\"thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 953, "\"", 968, 1);
#line 39 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
WriteAttributeValue("", 959, imgMusic, 959, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(969, 38, true);
            WriteLiteral(" style=\"height:350px; width:590px;\">\r\n");
            EndContext();
            BeginContext(1018, 121, true);
            WriteLiteral("    </div>\r\n    <div class=\"large-7 columns\">\r\n        <table class=\"hover\">\r\n            <thead>\r\n                <tr>\r\n");
            EndContext();
            BeginContext(1363, 317, true);
            WriteLiteral(@"                    <th>Video</th>
                    <th>MP3</th>
                    <th>Title</th>
                    <th>Artist</th>
                    <th>Album</th>
                    <th>Release</th>
                    <th>Add</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 60 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
                 foreach (var item in Model.Songs)
                {

#line default
#line hidden
            BeginContext(1751, 336, true);
            WriteLiteral(@"                    <tr class=""hover1"">

                        <td>
                            <i class=""step fi-video size-72"" style=""width:auto"" data-open=""exampleModal1""></i>
                        </td>
                        <td>
                            <audio controls loop>
                                <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2087, "\"", 2181, 1);
#line 69 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
WriteAttributeValue("", 2093, string.Format("data:audio/mpeg;base64,{0}", Convert.ToBase64String(item.SongData.Data)), 2093, 88, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2182, 102, true);
            WriteLiteral(" />\r\n                            </audio>\r\n                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(2285, 13, false);
#line 72 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
                       Write(item.SongName);

#line default
#line hidden
            EndContext();
            BeginContext(2298, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2334, 28, false);
#line 73 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
                       Write(item.Album.Artist.ArtistName);

#line default
#line hidden
            EndContext();
            BeginContext(2362, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2398, 20, false);
#line 74 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
                       Write(item.Album.AlbumName);

#line default
#line hidden
            EndContext();
            BeginContext(2418, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2454, 22, false);
#line 75 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
                       Write(item.Album.ReleaseYear);

#line default
#line hidden
            EndContext();
            BeginContext(2476, 161, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <i class=\"fi-thumbnails size-72\" data-open=\"exampleModal2\"></i>\r\n                        </td>\r\n");
            EndContext();
            BeginContext(3195, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3336, 27, true);
            WriteLiteral("                    </tr>\r\n");
            EndContext();
#line 91 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
                    link = item.VideoLink;
                    id = item.SongId;
                }

#line default
#line hidden
            BeginContext(3465, 214, true);
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"reveal\" id=\"exampleModal1\" data-reveal>\r\n        <div class=\"responsive-embed widescreen\">\r\n            <iframe width=\"560\" height=\"315\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3679, "\"", 3690, 1);
#line 104 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
WriteAttributeValue("", 3685, link, 3685, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3691, 433, true);
            WriteLiteral(@" frameborder=""0"" allowfullscreen></iframe>
        </div>
        <button class=""close-button"" data-close aria-label=""Close modal"" type=""button"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>

    <div style=""background-color:#1e1e1e; color:white"" class=""reveal"" id=""exampleModal2"" data-reveal>
        <h4>Your Playlist</h4>
        <hr />
        <ul class=""accordion"" data-accordion>
");
            EndContext();
#line 115 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
             foreach (var playitem in Model.UserPlaylists)
            {

#line default
#line hidden
            BeginContext(4199, 149, true);
            WriteLiteral("                <li class=\"accordion-item\" data-accordion-item>\r\n                    <a href=\"#\" class=\"accordion-title\">&nbsp;&nbsp;PlayList Number ");
            EndContext();
            BeginContext(4349, 19, false);
#line 118 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
                                                                               Write(playitem.PlaylistId);

#line default
#line hidden
            EndContext();
            BeginContext(4368, 123, true);
            WriteLiteral("</a>\r\n                    <div class=\"accordion-content\" data-tab-content>\r\n                        <p>Playlist Name:&nbsp;");
            EndContext();
            BeginContext(4492, 21, false);
#line 120 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
                                          Write(playitem.PlaylistName);

#line default
#line hidden
            EndContext();
            BeginContext(4513, 60, true);
            WriteLiteral("</p>\r\n                        <p>Playlist Description:&nbsp;");
            EndContext();
            BeginContext(4574, 21, false);
#line 121 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
                                                 Write(playitem.PlaylistDesc);

#line default
#line hidden
            EndContext();
            BeginContext(4595, 32, true);
            WriteLiteral("</p>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4627, "\"", 4744, 3);
            WriteAttributeValue("", 4637, "location.href=\'", 4637, 15, true);
#line 122 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
WriteAttributeValue("", 4652, Url.Action("AddSongItem","Home", new { playlistID = playitem.PlaylistId, songName = id}), 4652, 91, false);

#line default
#line hidden
            WriteAttributeValue("", 4743, "\'", 4743, 1, true);
            EndWriteAttribute();
            BeginContext(4745, 83, true);
            WriteLiteral(">Add Song To This Playlist</a>\r\n                    </div>\r\n                </li>\r\n");
            EndContext();
#line 125 "C:\MusicProject\MusicAPI\MusicApi\Views\Home\GetSongsView.cshtml"
            }

#line default
#line hidden
            BeginContext(4843, 82, true);
            WriteLiteral("        </ul>\r\n        <div style=\"flex: 0 0 75%\" id=\"color_change\">\r\n            ");
            EndContext();
            BeginContext(4925, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b420027fb2947029a448863fd0cd14a", async() => {
                BeginContext(4982, 19, true);
                WriteLiteral("Create new Playlist");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5005, 201, true);
            WriteLiteral("\r\n        </div>\r\n        <button class=\"close-button\" data-close aria-label=\"Close modal\" type=\"button\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListView> Html { get; private set; }
    }
}
#pragma warning restore 1591