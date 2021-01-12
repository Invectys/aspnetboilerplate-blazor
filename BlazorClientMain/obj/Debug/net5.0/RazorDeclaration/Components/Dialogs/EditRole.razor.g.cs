// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorClientMain.Components.Dialogs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Main.Shared.Api;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using BlazorClientMain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using BlazorClientMain.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using BlazorClientMain.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using BlazorClientMain.Components.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Main.Shared.Models.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using Main.Shared.Models.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\_Imports.razor"
using ApiDataMediator;

#line default
#line hidden
#nullable disable
    public partial class EditRole : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\Dialogs\EditRole.razor"
 


    [CascadingParameter] public MatDialogReference DialogReference { get; set; }

    [Inject] public IBaseApi BaseApi { get; set; }

    [Parameter] public RoleDto Edit { get; set; }

    protected override void OnInitialized()
    {

    }



    async Task Create()
    {

        var output = await BaseApi.UpdateRole(Edit);
        if (output != null)
        {
            DialogReference.Close(output);
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatDialogService MatDialogService { get; set; }
    }
}
#pragma warning restore 1591
