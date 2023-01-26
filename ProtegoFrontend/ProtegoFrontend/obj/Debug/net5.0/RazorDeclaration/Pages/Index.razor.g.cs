// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Index.razor"
using MasProjekt.Backoffice.Connection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Index.razor"
using MasProjekt.Backoffice.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Index.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Index.razor"
using ProtegoFrontend.Connection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\Users\mateu\source\repos\MasProject\ProtegoFrontend\ProtegoFrontend\Pages\Index.razor"
      
    private Customer customer;
    protected async override void OnInitialized()
    {
        DataManipulator.LoadCustomerData(await Http.GetFromJsonAsync<List<CustomersModel>>("sample-data/Customers.json"));
        DataManipulator.LoadBrandsData(await Http.GetFromJsonAsync<List<BrandsModel>>("sample-data/Brands.json"));
        DataManipulator.LoadModelsData(await Http.GetFromJsonAsync<List<ModelsModel>>("sample-data/Models.json"));
        DataManipulator.LoadVehiclesData(await Http.GetFromJsonAsync<List<VehiclesModel>>("sample-data/Vehicles.json"));
        DataManipulator.LoadInsurancesData(await Http.GetFromJsonAsync<List<InsurancesModel>>("sample-data/Insurances.json"));
    }

    private async Task<IEnumerable<Customer>> SearchCustomer(string searchText)
    {
        return await Task.FromResult(Customer.Customers.Where(x => x.ContactNumber.Contains(searchText)).ToList());
    }

    private void GetCustomerAndChangePage()
    {
        if (customer != null)
            NavManager.NavigateTo($"/Dashboard/{customer.CustomerId}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
