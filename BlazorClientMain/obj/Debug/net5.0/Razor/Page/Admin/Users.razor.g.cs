#pragma checksum "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56ef37c0a27b70f1604b4d378986d04d7a767c2d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientMain.Page.Admin
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
#nullable restore
#line 2 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Users Page</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(1);
            __builder.AddAttribute(2, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
                    ()=>OpenCreateUser()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Create");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __Blazor.BlazorClientMain.Page.Admin.Users.TypeInference.CreateMatTable_0(__builder, 6, 7, 
#nullable restore
#line 9 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
                  _list

#line default
#line hidden
#nullable disable
            , 8, "mat-elevation-z5", 9, "User name", 10, (__builder2) => {
                __builder2.AddMarkupContent(11, "<th>User name</th>\r\n        ");
                __builder2.AddMarkupContent(12, "<th>Email</th>\r\n        ");
                __builder2.AddMarkupContent(13, "<th>Name</th>\r\n        ");
                __builder2.AddMarkupContent(14, "<th>Surname</th>\r\n        ");
                __builder2.AddMarkupContent(15, "<th>Last login time</th>\r\n        ");
                __builder2.AddMarkupContent(16, "<th>Creation time</th>\r\n        ");
                __builder2.AddMarkupContent(17, "<th>Actions</th>");
            }
            , 18, (context) => (__builder2) => {
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 21 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
             context.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "th");
                __builder2.AddContent(23, 
#nullable restore
#line 22 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
             context.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 23 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
             context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 24 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
             context.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 25 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
             context.LastLoginTime.ToString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 26 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
             context.CreationTime

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "td");
                __builder2.OpenComponent<MatBlazor.MatButton>(38);
                __builder2.AddAttribute(39, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
                                ()=>OpenEditUser(context)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(41, "Edit");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatButton>(43);
                __builder2.AddAttribute(44, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
                                ()=>DeleteUser(context)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(46, "Delete");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\GitHub\aspnetboilerplate-blazor\BlazorClientMain\Page\Admin\Users.razor"
       


    [Inject] public IMatDialogService DialogService { get; set; }
    [Inject] public IBaseApi ApiBase { get; set; }

    private List<UserDto> _list = new List<UserDto>();


    protected override async Task OnInitializedAsync()
    {
        var result = await ApiBase.GetAllUsers();
        if(result.Success)
        {
            _list = result.Result.Items;
        }
    }


    async Task OpenEditUser(UserDto user)
    {
        var opt = new MatDialogOptions()
        {
            Attributes = new Dictionary<string, object>
        {
                { "Edit",user }
            }

        };

        var result = await DialogService.OpenAsync(typeof(EditUser), opt);
    }

    async Task OpenCreateUser()
    {
        var result = await DialogService.OpenAsync(typeof(CreateUser), null);
    }

    async Task DeleteUser(UserDto user)
    {
        var output = await ApiBase.DeleteUser(new ApiIdInput<long>(user.Id));
        if(output.Success)
        {
            _list.Remove(user);
        }
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorClientMain.Page.Admin.Users
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "FilterByColumnName", __arg2);
        __builder.AddAttribute(__seq3, "MatTableHeader", __arg3);
        __builder.AddAttribute(__seq4, "MatTableRow", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
