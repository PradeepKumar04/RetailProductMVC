#pragma checksum "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff5084653dddabcdd87a212672e7e77716c0594"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetails_ProductData), @"mvc.1.0.view", @"/Views/ProductDetails/ProductData.cshtml")]
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
#line 1 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\_ViewImports.cshtml"
using EcommercePortalMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\_ViewImports.cshtml"
using EcommercePortalMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff5084653dddabcdd87a212672e7e77716c0594", @"/Views/ProductDetails/ProductData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2db642589c19bd9156eb475efc5610c89d98da27", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetails_ProductData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommercePortalMVC.Models.ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-userId", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm mr-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor:pointer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserWishlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
  
    ViewData["Title"] = "Product";
    Order order = new Order();
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"card p-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-6\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 258, "\"", 289, 1);
#nullable restore
#line 12 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
WriteAttributeValue("", 264, Model.Product.Image_Name, 264, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"/>\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <h2>");
#nullable restore
#line 15 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
           Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 16 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
             for (int i = 0; i < (int)Model.Product.Rating; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"fa fa-star checked\" style=\"color: orange;\"></span>\r\n");
#nullable restore
#line 19 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
             for (int i = (int)Model.Product.Rating; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"fa fa-star\"></span>\r\n");
#nullable restore
#line 23 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#\" class=\"text-secondary ml-4\"><i class=\"material-icons md-18\" style=\"vertical-align: middle;\">favorite</i>Save for Later</a>\r\n            <hr />\r\n            <h5><b>Small description</b></h5>\r\n            <p class=\"text-secondary\">");
#nullable restore
#line 28 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                                 Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
             if (TempData["wish"].ToString() == "0")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"float-left\">Selling by ");
#nullable restore
#line 31 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                                            Write(Model.Vendor.VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div>\r\n                    <span>(</span>\r\n");
#nullable restore
#line 34 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                     for (int i = 0; i < (int)Model.Vendor.Rating; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"fa fa-star checked\" style=\"color: orange;\"></span>\r\n");
#nullable restore
#line 37 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                     for (int i = (int)Model.Vendor.Rating; i < 5; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"fa fa-star\"></span>\r\n");
#nullable restore
#line 41 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>)</span>\r\n                </div><br>\r\n");
            WriteLiteral("                <h5><b>&#8377; ");
#nullable restore
#line 45 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                          Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n");
#nullable restore
#line 46 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                 if (TempData["user"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1845, "\"", 1999, 1);
#nullable restore
#line 48 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
WriteAttributeValue("", 1852, Url.Action("OrderItem", "Checkout", new { orderId = 0, VendorId = Model.Vendor.Id, ProductId = Model.Product.Id, UserId = (int)TempData["user"] }), 1852, 147, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Buy Now</a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff5084653dddabcdd87a212672e7e77716c059411288", async() => {
                WriteLiteral("<i class=\"material-icons md-18\" style=\"vertical-align: middle;\">shopping_cart</i>Add to Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                                                                                                 WriteLiteral(Model.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3 class=\"text-danger\">Product is Out of Stock</h3>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff5084653dddabcdd87a212672e7e77716c059415067", async() => {
                WriteLiteral("Add to Wishlist");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                                                                                                 WriteLiteral(ViewContext.RouteData.Values["uid"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
                                                                                                                                                            WriteLiteral(Model.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "D:\Stage-4\RetailProductMVC\EcommercePortalMVC\Views\ProductDetails\ProductData.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EcommercePortalMVC.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
