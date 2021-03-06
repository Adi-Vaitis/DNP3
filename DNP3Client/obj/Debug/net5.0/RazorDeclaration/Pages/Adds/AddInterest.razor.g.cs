// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNP3Client.Pages.Adds
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Adds\AddInterest.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Adds\AddInterest.razor"
using DNP3Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Adds\AddInterest.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Adds\AddInterest.razor"
using DNP3Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddInterest/{IdFamily:int}/{ChildId:int}")]
    public partial class AddInterest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Adds\AddInterest.razor"
       

    [Parameter]
    public int IdFamily { get; set; }

    [Parameter]
    public int ChildId { get; set; }

    
    private Family _family = new Family();
    private Interest _newInterest = new Interest();
    private Child _child;

    protected override async Task OnParametersSetAsync()
    {
        _family = await FamilyService.GetFamilyAsync(IdFamily);
        _child = _family.Children.FirstOrDefault(c => c.Id == ChildId);
    }

    public void AddInterestToChild()
    {
        for (int i = 0; i < _family.Children.Count; i++)
        {
            var child = _family.Children[i];
            if (child.Id == _child.Id)
            {
                child.Interests.Add(_newInterest);
                _family.Children[i] = child;
            }
        }
        FamilyService.UpdateAsync(_family);
        NavigationManager.NavigateTo($"/FamilyInfo/{IdFamily}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
