#pragma checksum "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05888b17098acb99cb9813303c8f597eca0f41bc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatToastContainer>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MatBlazor.MatPortalHost>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "BaseLoadingScreen");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(6);
            __builder.AddAttribute(7, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 5 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenElement(9, "AuthorizeRouteView");
                __builder2.AddAttribute(10, "RouteData", 
#nullable restore
#line 7 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\App.razor"
                                        routeData

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(11, "DefaultLayout", 
#nullable restore
#line 7 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(12, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(13);
                __builder2.AddAttribute(14, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 11 "D:\GitHub\aspnetboilerplate-blazor\BlazorClient\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(16, "NotFounded404");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
