// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorKendoUI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using BlazorKendoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using BlazorKendoUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Blazor repo\blazor-repo\BlazorKendoUI\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Shared\NavMenu.razor"
using BlazorKendoUI.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Shared\NavMenu.razor"
       
    List<MenuItem> MenuItems { get; set; }

    MenuItem SelectedMenuItem { get; set; }

    bool IsInternalPage(string url)
    {
        if (string.IsNullOrEmpty(url)) return false;

        var protocols = new string[] { "//", "http://", "https://" };
        return !protocols.Any(p => url.StartsWith(p.ToLower()));
    }

    protected override void OnInitialized()
    {
        MenuItems = new List<MenuItem>()
    {
            new MenuItem()
            {
                Text = "Home",
                Url = "/",
            },
            new MenuItem()
            {
                Text = "Grid",
                Url = "/grid"
            },
            new MenuItem()
            {
                Text = "Chart",
                Url = "/chart"
            },
            new MenuItem()
            {
                Text = "Form",
                Url = "/form"
            },
            new MenuItem()
            {
                Text = "Telerik UI for Blazor",
                Url = "https://www.telerik.com/blazor-ui",
                Items = new List<MenuItem>()
                {
                    new MenuItem()
                    {
                        Text = "Documentation",
                        Url = "https://docs.telerik.com/blazor-ui/introduction"
                    },
                    new MenuItem()
                    {
                        Text = "Live Demos",
                        Url = "https://demos.telerik.com/blazor-ui"
                    }
                    ,
                    new MenuItem()
                    {
                        Text = "Theme Builder",
                        Url = "https://themebuilder.telerik.com"
                    }
                }
            }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
