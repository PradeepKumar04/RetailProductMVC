#pragma checksum "C:\Users\dilip\Project\RetailProductMVC\EcommercePortalMVC\Views\Checkout\PaymentAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faa9ff050fdc4a54dcfeb92ea270f63dc882b6f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_PaymentAddress), @"mvc.1.0.view", @"/Views/Checkout/PaymentAddress.cshtml")]
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
#line 1 "C:\Users\dilip\Project\RetailProductMVC\EcommercePortalMVC\Views\_ViewImports.cshtml"
using EcommercePortalMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dilip\Project\RetailProductMVC\EcommercePortalMVC\Views\_ViewImports.cshtml"
using EcommercePortalMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa9ff050fdc4a54dcfeb92ea270f63dc882b6f3", @"/Views/Checkout/PaymentAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2db642589c19bd9156eb475efc5610c89d98da27", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_PaymentAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EcommercePortalMVC.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block waves-effect waves-light mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!--Section: Block Content-->\r\n<section>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faa9ff050fdc4a54dcfeb92ea270f63dc882b6f34881", async() => {
                WriteLiteral(@"
        <!--Grid row-->
        <div class=""row"">

            <!--Grid column-->
            <div class=""col-lg-7 mb-4 mr-0"">

                <!-- Card -->
                <div class=""card wish-list p-5 w-75"">
                    <div class=""card-body"">

                        <h5 class=""mb-2"">Billing details</h5>
                        <hr>

                        <!-- Grid row -->
                    </div>
                    <!-- Address Part 1 -->
                    <div class=""md-form md-outline mt-0"">
                        <label for=""form14"">Door No/Flat No</label>
                        <span class=""text-danger"">*</span>

                        <input type=""text"" id=""form14"" placeholder=""House number and street name"" class=""form-control"" required>
                    </div>

                    <!-- Address Part 2 -->
                    <div class=""md-form md-outline"">
                        <label for=""form15"">Area/Landmark</label>
                        <spa");
                WriteLiteral(@"n class=""text-danger"">*</span>


                        <input type=""text"" id=""form15"" placeholder=""Apartment, suite, unit etc. (optional)""
                               class=""form-control"" required>
                    </div>

                    <!-- Postcode / ZIP -->
                    <div class=""row ml-1"">
                        <div class=""md-form md-outline"">
                            <label for=""form16"">Postcode / ZIP</label>
                            <span class=""text-danger"">*</span>


                            <input type=""text"" id=""form16"" class=""form-control w-50"" maxlength=""6"" min=""50000"" required>
                        </div>

                        <!-- Town / City -->
                        <div class=""md-form md-outline"">
                            <label for=""form17"">Town / City</label>
                            <span class=""text-danger"">*</span>


                            <input type=""text"" id=""form17"" class=""form-control"" required>
           ");
                WriteLiteral(@"             </div>
                    </div>


                    <!-- Additional information -->
                </div>
                <!-- Card -->

            </div>
            <!--Grid column-->
            <!--Grid column-->
            <div class=""col-lg-5"">
                <!-- Card -->
                <div class=""card mb-4 p-3"">
                    <div class=""card-body"">
                        <div class=""float-right"">
                            <img class=""mr-2"" width=""45""
                                 src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/visa.svg""
                                 alt=""Visa"">
                            <img class=""mr-2"" width=""45""
                                 src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/amex.svg""
                                 alt=""American Express"">
                            <img class=""mr-2"" width=""45""
                         ");
                WriteLiteral(@"        src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/mastercard.svg""
                                 alt=""Mastercard"">
                        </div>
                        <h5 class=""mb-3"">Payment</h5><hr>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault1"">
                            <label class=""form-check-label"" for=""flexRadioDefault1"">
                                Debit Card
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault2"" checked>
                            <label class=""form-check-label"" for=""flexRadioDefault2"">
                                Credit Card
                            </label>
                        </div><hr>
          ");
                WriteLiteral(@"              <div class=""md-form md-outline mt-0"">
                            <label for=""form14"">Name on Card</label>
                            <span class=""text-danger"">*</span>


                            <input type=""text"" id=""form14"" class=""form-control"" required>
                        </div>

                        <!-- Address Part 2 -->
                        <div class=""md-form md-outline"">
                            <label for=""form15"">Card Number</label>
                            <span class=""text-danger"">*</span>


                            <input type=""text"" id=""form15"" class=""form-control"" required>
                        </div>

                        <!-- Postcode / ZIP -->
                        <div class=""row"">
                            <div class=""col md-form md-outline float-left"">
                                <label for=""form16"">Expiration</label>
                                <span class=""text-danger"">*</span>

                            ");
                WriteLiteral(@"    <input type=""text"" id=""form16"" class=""form-control"" placeholder=""MM/YY"" required>
                            </div>

                            <!-- Town / City -->
                            <div class=""col md-form md-outline"">
                                <label for=""form17"">CVV</label>
                                <span class=""text-danger"">*</span>
                                <input type=""password"" id=""form17"" class=""form-control"" maxlength=""3"" max=""999"" min=""001"" required>
                            </div>
                        </div>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faa9ff050fdc4a54dcfeb92ea270f63dc882b6f311223", async() => {
                    WriteLiteral("Make purchase");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <!-- Card -->\r\n                <!-- Card -->\r\n                <!-- Card -->\r\n\r\n            </div>\r\n            <!--Grid column-->\r\n\r\n        </div>\r\n        <!--Grid row-->\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n<!--Section: Block Content-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EcommercePortalMVC.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
