#pragma checksum "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0155eba29eaa1b1894178e0ece304a614301c979"
// <auto-generated/>
#pragma warning disable 1591
namespace ProtegoFrontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using ProtegoFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using ProtegoFrontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
using MasProjekt.Backoffice.Models.Customers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dashboard/{CustomerId:int}")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style b-gi90vsa0ba>\r\n    body{\r\n        background-color: rgb(239, 239, 239);\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "wrapper");
            __builder.AddAttribute(3, "b-gi90vsa0ba");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "first");
            __builder.AddAttribute(6, "b-gi90vsa0ba");
            __builder.AddMarkupContent(7, "<h1 style=\"font-family: Arial\" b-gi90vsa0ba>Customer information</h1>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "id");
            __builder.AddAttribute(10, "style", "background-color: white; border-radius: 25px; box-shadow: 10px 10px 5px lightblue");
            __builder.AddAttribute(11, "b-gi90vsa0ba");
#nullable restore
#line 14 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
             if (customer.GetCustomerData().Contains("NIP: "))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "b-gi90vsa0ba");
            __builder.OpenElement(14, "tr");
            __builder.AddAttribute(15, "b-gi90vsa0ba");
            __builder.AddMarkupContent(16, "<td style=\"font-family: Arial; font-size: 24px; float: left\" b-gi90vsa0ba>Company Name: </td>\r\n                        ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "style", "font-family: Arial; font-size: 24px;");
            __builder.AddAttribute(19, "b-gi90vsa0ba");
#nullable restore
#line 19 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(20, corpoCustomer.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "tr");
            __builder.AddAttribute(23, "b-gi90vsa0ba");
            __builder.AddMarkupContent(24, "<td style=\"font-family: Arial; font-size: 24px; float: left\" b-gi90vsa0ba>NIP: </td>\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "style", "font-family: Arial; font-size: 24px;");
            __builder.AddAttribute(27, "b-gi90vsa0ba");
#nullable restore
#line 23 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(28, corpoCustomer.NIP);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "tr");
            __builder.AddAttribute(31, "b-gi90vsa0ba");
            __builder.AddMarkupContent(32, "<td style=\"font-family: Arial; font-size: 24px; float: left\" b-gi90vsa0ba>Adress: </td>\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "style", "font-family: Arial; font-size: 24px;");
            __builder.AddAttribute(35, "b-gi90vsa0ba");
#nullable restore
#line 27 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(36, corpoCustomer.Adress.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "tr");
            __builder.AddAttribute(39, "b-gi90vsa0ba");
            __builder.AddMarkupContent(40, "<td style=\"font-family: Arial; font-size: 24px; float: left\" b-gi90vsa0ba>Email: </td>\r\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "style", "font-family: Arial; font-size: 24px;");
            __builder.AddAttribute(43, "b-gi90vsa0ba");
#nullable restore
#line 31 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(44, corpoCustomer.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
             if (customer.GetCustomerData().Contains("Pesel: "))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "table");
            __builder.AddAttribute(46, "b-gi90vsa0ba");
            __builder.OpenElement(47, "tr");
            __builder.AddAttribute(48, "b-gi90vsa0ba");
            __builder.AddMarkupContent(49, "<td style=\"font-family: Arial; font-size: 24px; float: left\" b-gi90vsa0ba>  Name: </td>\r\n                        ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "style", "font-family: Arial; font-size: 24px;");
            __builder.AddAttribute(52, "b-gi90vsa0ba");
#nullable restore
#line 40 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(53, retailCustomer.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "tr");
            __builder.AddAttribute(56, "b-gi90vsa0ba");
            __builder.AddMarkupContent(57, "<td style=\"font-family: Arial; font-size: 24px\" b-gi90vsa0ba>  Surname: </td>\r\n                        ");
            __builder.OpenElement(58, "td");
            __builder.AddAttribute(59, "style", "font-family: Arial; font-size: 24px");
            __builder.AddAttribute(60, "b-gi90vsa0ba");
#nullable restore
#line 44 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(61, retailCustomer.Surname);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "tr");
            __builder.AddAttribute(64, "b-gi90vsa0ba");
            __builder.AddMarkupContent(65, "<td style=\"font-family: Arial; font-size: 24px\" b-gi90vsa0ba>  PESEL: </td>\r\n                        ");
            __builder.OpenElement(66, "td");
            __builder.AddAttribute(67, "style", "font-family: Arial; font-size: 24px");
            __builder.AddAttribute(68, "b-gi90vsa0ba");
#nullable restore
#line 48 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(69, retailCustomer.Pesel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "tr");
            __builder.AddAttribute(72, "b-gi90vsa0ba");
            __builder.AddMarkupContent(73, "<td style=\"font-family: Arial; font-size: 24px\" b-gi90vsa0ba>  Number: </td>\r\n                        ");
            __builder.OpenElement(74, "td");
            __builder.AddAttribute(75, "style", "font-family: Arial; font-size: 24px");
            __builder.AddAttribute(76, "b-gi90vsa0ba");
#nullable restore
#line 52 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(77, retailCustomer.ContactNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "tr");
            __builder.AddAttribute(80, "b-gi90vsa0ba");
            __builder.AddMarkupContent(81, "<td style=\"font-family: Arial; font-size: 24px\" b-gi90vsa0ba>  Email: </td>\r\n                        ");
            __builder.OpenElement(82, "td");
            __builder.AddAttribute(83, "style", "font-family: Arial; font-size: 24px");
            __builder.AddAttribute(84, "b-gi90vsa0ba");
#nullable restore
#line 56 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(85, retailCustomer.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "tr");
            __builder.AddAttribute(88, "b-gi90vsa0ba");
            __builder.AddMarkupContent(89, "<td style=\"font-family: Arial; font-size: 24px\" b-gi90vsa0ba>  Adress: </td>\r\n                        ");
            __builder.OpenElement(90, "td");
            __builder.AddAttribute(91, "style", "font-family: Arial; font-size: 24px");
            __builder.AddAttribute(92, "b-gi90vsa0ba");
#nullable restore
#line 60 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(93, retailCustomer.Adress.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "id", "second");
            __builder.AddAttribute(97, "b-gi90vsa0ba");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "id");
            __builder.AddAttribute(100, "style", "background-color: white; border-radius: 25px; box-shadow: 10px 10px 5px lightblue");
            __builder.AddAttribute(101, "b-gi90vsa0ba");
            __builder.OpenElement(102, "table");
            __builder.AddAttribute(103, "b-gi90vsa0ba");
            __builder.OpenElement(104, "tr");
            __builder.AddAttribute(105, "b-gi90vsa0ba");
            __builder.AddMarkupContent(106, "<td style=\"font-family: Arial; font-size: 24px; float: left\" b-gi90vsa0ba>This customer bought: </td>\r\n                    ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "style", "font-family: Arial; font-size: 24px; float: left");
            __builder.AddAttribute(109, "b-gi90vsa0ba");
#nullable restore
#line 72 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
__builder.AddContent(110, GetBoughtProductsNumber());

#line default
#line hidden
#nullable disable
            __builder.AddContent(111, " products");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Dashboard.razor"
           
        [Parameter]
        public int CustomerId { get; set; }
        private Customer customer;
        private RetailCustomer retailCustomer;
        private CorpoCustomer corpoCustomer;


        protected override void OnInitialized()
        {
            customer = Customer.Customers.First(e => e.CustomerId == CustomerId);
            if(customer.GetCustomerData().Contains("Pesel: "))
                retailCustomer = (RetailCustomer)customer;
            else
                corpoCustomer = (CorpoCustomer)customer;
        }

        private int GetBoughtProductsNumber()
        {
            return customer.Insurances.Count();
        }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
