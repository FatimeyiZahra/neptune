#pragma checksum "C:\Users\MacBook AIr\Desktop\neptune\Views\Shared\_RightBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1faa9bba486855b93ac15fc574262775619b5481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RightBar), @"mvc.1.0.view", @"/Views/Shared/_RightBar.cshtml")]
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
#line 1 "C:\Users\MacBook AIr\Desktop\neptune\Views\_ViewImports.cshtml"
using neptune;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MacBook AIr\Desktop\neptune\Views\_ViewImports.cshtml"
using neptune.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1faa9bba486855b93ac15fc574262775619b5481", @"/Views/Shared/_RightBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8ab4dc48968afa0d81f7e1a1334b7595db6b3e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RightBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-bar p-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""right-bar"">
    <div class=""h-100"">
        <div class=""simplebar-wrapper"" style=""margin: 0px;"">
            <div class=""simplebar-mask"">
                <div class=""simplebar-offset"" style=""right: 0px; bottom: 0px;"">
                    <div class=""simplebar-content-wrapper"" style=""height: 100%;"">
                        <div class=""simplebar-content"" style=""padding: 0px;"">
                            <!-- Nav tabs -->
                            <ul class=""nav nav-tabs nav-bordered nav-justified"" role=""tablist"">
                                <li class=""nav-item"">
                                    <a class=""nav-link  active"" data-toggle=""tab"" href=""#chat-tab"" role=""tab"" aria-selected=""true"">
                                        <i class=""las la-sms""></i>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link "" data-toggle=""tab"" href=""#status-ta");
            WriteLiteral(@"b"" role=""tab"" aria-selected=""false"">
                                        <i class=""las la-tasks""></i>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link "" data-toggle=""tab"" href=""#settings-tab"" role=""tab"" aria-selected=""false"">
                                        <i class=""las la-cog""></i>
                                    </a>
                                </li>
                            </ul>
                            <!-- Tab panes starts -->
                            <div class=""tab-content pt-0 rightbar-tab-container"">
                                <div class=""tab-pane active rightbar-tab ps ps--active-y"" id=""chat-tab"" role=""tabpanel"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1faa9bba486855b93ac15fc574262775619b54815522", async() => {
                WriteLiteral(@"
                                        <div class=""position-relative"">
                                            <input type=""text"" class=""form-control search-form-control"" placeholder=""Search"">
                                            <span class=""mdi mdi-magnify""></span>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <h6 class=""right-bar-heading px-3 mt-2 text-uppercase"">Chat Groups</h6>
                                    <div class=""p-2"">
                                        <a href=""javascript: void(0);"" class=""text-reset group-item pl-3 mb-2 d-block"">
                                            <i class=""las la-dot-circle mr-1 text-success""></i>
                                            <span class=""mb-0 mt-1 text-success"">Backend Team</span>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset group-item pl-3 mb-2 d-block"">
                                            <i class=""las la-dot-circle mr-1 text-warning""></i>
                                            <span class=""mb-0 mt-1 text-warning"">Frontend Team</span>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset group-item pl-3 mb-2 d-block"">
    ");
            WriteLiteral(@"                                        <i class=""las la-dot-circle mr-1 text-danger""></i>
                                            <span class=""mb-0 mt-1 text-danger"">Back Office</span>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset group-item pl-3 d-block"">
                                            <i class=""las la-dot-circle mr-1 text-info""></i>
                                            <span class=""mb-0 mt-1 text-info"">Personal</span>
                                        </a>
                                    </div>
                                    <h6 class=""right-bar-heading px-3 mt-2 text-uppercase"">My Favourites <a href=""javascript: void(0);""><i class=""las la-angle-right""></i></a></h6>
                                    <div class=""p-2"">
                                        <a href=""javascript: void(0);"" class=""text-reset"">
                                            <div class=""media p");
            WriteLiteral(@"t-0"">
                                                <div class=""position-relative mr-2"">
                                                    <img src=""/img/profile-1.jpg"" class=""rounded-circle avatar-sm ml-2"" alt=""user-pic"">
                                                    <span class=""user-status online""></span>
                                                </div>
                                                <div class=""media-body overflow-hidden mr-2"">
                                                    <h6 class=""mt-0 mb-1 font-13"">Andrew Mackie</h6>
                                                    <div class=""font-12"">
                                                        <p class=""mb-0 text-truncate"">It will seem like simplified English.</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                             ");
            WriteLiteral(@"           <a href=""javascript: void(0);"" class=""text-reset"">
                                            <div class=""media"">
                                                <div class=""position-relative mr-2"">
                                                    <img src=""/img/profile-2.jpg"" class=""rounded-circle avatar-sm ml-2"" alt=""user-pic"">
                                                    <span class=""user-status online""></span>
                                                </div>
                                                <div class=""media-body overflow-hidden mr-2"">
                                                    <h6 class=""mt-0 mb-1 font-13"">Sophia Garner</h6>
                                                    <div class=""font-12"">
                                                        <p class=""mb-0 text-truncate"">Nice and amazing.</p>
                                                    </div>
                                                </div>
                          ");
            WriteLiteral(@"                  </div>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset"">
                                            <div class=""media"">
                                                <div class=""position-relative mr-2"">
                                                    <img src=""/img/profile-3.jpg"" class=""rounded-circle avatar-sm ml-2"" alt=""user-pic"">
                                                    <span class=""user-status online""></span>
                                                </div>
                                                <div class=""media-body overflow-hidden mr-2"">
                                                    <h6 class=""mt-0 mb-1 font-13"">Jackie Smith</h6>
                                                    <div class=""font-12"">
                                                        <p class=""mb-0 text-truncate"">Send me the .pdf files asap.</p>
                               ");
            WriteLiteral(@"                     </div>
                                                </div>
                                            </div>
                                        </a>
                                    </div>
                                    <h6 class=""right-bar-heading px-3 mt-2 text-uppercase"">Chats <a href=""javascript: void(0);""><i class=""las la-angle-right""></i></a></h6>
                                    <div class=""p-2 pb-4"">
                                        <a href=""javascript: void(0);"" class=""text-reset"">
                                            <div class=""media pt-0"">
                                                <div class=""position-relative mr-2"">
                                                    <img src=""/img/profile-3.jpg"" class=""rounded-circle avatar-sm ml-2"" alt=""user-pic"">
                                                    <span class=""user-status online""></span>
                                                </div>
                             ");
            WriteLiteral(@"                   <div class=""media-body overflow-hidden mr-2"">
                                                    <h6 class=""mt-0 mb-1 font-13"">Owen Hargrieves</h6>
                                                    <div class=""font-12"">
                                                        <p class=""mb-0 text-truncate"">That's really cool</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset"">
                                            <div class=""media"">
                                                <div class=""position-relative mr-2"">
                                                    <img src=""/img/profile-4.jpg"" class=""rounded-circle avatar-sm ml-2"" alt=""user-pic"">
                                                    <span class=""user-statu");
            WriteLiteral(@"s online""></span>
                                                </div>
                                                <div class=""media-body overflow-hidden mr-2"">
                                                    <h6 class=""mt-0 mb-1 font-13"">Riyana Giyan</h6>
                                                    <div class=""font-12"">
                                                        <p class=""mb-0 text-truncate"">When do you send me those files ?</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset"">
                                            <div class=""media"">
                                                <div class=""position-relative mr-2"">
                                                    <img src=""/img/profile-5.jpg"" class=""rounded");
            WriteLiteral(@"-circle avatar-sm ml-2"" alt=""user-pic"">
                                                    <span class=""user-status online""></span>
                                                </div>
                                                <div class=""media-body overflow-hidden mr-2"">
                                                    <h6 class=""mt-0 mb-1 font-13"">Ryan Timberlake</h6>
                                                    <div class=""font-12"">
                                                        <p class=""mb-0 text-truncate"">Invoice has been generated</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset"">
                                            <div class=""media"">
                                                <div class=""position-r");
            WriteLiteral(@"elative mr-2"">
                                                    <img src=""/img/profile-6.jpg"" class=""rounded-circle avatar-sm ml-2"" alt=""user-pic"">
                                                    <span class=""user-status online""></span>
                                                </div>
                                                <div class=""media-body overflow-hidden mr-2"">
                                                    <h6 class=""mt-0 mb-1 font-13"">Julie Roman</h6>
                                                    <div class=""font-12"">
                                                        <p class=""mb-0 text-truncate"">Thank you so much.</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset"">
                                   ");
            WriteLiteral(@"         <div class=""media"">
                                                <div class=""position-relative mr-2"">
                                                    <img src=""/img/profile-7.jpg"" class=""rounded-circle avatar-sm ml-2"" alt=""user-pic"">
                                                    <span class=""user-status online""></span>
                                                </div>
                                                <div class=""media-body overflow-hidden mr-2"">
                                                    <h6 class=""mt-0 mb-1 font-13"">Gareth Sarkar</h6>
                                                    <div class=""font-12"">
                                                        <p class=""mb-0 text-truncate"">Thats was awesome</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                          ");
            WriteLiteral(@"              <a href=""javascript: void(0);"" class=""text-reset"">
                                            <div class=""media"">
                                                <div class=""position-relative mr-2"">
                                                    <img src=""/img/profile-8.jpg"" class=""rounded-circle avatar-sm ml-2"" alt=""user-pic"">
                                                    <span class=""user-status online""></span>
                                                </div>
                                                <div class=""media-body overflow-hidden mr-2"">
                                                    <h6 class=""mt-0 mb-1 font-13"">Kylie Roberts</h6>
                                                    <div class=""font-12"">
                                                        <p class=""mb-0 text-truncate"">Amazing feature.</p>
                                                    </div>
                                                </div>
                        ");
            WriteLiteral(@"                    </div>
                                        </a>
                                        <div class=""text-center pt-4"">
                                            <a href=""javascript:void(0);"" class=""btn btn-sm btn-primary"">
                                                Load more
                                            </a>
                                        </div>
                                    </div>
                                    <div class=""ps__rail-x"" style=""left: 0px; bottom: 0px;""><div class=""ps__thumb-x"" tabindex=""0"" style=""left: 0px; width: 0px;""></div></div><div class=""ps__rail-y"" style=""top: 0px; height: 617px; right: 0px;""><div class=""ps__thumb-y"" tabindex=""0"" style=""top: 0px; height: 300px;""></div></div>
                                </div>
                                <div class=""tab-pane rightbar-tab"" id=""status-tab"" role=""tabpanel"">
                                    <h6 class=""right-bar-heading p-2 px-3 mt-2 text-uppercase"">Order S");
            WriteLiteral(@"tatus </h6>
                                    <div class=""px-2"">
                                        <a href=""javascript: void(0);"" class=""text-reset item-hovered d-block p-2"">
                                            <p class=""text-muted mb-0"">Order Success<span class=""float-right"">75%</span></p>
                                            <div class=""progress mt-2"" style=""height: 4px;"">
                                                <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset item-hovered d-block p-2"">
                                            <p class=""text-muted mb-0"">Order Processing<span class=""float-right"">37%</span></p>
                                            <div class=""progress mt-2"" style=""height: ");
            WriteLiteral(@"4px;"">
                                                <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 37%"" aria-valuenow=""37"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset item-hovered d-block p-2"">
                                            <p class=""text-muted mb-0"">Order Initiated<span class=""float-right"">52%</span></p>
                                            <div class=""progress mt-2"" style=""height: 4px;"">
                                                <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 52%"" aria-valuenow=""52"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div>
                                        </a>
                                    </div>
                                    <h6 class=""font-weight-mediu");
            WriteLiteral(@"m px-3 mb-0 mt-4 text-uppercase"">Payment Status</h6>
                                    <div class=""p-2"">
                                        <a href=""javascript: void(0);"" class=""text-reset item-hovered d-block p-2"">
                                            <p class=""text-muted mb-0"">Payment Failed<span class=""float-right"">12%</span></p>
                                            <div class=""progress mt-2"" style=""height: 4px;"">
                                                <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 12%"" aria-valuenow=""12"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset item-hovered d-block p-2"">
                                            <p class=""text-muted mb-0"">Payment on hold<span class=""float-right"">67%</span></p>
                                            <di");
            WriteLiteral(@"v class=""progress mt-2"" style=""height: 4px;"">
                                                <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 67%"" aria-valuenow=""67"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div>
                                        </a>
                                        <a href=""javascript: void(0);"" class=""text-reset item-hovered d-block p-2"">
                                            <p class=""text-muted mb-0"">Payment Successful<span class=""float-right"">84%</span></p>
                                            <div class=""progress mt-2"" style=""height: 4px;"">
                                                <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 84%"" aria-valuenow=""84"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div>
                                        </a>
                                    </div>
                   ");
            WriteLiteral(@"                 <div class=""text-center pt-2"">
                                        <a href=""javascript: void(0);"" class=""btn btn-primary btn-sm"">Show All</a>
                                    </div>
                                </div>
                                <div class=""tab-pane rightbar-tab"" id=""settings-tab"" role=""tabpanel"">
                                    <h6 class=""right-bar-heading p-2 px-3 mt-2 text-uppercase"">Account Setting </h6>
                                    <div class=""px-2"">
                                        <div class=""switch-container mb-3 pl-2"">
                                            <label class=""switch"">
                                                <input type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 20438, "\"", 20448, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <span class=""slider round primary-switch""></span>
                                            </label>
                                            <p class=""ml-3 text-dark"">Sync Contacts</p>
                                        </div>
                                        <div class=""switch-container mb-3 pl-2"">
                                            <label class=""switch"">
                                                <input type=""checkbox"">
                                                <span class=""slider round primary-switch""></span>
                                            </label>
                                            <p class=""ml-3 text-dark"">Auto Update</p>
                                        </div>
                                        <div class=""switch-container mb-3 pl-2"">
                                            <label class=""switch"">
                                                <input type=""checkbox""");
            WriteLiteral(@">
                                                <span class=""slider round primary-switch""></span>
                                            </label>
                                            <p class=""ml-3 text-dark"">Recieve Notifications</p>
                                        </div>
                                    </div>
                                    <h6 class=""right-bar-heading p-2 px-3 mt-2 text-uppercase"">Mail Setting </h6>
                                    <div class=""px-2"">
                                        <div class=""switch-container mb-3 pl-2"">
                                            <label class=""switch"">
                                                <input type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 22209, "\"", 22219, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <span class=""slider round primary-switch""></span>
                                            </label>
                                            <p class=""ml-3 text-dark"">Mail Auto Responder</p>
                                        </div>
                                        <div class=""switch-container mb-3 pl-2"">
                                            <label class=""switch"">
                                                <input type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 22739, "\"", 22749, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <span class=""slider round primary-switch""></span>
                                            </label>
                                            <p class=""ml-3 text-dark"">Auto Trash Delete</p>
                                        </div>
                                        <div class=""switch-container mb-3 pl-2"">
                                            <label class=""switch"">
                                                <input type=""checkbox"">
                                                <span class=""slider round primary-switch""></span>
                                            </label>
                                            <p class=""ml-3 text-dark"">Custom Signature</p>
                                        </div>
                                    </div>
                                    <h6 class=""right-bar-heading p-2 px-3 mt-2 text-uppercase"">Chat Setting </h6>
                                    <div class=""px-2");
            WriteLiteral("\">\r\n                                        <div class=\"switch-container mb-3 pl-2\">\r\n                                            <label class=\"switch\">\r\n                                                <input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 23998, "\"", 24008, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <span class=""slider round primary-switch""></span>
                                            </label>
                                            <p class=""ml-3 text-dark"">Show Online</p>
                                        </div>
                                        <div class=""switch-container mb-3 pl-2"">
                                            <label class=""switch"">
                                                <input type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 24520, "\"", 24530, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <span class=""slider round primary-switch""></span>
                                            </label>
                                            <p class=""ml-3 text-dark"">Chat Notifications</p>
                                        </div>
                                    </div>
                                    <div class=""px-2 text-center pt-4"">
                                        <a href=""javascript:void(0);"" class=""btn btn-sm btn-danger"">
                                            Set Default
                                        </a>
                                        <button class=""ripple-button ripple-button-primary btn-sm"" type=""button"">
                                            <div class=""ripple-ripple js-ripple"">
                                                <span class=""ripple-ripple__circle""></span>
                                            </div>
                                            Ripple Effect
  ");
            WriteLiteral(@"                                      </button>
                                    </div>
                                </div>
                            </div>
                            <!-- Tab panes ends -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
