#pragma checksum "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8122e2693aca6f5f674d843fcbb273ad2a27bcd1"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Index.razor"
using LoginComponet;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n        Hi, ");
                __builder2.AddContent(3, 
#nullable restore
#line 5 "C:\Users\vaiti\Documents\GitHub\DNP3\DNP3Client\Pages\Index.razor"
             context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(4, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<LoginComponet.Login>(5);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591