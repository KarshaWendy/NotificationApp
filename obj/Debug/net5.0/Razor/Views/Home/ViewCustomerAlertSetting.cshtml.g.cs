#pragma checksum "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "185146f620b2daaf3066454a957a99d9ce391aac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NotificationUI.Models.Home.Views_Home_ViewCustomerAlertSetting), @"mvc.1.0.view", @"/Views/Home/ViewCustomerAlertSetting.cshtml")]
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
#line 1 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"185146f620b2daaf3066454a957a99d9ce391aac", @"/Views/Home/ViewCustomerAlertSetting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3bd323ae7e022e5e5526c40f42108c4760039a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewCustomerAlertSetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NotificationUI.Models.CustomerAlertSetting>>
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
#line 4 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
  
    ViewData["Title"] = "ViewCustomerAlertSetting";
    Layout = "~/Pages/Shared/_Layout.cshtml";
    CultureInfo culture = new CultureInfo("en-US");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content container-fluid\">\r\n\r\n<h4>Customer Alert Setting</h4>\r\n\r\n<p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185146f620b2daaf3066454a957a99d9ce391aac4271", async() => {
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
                <div class=""panel-heading""><strong> Customer Alert Setting</strong>
                    <span id=""feedbackMsg"" style=""display: none""></span><br />
                        <div class=""form-body"">
                                <div class=""table-container scroll"">
                                     <table class=""table table-striped table-bordered tbl_datatable responsive"" id=""tbl_cstalert_setting"">
                                        <thead>
                                            <tr>
                                                <th>
                                                    ");
#nullable restore
#line 28 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 31 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.customer_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 34 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.customer_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 37 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.data_source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 40 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.percentage_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 43 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.email_address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 46 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.pol_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 49 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.pool_number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 52 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.country_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 55 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.inpatient_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 58 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.inpatient_weekly_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 61 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.customer_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 64 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.member_perc_util));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 67 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.scheme_util_index));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 70 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.ip_alert_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 73 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.full_member_util));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 76 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.full_member_util_shared));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 79 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.full_member_util_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 82 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.scheme_expiry_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 85 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.scheme_expiry_alert_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 88 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.age_cut_off_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 91 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.age_cut_off_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 94 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.split_report_into_multiple_sheets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 97 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.perc_report_frequency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 100 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.include_cat_desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 103 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayNameFor(model => model.include_util_summary));

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
#line 109 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                         foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 112 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 115 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.customer_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 118 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.customer_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 121 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.data_source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 124 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.percentage_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 127 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.email_address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 130 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.pol_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 133 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.pool_number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 136 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.country_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 139 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.inpatient_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 142 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.inpatient_weekly_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 145 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.customer_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 148 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.member_perc_util));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 151 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.scheme_util_index));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 154 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.ip_alert_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 157 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.full_member_util));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 160 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.full_member_util_shared));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 163 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.full_member_util_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 166 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.scheme_expiry_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 169 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.scheme_expiry_alert_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 172 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.age_cut_off_alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 175 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.age_cut_off_email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 178 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.split_report_into_multiple_sheets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 181 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.perc_report_frequency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 184 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.include_cat_desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 187 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.include_util_summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 190 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                               Write(Html.ActionLink("Edit", "EditCstAlertSetting", new {  id =item.id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 193 "C:\Users\shawn.ngutu.SMART0\OneDrive - Smart Applications International Limited\NotificationsProject\NotificationUI\Views\Home\ViewCustomerAlertSetting.cshtml"
                                           }       

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                        </div>
                 </div>
              </div>
           </div>
     </div>
</div>
</section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NotificationUI.Models.CustomerAlertSetting>> Html { get; private set; }
    }
}
#pragma warning restore 1591
