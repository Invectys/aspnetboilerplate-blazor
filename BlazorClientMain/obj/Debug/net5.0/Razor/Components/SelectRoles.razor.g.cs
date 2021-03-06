#pragma checksum "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\SelectRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03b68992a3302c8bc5dbf8a8a18341d6ed48b656"
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
    public partial class SelectRoles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatList>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 2 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\SelectRoles.razor"
     foreach (var role in _rolesStates)
    {
        if (role == null)
            continue;


#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatListItem>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatCheckbox<bool>>(4);
                    __builder3.AddAttribute(5, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 9 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\SelectRoles.razor"
                                role.State

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, 
#nullable restore
#line 9 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\SelectRoles.razor"
                                                          (v) => Changed(v,role)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(7, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(
#nullable restore
#line 9 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\SelectRoles.razor"
                                                                                                   ()=>role.State

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\SelectRoles.razor"
                                 role.Role

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 12 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\SelectRoles.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Components\SelectRoles.razor"
       


    [Parameter]
    public string[] Value
    {
        get
        {
            return _rolesStates.Where(p => p.State == true).Select(p => p.Role).ToArray();
        }
        set
        {
            _value = value;
        }
    }

    [Parameter] public EventCallback<string[]> ValueChanged { get; set; }

    [Inject] public IBaseApi BaseApi { get; set; }
    [Inject] public IDataMediator DataMediator { get; set; }

    private List<string> _rolesHave = new List<string>();
    private List<RoleDto> _rolesAll = new List<RoleDto>();
    private EventCallback<bool> _optionsChanged;

    private List<RoleNote> _rolesStates = new List<RoleNote>();
    private string[] _value;



    protected override async Task OnInitializedAsync()
    {
        var output = await DataMediator.GetData<ApiOutput<ApiArray<RoleDto>>>("GetAllRoles");
        _rolesAll = output.Result.Items;

        if (_value == null)
        {
            _rolesHave = new List<string>();
        }
        else
        {
            _rolesHave = _value.ToList();
        }
        _rolesStates.Clear();
        foreach (var role in _rolesAll)
        {
            if (role == null)
                continue;
            bool contains = _rolesHave.Contains(role.Name);
            _rolesStates.Add(new RoleNote()
            {
                Role = role.Name,
                State = contains
            });
        }
    }





    protected override async Task OnParametersSetAsync()
    {
        var output = await DataMediator.GetData<ApiOutput<ApiArray<RoleDto>>>("GetAllRoles");
        _rolesAll = output.Result.Items;
        await base.OnParametersSetAsync();
    }


    private class RoleNote
    {
        public string Role { get; set; }
        public bool State { get; set; }
    }


    void Changed(bool state, RoleNote note)
    {
        note.State = state;
        ValueChanged.InvokeAsync(Value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
