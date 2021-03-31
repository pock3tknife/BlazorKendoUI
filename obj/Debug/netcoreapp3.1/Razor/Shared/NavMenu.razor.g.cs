#pragma checksum "C:\Blazor repo\blazor-repo\BlazorKendoUI\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "748361c9c409a035a2ebcade4e8758cd789e104e"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, @"<style>
    /*
        Styles normally go in a .css file.
        This is just a simple example to get you started.
        Feel free to relocate this to site.css if you wish.
    */
    .k-nav.k-link {
        padding: 6px 12px;
        line-height: 1.4285714286;
    }
    .k-nav.k-state-active {
        font-weight: bold;
        color: #656565;
    }
    .k-menu-group .k-item > .k-menu-link {
        line-height: 1.4285714286;
        padding: 4px 8px;
        padding-right: 32px;
        display: -ms-flexbox;
        display: flex;
        -ms-flex-direction: row;
        flex-direction: row;
        -ms-flex-align: center;
        align-items: center;
        position: relative;
    }
</style>

");
            __Blazor.BlazorKendoUI.Shared.NavMenu.TypeInference.CreateTelerikMenu_0(__builder, 1, 2, 
#nullable restore
#line 31 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Shared\NavMenu.razor"
                    MenuItems

#line default
#line hidden
#nullable disable
            , 3, (item) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n");
                __builder2.AddContent(5, "            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
                __builder2.AddAttribute(7, "href", 
#nullable restore
#line 34 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Shared\NavMenu.razor"
                            item.Url

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(8, "target", 
#nullable restore
#line 35 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Shared\NavMenu.razor"
                               IsInternalPage(item.Url) ? "" : "_blank"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(9, "class", "k-nav k-link k-menu-link");
                __builder2.AddAttribute(10, "ActiveClass", "k-state-active");
                __builder2.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 38 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Shared\NavMenu.razor"
                              item.Url == "/" ? NavLinkMatch.All : NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n                ");
                    __builder3.AddContent(14, 
#nullable restore
#line 39 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Shared\NavMenu.razor"
                 item.Text

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(15, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n");
                __builder2.AddContent(17, "    ");
            }
            );
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
namespace __Blazor.BlazorKendoUI.Shared.NavMenu
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikMenu_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikMenu<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ItemTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
