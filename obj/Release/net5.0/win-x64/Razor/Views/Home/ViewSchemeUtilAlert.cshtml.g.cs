#pragma checksum "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32b5c28430d5a8425d0822a742e802282dff058b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NotificationUI.Models.Home.Views_Home_ViewSchemeUtilAlert), @"mvc.1.0.view", @"/Views/Home/ViewSchemeUtilAlert.cshtml")]
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
#line 1 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b5c28430d5a8425d0822a742e802282dff058b", @"/Views/Home/ViewSchemeUtilAlert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3bd323ae7e022e5e5526c40f42108c4760039a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewSchemeUtilAlert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NotificationUI.Models.SchemeUtilAlertModel>>
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
#line 4 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
  
    ViewData["Title"] = "ViewSchemeUtilAlert";
    Layout = "~/Pages/Shared/_Layout.cshtml";
    CultureInfo culture = new CultureInfo("en-US");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b5c28430d5a8425d0822a742e802282dff058b4142", async() => {
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
            WriteLiteral(@" </p>

<div class=""panel panel-default"" style=""margin-top:10px;"">
    <div class=""row"">
        <div class=""col-md-12 col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading""><strong> Scheme Util Alerts</strong>
                    <span id=""feedbackMsg"" style=""display: none""></span><br />
                        <div class=""form-body"">
                            <div class=""table-container scroll"">
                                    <table class=""table table-striped table-bordered tbl_datatable responsive"" id=""tbl_scheme_util_alerts"">
                                        <thead>
                                            <tr>
                                                <th>
                                                    ");
#nullable restore
#line 24 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 27 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 30 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.policy_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 33 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Scheme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 36 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Allocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 39 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Expenditure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 42 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.scheme_start_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 45 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.scheme_end_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 48 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.member_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 51 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.member_util_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 54 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.customer_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 57 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.benefit_type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 60 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.insert_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 63 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.data_source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 66 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                               Write(Html.DisplayNameFor(model => model.country_code));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 72 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                             foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 75 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 78 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 81 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.policy_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 84 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Scheme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 87 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Allocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 90 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Expenditure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 93 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(DateTime.Parse(item.scheme_start_date.ToString(), culture.DateTimeFormat).ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                       ");
#nullable restore
#line 96 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                  Write(DateTime.Parse(item.scheme_end_date.ToString(), culture.DateTimeFormat).ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 99 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.member_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 102 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.member_util_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 105 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.customer_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 108 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.benefit_type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 111 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(DateTime.Parse(item.insert_date.ToString(), culture.DateTimeFormat).ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 114 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.data_source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 117 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.country_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                         ");
#nullable restore
#line 120 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                                    Write(Html.ActionLink("Edit", "EditSchemeUtilAlert", new {  id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \r\n                                                   </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 123 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewSchemeUtilAlert.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                               </div>\r\n                         </div>\r\n                  </div>\r\n               </div>\r\n         </div>\r\n     </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NotificationUI.Models.SchemeUtilAlertModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
