#pragma checksum "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd3ea07867d2017749beddcf18fda2cecf5d21f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NotificationUI.Models.Home.Views_Home_ViewStatementConfig), @"mvc.1.0.view", @"/Views/Home/ViewStatementConfig.cshtml")]
namespace NotificationUI.Models.Home
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
#line 1 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\_ViewImports.cshtml"
using NotificationUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dd3ea07867d2017749beddcf18fda2cecf5d21f", @"/Views/Home/ViewStatementConfig.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3bd323ae7e022e5e5526c40f42108c4760039a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewStatementConfig : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NotificationUI.Models.IndividualStatementConfig>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
  
    ViewData["Title"] = "ViewStatementConfig";
    Layout = "~/Pages/Shared/_Layout.cshtml";
    CultureInfo culture = new CultureInfo("en-US");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd3ea07867d2017749beddcf18fda2cecf5d21f4147", async() => {
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
            WriteLiteral(@"</p>
<div class=""panel panel-default"" style=""margin-top:10px;"">
    <div class=""row"">
        <div class=""col-md-12 col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading""><strong> Individual Statement Configs</strong>
                    <span id=""feedbackMsg"" style=""display: none""></span><br />
                        <div class=""form-body"">
                            <div class=""table-container scroll"">
                                <table class=""table table-striped table-bordered tbl_datatable responsive nowrap"" id=""tbl_statement_config"">
                                      <thead>
                                        <tr>
                                            <th>
                                                ");
#nullable restore
#line 23 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 26 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.customer_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 29 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.data_source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 32 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.country_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 35 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.customer_logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 38 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.customer_logo2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 41 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.pol_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 44 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.main_benefit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 47 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.family_benefit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 50 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.insert_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 53 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.policy_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 56 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.customer_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 59 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.send_frequeny));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 62 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.last_send_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 65 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.password_type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 68 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.split_password_from_statement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 71 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Include_image_banner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 74 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Image_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 77 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.report_template_file));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 80 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.email_blast_enabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 83 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.zero_allocation_excempt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 86 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                           Write(Html.DisplayNameFor(model => model.mail_domain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th></th>\r\n                                        </tr>\r\n                                      </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 92 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                         foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 95 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 98 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.customer_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 101 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.data_source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 104 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.country_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 107 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.customer_logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 110 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.customer_logo2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 113 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.pol_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 116 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.main_benefit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 119 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.family_benefit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 122 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(DateTime.Parse(item.insert_date.ToString(), culture.DateTimeFormat).ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 125 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.policy_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 128 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.customer_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 131 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.send_frequeny));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 134 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(DateTime.Parse(item.last_send_date.ToString(), culture.DateTimeFormat).ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 137 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.password_type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 140 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.split_password_from_statement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 143 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Include_image_banner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 146 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Image_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 149 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.report_template_file));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 152 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.email_blast_enabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 155 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.zero_allocation_excempt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 158 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.mail_domain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 161 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                               Write(Html.ActionLink("Edit", "EditStatementConfig", new {  id=item.id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        \r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 164 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewStatementConfig.cshtml"
                                        }       

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                 </table>\r\n                              </div>\r\n                         </div>\r\n                   </div>\r\n              </div>\r\n         </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NotificationUI.Models.IndividualStatementConfig>> Html { get; private set; }
    }
}
#pragma warning restore 1591