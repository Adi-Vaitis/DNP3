#pragma checksum "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9cda67f37544d2e560211c994c4ef2dcb92f6fc"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP3Client.Pages.Edits
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
#line 2 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
using DNP3Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditChild/{IdFamily:int}/{IdChild:int}")]
    public partial class EditChild : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "EditChild, Id ");
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                   IdChild

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                  childToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(11, "<label for=\"inputFirstname\">First name</label>\n                ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "id", "inputFirstname");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                                         childToEdit.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => childToEdit.FirstName = __value, childToEdit.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(21, "<label for=\"inputLastname\">Last name</label>\n                ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "id", "inputLastname");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                                        childToEdit.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => childToEdit.LastName = __value, childToEdit.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-row");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(33, "<label for=\"inputHairColor\">Hair Color</label>\n                ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "text");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "id", "inputHairColor");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                                         childToEdit.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => childToEdit.HairColor = __value, childToEdit.HairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(43, "<label for=\"inputEyeColor\">Eye Color</label>\n                ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "text");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "id", "inputEyeColor");
                __builder2.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                                        childToEdit.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => childToEdit.EyeColor = __value, childToEdit.EyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-row");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(55, "<label for=\"inputAge\">Age</label>\n                ");
                __builder2.OpenElement(56, "input");
                __builder2.AddAttribute(57, "type", "number");
                __builder2.AddAttribute(58, "class", "form-control col-md-2");
                __builder2.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                                childToEdit.Age

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => childToEdit.Age = __value, childToEdit.Age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\n            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group col-md-2");
                __builder2.AddMarkupContent(64, "<label for=\"inputSex\">Sex</label>\n                ");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "type", "text");
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "id", "inputSex");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                                   childToEdit.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => childToEdit.Sex = __value, childToEdit.Sex));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n            ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group col-md-2");
                __builder2.AddMarkupContent(74, "<label for=\"inputWeight\">Weight</label>\n                ");
                __builder2.OpenElement(75, "input");
                __builder2.AddAttribute(76, "type", "text");
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "id", "inputWeight");
                __builder2.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                                      childToEdit.Weight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => childToEdit.Weight = __value, childToEdit.Weight));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\n            ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group col-md-2");
                __builder2.AddMarkupContent(84, "<label for=\"inputHeight\">Height</label>\n                ");
                __builder2.OpenElement(85, "input");
                __builder2.AddAttribute(86, "type", "text");
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.AddAttribute(88, "id", "inputHeight");
                __builder2.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                                      childToEdit.Height

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => childToEdit.Height = __value, childToEdit.Height));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n        ");
                __builder2.OpenElement(92, "button");
                __builder2.AddAttribute(93, "type", "submit");
                __builder2.AddAttribute(94, "class", "btn btn-primary");
                __builder2.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(96, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\n        ");
                __builder2.OpenElement(98, "button");
                __builder2.AddAttribute(99, "type", "submit");
                __builder2.AddAttribute(100, "class", "btn btn-warning");
                __builder2.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
                                                                Remove

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(102, "Remove");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Edits\EditChild.razor"
       

    [Parameter]
    public int IdFamily { get; set; }

    [Parameter]
    public int IdChild { get; set; }

    private Child childToEdit = new Child();
    private Family _family = new Family();

    protected override async Task OnParametersSetAsync()
    {
        _family = await familyService.GetFamilyAsync(IdFamily);
        for (int i = 0; i < _family.Children.Count; i++)
        {
            if (_family.Children[i].Id == IdChild)
            {
                childToEdit = _family.Children[i];
            }
        }
    }

    public void Save()
    {
        for (int i = 0; i < _family.Children.Count; i++)
        {
            if (_family.Children[i].Id == childToEdit.Id)
            {
                _family.Children.Remove(_family.Children[i]);
                _family.Children.Add(childToEdit);
            }
        }
        familyService.UpdateAsync(_family);
        NavigationManager.NavigateTo($"/FamilyInfo/{IdFamily}");
    }

    public void Remove()
    {
        for (int i = 0; i < _family.Children.Count; i++)
        {
            if (_family.Children[i].Id == childToEdit.Id)
            {
                _family.Children.Remove(_family.Children[i]);
            }
        }
        familyService.UpdateAsync(_family);
        NavigationManager.NavigateTo($"/FamilyInfo/{IdFamily}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService familyService { get; set; }
    }
}
#pragma warning restore 1591
