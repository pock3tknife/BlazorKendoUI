#pragma checksum "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87425fff0c4a539b8a9b21e2c5e5319b0a284e65"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row my-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 col-lg-9 border-right");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 10 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
             if(forecasts?.Count > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikChart>(10);
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxes>(13);
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxis>(16);
                    __builder3.AddAttribute(17, "BaseUnit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartCategoryAxisBaseUnit?>(
#nullable restore
#line 14 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                                      ChartCategoryAxisBaseUnit.Weeks

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartCategoryAxisType?>(
#nullable restore
#line 14 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                                                                              ChartCategoryAxisType.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(20, "\r\n                            ");
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxisLabels>(21);
                        __builder4.AddAttribute(22, "Format", "{0:dd MMM}");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartSeriesItems>(26);
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartSeries>(29);
                    __builder3.AddAttribute(30, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesType?>(
#nullable restore
#line 20 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                            ChartSeriesType.Line

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "Name", "High");
                    __builder3.AddAttribute(32, "Color", "red");
                    __builder3.AddAttribute(33, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 21 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                            forecasts

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                             nameof(WeatherForecast.TemperatureF)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "CategoryField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                                     nameof(WeatherForecast.Date)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Aggregate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesAggregate?>(
#nullable restore
#line 24 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                                 ChartSeriesAggregate.Max

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(38, "\r\n                            ");
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartSeriesLabels>(39);
                        __builder4.AddAttribute(40, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 25 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "Template", "#=dataItem.Summary#");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartSeries>(44);
                    __builder3.AddAttribute(45, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesType?>(
#nullable restore
#line 28 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                            ChartSeriesType.Line

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "Name", "Low");
                    __builder3.AddAttribute(47, "Color", "blue");
                    __builder3.AddAttribute(48, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 29 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                            forecasts

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                             nameof(WeatherForecast.TemperatureF)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "CategoryField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                                     nameof(WeatherForecast.Date)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Aggregate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesAggregate?>(
#nullable restore
#line 32 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                                 ChartSeriesAggregate.Min

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(53, "\r\n                            ");
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartSeriesLabels>(54);
                        __builder4.AddAttribute(55, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 33 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(56, "Template", "#=dataItem.Summary#");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartValueAxes>(60);
                __builder2.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(62, "\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartValueAxis>(63);
                    __builder3.AddAttribute(64, "AxisCrossingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object[]>(
#nullable restore
#line 38 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
                                                           new object[] { -50 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(66, "\r\n                            ");
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartValueAxisLabels>(67);
                        __builder4.AddAttribute(68, "Format", "{0} F");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(69, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartTitle>(72);
                __builder2.AddAttribute(73, "Text", "Min and Max temperatures for the upcoming weeks");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 45 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                ");
            __builder.AddMarkupContent(77, "<div class=\"alert alert-info\">No data available.</div>\r\n");
#nullable restore
#line 49 "C:\Blazor repo\blazor-repo\BlazorKendoUI\Pages\Chart.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.AddMarkupContent(80, @"<div class=""col-12 col-lg-3 mt-3 mt-lg-0"">
            <h3>Telerik UI for Blazor Chart</h3>
            <p>The Telerik UI for Blazor Charts provide high quality graphical data visualization options.</p>

            <p>
                They include a variety of chart types and styles that have extensive configuration options. This
                flexibility allows you to quickly and easily create the exact chart you need to fit your specific
                requirements for functionality and appearance.
            </p>

            <p>
                This example uses the following features:
                <ul>
                    <li>
                        <a target=""_blank"" href=""https://docs.telerik.com/blazor-ui/components/chart/data-bind"">Data binding</a>
                    </li>
                    <li>
                        <a target=""_blank"" href=""https://docs.telerik.com/blazor-ui/components/chart/date-axis"">Date axis</a>
                    </li>
                    <li>
                        <a target=""_blank"" href=""https://docs.telerik.com/blazor-ui/components/chart/labels-template-and-format"">Label templates</a>
                    </li>
                </ul>
            </p>
        </div>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.CloseElement();
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
