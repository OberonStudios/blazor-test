#pragma checksum "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee30322ffe2c5088745af43263281a85f5d3233b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using BlazorApp1;
    using BlazorApp1.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>People</h1>\n\n");
#line 6 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
 if (people == null)
{

#line default
#line hidden
            builder.AddContent(1, "    ");
            builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\n");
#line 9 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(3, "    ");
            builder.OpenElement(4, "table");
            builder.AddAttribute(5, "class", "table");
            builder.AddContent(6, "\n        ");
            builder.AddMarkupContent(7, "<thead>\n            <tr>\n                <th>ID</th>\n                <th>Name</th>\n            </tr>\n        </thead>\n        ");
            builder.OpenElement(8, "tbody");
            builder.AddContent(9, "\n");
#line 20 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
             foreach (var person in people)
            {

#line default
#line hidden
            builder.AddContent(10, "                ");
            builder.OpenElement(11, "tr");
            builder.AddContent(12, "\n                    ");
            builder.OpenElement(13, "td");
            builder.AddContent(14, person.id);
            builder.CloseElement();
            builder.AddContent(15, "\n                    ");
            builder.OpenElement(16, "td");
            builder.AddContent(17, person.name);
            builder.CloseElement();
            builder.AddContent(18, "\n                ");
            builder.CloseElement();
            builder.AddContent(19, "\n");
#line 26 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
            }

#line default
#line hidden
            builder.AddContent(20, "        ");
            builder.CloseElement();
            builder.AddContent(21, "\n    ");
            builder.CloseElement();
            builder.AddContent(22, "\n");
#line 29 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 31 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
            
    Person[] people;

    protected override async Task OnInitAsync()
    {
        people = await Http.GetJsonAsync<Person[]>("https://fxns-at-azure.azurewebsites.net/api/get_data");
    }

    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591