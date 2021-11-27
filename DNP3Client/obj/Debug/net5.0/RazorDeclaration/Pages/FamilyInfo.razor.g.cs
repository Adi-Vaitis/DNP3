// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNP3Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using DNP3Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\_Imports.razor"
using DNP3Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\FamilyInfo.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\FamilyInfo.razor"
using DNP3Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FamilyInfo/{IdFamily:int}")]
    public partial class FamilyInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 371 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\FamilyInfo.razor"
 
    [Parameter]
    public int IdFamily { get; set; }

    private Family _family;


    protected override async Task OnParametersSetAsync()
    {
        base.OnInitialized();
        _family = await FamiliesData.GetFamilyAsync(IdFamily);
    }

    private int Salary(List<Adult> adults)
    {
        int sum = 0;
        foreach (var vAdult in adults)
        {
            sum += vAdult.JobTitle.Salary;
        }

        return sum;
    }

    private void EditFamily()
    {
        NavigationManager.NavigateTo($"/EditFamily/{IdFamily}");
    }

    private void EditAdult(int idOfThatAdult)
    {
        NavigationManager.NavigateTo($"/EditAdult/{IdFamily}/{idOfThatAdult}");
    }

    private void EditChild(int Index)
    {
        NavigationManager.NavigateTo($"/EditChild/{IdFamily}/{Index}");
    }


    private void EditPet(int chilId, int Id)
    {
        NavigationManager.NavigateTo($"/EditPet/{IdFamily}/{chilId}/{Id}");
    }

    private void AddAdult()
    {
        NavigationManager.NavigateTo($"/AddAdult/{IdFamily}");
    }

    private void AddChild()
    {
        NavigationManager.NavigateTo($"/AddChild/{IdFamily}");
    }


    private void AddPet(int childId)
    {
        NavigationManager.NavigateTo($"/AddPet/{IdFamily}/{childId}");
    }

    private void AddPetToFamily()
    {
        NavigationManager.NavigateTo($"/AddPetToFamily/{IdFamily}/");
    }

    private void AddInterestForChild(int childId)
    {
        NavigationManager.NavigateTo($"/AddInterest/{IdFamily}/{childId}");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamiliesData { get; set; }
    }
}
#pragma warning restore 1591
