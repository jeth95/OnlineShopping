#pragma checksum "C:\Users\Fabrice\Desktop\OnlineShop\OnlineShop\Pages\Products\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f538d09d11a0392694874e4e21c0816c2c86ab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineShop.Pages.Products.Pages_Products_Checkout), @"mvc.1.0.razor-page", @"/Pages/Products/Checkout.cshtml")]
namespace OnlineShop.Pages.Products
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
#line 1 "C:\Users\Fabrice\Desktop\OnlineShop\OnlineShop\Pages\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f538d09d11a0392694874e4e21c0816c2c86ab8", @"/Pages/Products/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e3ad37987f7229bc4a567de435ce81086ac88ba", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products_Checkout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Fabrice\Desktop\OnlineShop\OnlineShop\Pages\Products\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- SECTION -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">

            <div class=""col-md-7"">
                <!-- Billing Details -->
                <div class=""billing-details"">
                    <div class=""section-title"">
                        <h3 class=""title"">Billing address</h3>
                    </div>
                    <div class=""form-group"">
                        <input class=""input"" type=""text"" name=""first-name"" placeholder=""First Name"">
                    </div>
                    <div class=""form-group"">
                        <input class=""input"" type=""text"" name=""last-name"" placeholder=""Last Name"">
                    </div>
                    <div class=""form-group"">
                        <input class=""input"" type=""email"" name=""email"" placeholder=""Email"">
                    </div>
                    <div class=""form-group"">
                        <input class=""input"" type=");
            WriteLiteral(@"""text"" name=""address"" placeholder=""Address"">
                    </div>
                    <div class=""form-group"">
                        <input class=""input"" type=""text"" name=""city"" placeholder=""City"">
                    </div>
                    <div class=""form-group"">
                        <input class=""input"" type=""text"" name=""country"" placeholder=""Country"">
                    </div>
                    <div class=""form-group"">
                        <input class=""input"" type=""text"" name=""zip-code"" placeholder=""ZIP Code"">
                    </div>
                    <div class=""form-group"">
                        <input class=""input"" type=""tel"" name=""tel"" placeholder=""Telephone"">
                    </div>
                    <div class=""form-group"">
                        <div class=""input-checkbox"">
                            <input type=""checkbox"" id=""create-account"">
                            <label for=""create-account"">
                                <span></span>");
            WriteLiteral(@"
                                Create Account?
                            </label>
                            <div class=""caption"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt.</p>
                                <input class=""input"" type=""password"" name=""password"" placeholder=""Enter Your Password"">
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /Billing Details -->
                <!-- Shiping Details -->
                <div class=""shiping-details"">
                    <div class=""section-title"">
                        <h3 class=""title"">Shiping address</h3>
                    </div>
                    <div class=""input-checkbox"">
                        <input type=""checkbox"" id=""shiping-address"">
                        <label for=""shiping-address"">
                            <span></span>
                     ");
            WriteLiteral(@"       Ship to a diffrent address?
                        </label>
                        <div class=""caption"">
                            <div class=""form-group"">
                                <input class=""input"" type=""text"" name=""first-name"" placeholder=""First Name"">
                            </div>
                            <div class=""form-group"">
                                <input class=""input"" type=""text"" name=""last-name"" placeholder=""Last Name"">
                            </div>
                            <div class=""form-group"">
                                <input class=""input"" type=""email"" name=""email"" placeholder=""Email"">
                            </div>
                            <div class=""form-group"">
                                <input class=""input"" type=""text"" name=""address"" placeholder=""Address"">
                            </div>
                            <div class=""form-group"">
                                <input class=""input"" type=""text"" name=");
            WriteLiteral(@"""city"" placeholder=""City"">
                            </div>
                            <div class=""form-group"">
                                <input class=""input"" type=""text"" name=""country"" placeholder=""Country"">
                            </div>
                            <div class=""form-group"">
                                <input class=""input"" type=""text"" name=""zip-code"" placeholder=""ZIP Code"">
                            </div>
                            <div class=""form-group"">
                                <input class=""input"" type=""tel"" name=""tel"" placeholder=""Telephone"">
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /Shiping Details -->
                <!-- Order notes -->
                <div class=""order-notes"">
                    <textarea class=""input"" placeholder=""Order Notes""></textarea>
                </div>
                <!-- /Order notes -->
            </div>

   ");
            WriteLiteral(@"         <!-- Order Details -->
            <div class=""col-md-5 order-details"">
                <div class=""section-title text-center"">
                    <h3 class=""title"">Your Order</h3>
                </div>
                <div class=""order-summary"">
                    <div class=""order-col"">
                        <div><strong>PRODUCT</strong></div>
                        <div><strong>TOTAL</strong></div>
                    </div>
                    <div class=""order-products"">
                        <div class=""order-col"">
                            <div>1x Product Name Goes Here</div>
                            <div>$980.00</div>
                        </div>
                        <div class=""order-col"">
                            <div>2x Product Name Goes Here</div>
                            <div>$980.00</div>
                        </div>
                    </div>
                    <div class=""order-col"">
                        <div>Shiping</div>
          ");
            WriteLiteral(@"              <div><strong>FREE</strong></div>
                    </div>
                    <div class=""order-col"">
                        <div><strong>TOTAL</strong></div>
                        <div><strong class=""order-total"">$2940.00</strong></div>
                    </div>
                </div>
                <div class=""payment-method"">
                    <div class=""input-radio"">
                        <input type=""radio"" name=""payment"" id=""payment-1"">
                        <label for=""payment-1"">
                            <span></span>
                            Direct Bank Transfer
                        </label>
                        <div class=""caption"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                        </div>
                    </div>
                    <div class=""input-radio"">
                        <input type=""radio"" name=""");
            WriteLiteral(@"payment"" id=""payment-2"">
                        <label for=""payment-2"">
                            <span></span>
                            Cheque Payment
                        </label>
                        <div class=""caption"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                        </div>
                    </div>
                    <div class=""input-radio"">
                        <input type=""radio"" name=""payment"" id=""payment-3"">
                        <label for=""payment-3"">
                            <span></span>
                            Paypal System
                        </label>
                        <div class=""caption"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                        </div>
                    </div>
");
            WriteLiteral(@"                </div>
                <div class=""input-checkbox"">
                    <input type=""checkbox"" id=""terms"">
                    <label for=""terms"">
                        <span></span>
                        I've read and accept the <a href=""#"">terms & conditions</a>
                    </label>
                </div>
                <a href=""#"" class=""primary-btn order-submit"">Place order</a>
            </div>
            <!-- /Order Details -->
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /SECTION -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShop.Pages.Products.CheckoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineShop.Pages.Products.CheckoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineShop.Pages.Products.CheckoutModel>)PageContext?.ViewData;
        public OnlineShop.Pages.Products.CheckoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
