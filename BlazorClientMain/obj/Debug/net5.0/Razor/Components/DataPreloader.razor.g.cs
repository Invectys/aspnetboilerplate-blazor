#pragma checksum "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\DataPreloader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac017b1180ee8f0987aeaf5fea676ed999d6af15"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientMain.Components
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
    public partial class DataPreloader : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\DataPreloader.razor"
       


    protected override async Task OnInitializedAsync()
    {

        //preload perms and roles
        //var perms = await DataMediator.GetData<ApiOutput<ApiArray<PermissionDto>>>("GetAllPermissions");

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataMediator DataMediator { get; set; }
    }
}
#pragma warning restore 1591
