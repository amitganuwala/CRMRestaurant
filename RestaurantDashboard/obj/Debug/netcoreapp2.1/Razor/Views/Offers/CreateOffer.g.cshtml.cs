#pragma checksum "D:\CRM\DashboardRestorant\RestaurantDashboard\Views\Offers\CreateOffer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30e16ec5c493bfdfad4db12dd199386700055b80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offers_CreateOffer), @"mvc.1.0.view", @"/Views/Offers/CreateOffer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Offers/CreateOffer.cshtml", typeof(AspNetCore.Views_Offers_CreateOffer))]
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
#line 1 "D:\CRM\DashboardRestorant\RestaurantDashboard\Views\_ViewImports.cshtml"
using RestaurantDashboard;

#line default
#line hidden
#line 2 "D:\CRM\DashboardRestorant\RestaurantDashboard\Views\_ViewImports.cshtml"
using RestaurantDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e16ec5c493bfdfad4db12dd199386700055b80", @"/Views/Offers/CreateOffer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a30fb93c464b6d2d2d8a64057aadea470f866e04", @"/Views/_ViewImports.cshtml")]
    public class Views_Offers_CreateOffer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Dashboard/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Offers/ListOffer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger alert-error"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Inactive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOffer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\CRM\DashboardRestorant\RestaurantDashboard\Views\Offers\CreateOffer.cshtml"
  
    ViewData["Title"] = "CreateOffer";
    Layout = "~/Views/Shared/_Main_Layout.cshtml";

#line default
#line hidden
            BeginContext(101, 143, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-12\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                ");
            EndContext();
            BeginContext(244, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9e2194839c49e8bdfdeff720828132", async() => {
                BeginContext(272, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(285, 68, true);
            WriteLiteral("\r\n            </li>\r\n            <li class=\"breadcrumb-item active\">");
            EndContext();
            BeginContext(353, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "262fb8471b584252af02c93000c6953c", async() => {
                BeginContext(382, 10, true);
                WriteLiteral("Offer List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(396, 111, true);
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item active\">Add Offer</li>\r\n\r\n        </ol>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(507, 7581, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60d2ea2e91547d9a2e89e1b74b67dd6", async() => {
                BeginContext(538, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 24 "D:\CRM\DashboardRestorant\RestaurantDashboard\Views\Offers\CreateOffer.cshtml"
     if (ViewData.ModelState.Any(x => x.Value.Errors.Any()))
    {
        // Bootstrap 2 = "alert-error", Bootstrap 3 and 4 = "alert-danger"

#line default
#line hidden
                BeginContext(687, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(695, 152, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdd78e7e6a8408db58e1cfe31d74250", async() => {
                    BeginContext(768, 73, true);
                    WriteLiteral("\r\n            <a class=\"close\" data-dismiss=\"alert\">&times;</a>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 27 "D:\CRM\DashboardRestorant\RestaurantDashboard\Views\Offers\CreateOffer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(847, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "D:\CRM\DashboardRestorant\RestaurantDashboard\Views\Offers\CreateOffer.cshtml"
    }

#line default
#line hidden
                BeginContext(856, 4559, true);
                WriteLiteral(@"

    <div class=""container-fluid my-3"">
        <div class=""col-md-12"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""row div_right"">
                        <button type=""submit"" name=""save"" class=""btn btn-primary btn-sm pull-right"">
                            <i class=""icon-save mr-2""></i>
                            Save
                        </button>
                        <button type=""submit"" name=""save-continue"" class=""btn btn-primary btn-sm pull-right ml-2 margin-right5"">
                            <i class=""icon-save mr-2""></i>
                            Save And Countinue
                        </button>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row mt-1"">
            <div class=""col-md-12"">
                <div class=""card bg-white mb-3 font-weight-bold"">
                    <div class=""card-header text-primary"">Add Offer</div>
                    <");
                WriteLiteral(@"div class=""card-body"">
                        <div class=""card-title""></div>

                        <!--Add Product Offer Details -->

                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label>Offer Name</label>
                                            <input class=""form-control s-12"" type=""text"" id=""OfferName"" name=""OfferName"" value="""">
                                        </div>

                                        <div class=""form-group"">
                                            <label>Offer Cost</label>
                                            <input class=""form-control s-12"" type=""text"" id=""OfferCost"" name=""OfferCost"" value="""">

                                        </div>
                                    ");
                WriteLiteral(@"    <div class=""form-group"">
                                            <label>Offer Start Date</label>
                                            <div class=""input-group"">
                                                <input type=""text"" name=""OfferStartDate"" id=""OfferStartDate"" class=""date-time-picker form-control s-12""
                                                       data-options='{""timepicker"":false, ""format"":""d M Y""}' autocomplete=""off"">
                                            </div>

                                        </div>
                                        <div class=""form-group"">
                                            <label>Offer Valid Date</label>
                                            <div class=""input-group"">
                                                <input type=""text"" name=""OfferValidDate"" id=""OfferValidDate"" class=""date-time-picker form-control s-12""
                                                       data-options='{""timepicker"":false, ""for");
                WriteLiteral(@"mat"":""d M Y""}' autocomplete=""off"">
                                            </div>

                                        </div>

                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label>Serve No Of People</label>
                                            <input name=""ServeNoOfPeople"" id=""ServeNoOfPeople"" class=""form-control s-12"">
                                        </div>

                                        <div class=""form-group"">
                                            <label>Offer Image</label>
                                            <input type=""file"" name=""OfferImage"" id=""OfferImage"" class=""form-control s-12"" />
                                        </div>
                                        <div class=""form-group"">
                                            <label>Offer Condition</label>
       ");
                WriteLiteral(@"                                     <textarea name=""OfferCondition"" id=""OfferCondition"" class=""form-control s-12""></textarea>
                                        </div>
                                        <div class=""form-group"">
                                            <label>Status</label>
                                            <select class=""form-control s-12"" name=""Status"" id=""Status"">
                                                ");
                EndContext();
                BeginContext(5415, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdca7bd48b3a4d22a684b51d2b9eb503", async() => {
                    BeginContext(5438, 6, true);
                    WriteLiteral("Active");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5453, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(5503, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83ca0df7b164d7aab5ad8e873ad0948", async() => {
                    BeginContext(5528, 8, true);
                    WriteLiteral("Inactive");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5545, 2536, true);
                WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>
                                </div>
                                <br />
                                <!--Offer List Table -->
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""card no-b"">
                                            <div class=""card-body"">
                                                <div class=""card-title "">Offer Product Detail List</div>
                                                <div class=""collapse show"" id=""OfferDetails"">
                                                    <div class=""card-body p-0"">
                                                        <table id=""tblListFieldData"" class=""table table-light table-bordered table-hover "">
                                                            <thead c");
                WriteLiteral(@"lass=""bg-light text-black"">
                                                                <tr>
                                                                    <th width=""40%"">ProductType Name</th>
                                                                    <th width=""40%"">Product Name</th>
                                                                    <th width=""10%"">Quantity</th>
                                                                    <th width=""10%""></th>
                                                                </tr>
                                                            </thead>
                                                            <tbody id=""divListFieldRows""></tbody>
                                                        </table>
                                                    </div>
                                                </div>
                                                <button id=""btnAddProductRow"" class=""btn btn-sm btn-pri");
                WriteLiteral(@"mary"" type=""button"" name=""btnAddProductRow"">Add Product</button>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                                <!--Offer List Table -->
                            </div>
                        </div>


                    </div>

                </div>
            </div>
        </div>

    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8088, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591