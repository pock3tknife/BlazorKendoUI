// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorKendoUI.Pages
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
#line 3 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
using BlazorKendoUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
using BlazorKendoUI.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart")]
    public partial class Chart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
      
    List<WeatherForecast> forecasts { get; set; }

    protected override async Task OnInitializedAsync()
    {
        DateTime currDate = DateTime.Now.Date;
        var allForecasts = await ForecastService.GetForecastListAsync(currDate);
        // use only dates within the last month as a reasonable range of data considering the BaseUnit
        forecasts = allForecasts.Where(f => currDate.Subtract(f.Date.Date) < new TimeSpan(30, 0, 0, 0) ).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
