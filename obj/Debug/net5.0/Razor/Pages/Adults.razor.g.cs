#pragma checksum "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea78427aa94bf2583b01ebf8e8b3568a00b7fee2"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
using Assignment1.Persistance;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>");
#nullable restore
#line 9 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
     if (adults == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
    }
    else if (!adults.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>No Adults items exist. Please add some.</em></p>");
#nullable restore
#line 20 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "id", "adultsTable");
            __builder.AddAttribute(5, "class", "table table-hover");
            __builder.AddMarkupContent(6, @"<thead class=""thead-light""><tr><th>Adult ID</th>
                <th>Name</th>
                <th>Age</th>
                <th>Sex</th>
                <th>Job title</th>
                <th>Salary</th>
                <th>Hair color</th>
                <th>Eye color</th>
                <th>Weight</th>
                <th>Height</th></tr></thead>
            ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 39 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
             foreach (var adult in adults)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 42 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 43 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 43 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                                               adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 44 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 45 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 46 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 47 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 48 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 49 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 50 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 51 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
                         adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\Adults.razor"
       
    private IList<Adult> adults;
    
    protected override async Task OnInitializedAsync()
    {
        adults = FileAdapter.GetAdults();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileAdapter FileAdapter { get; set; }
    }
}
#pragma warning restore 1591