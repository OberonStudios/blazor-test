#pragma checksum "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "492f54838e5d9a94bac11d0d7027a2b5e57ed253"
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
#line 7 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
 if (people == null)
{

#line default
#line hidden
            builder.AddContent(1, "    ");
            builder.AddMarkupContent(2, "<p><em>Loading data...</em></p>\n");
#line 10 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(3, "    ");
            builder.OpenElement(4, "table");
            builder.AddAttribute(5, "class", "table");
            builder.AddContent(6, "\n        ");
            builder.AddMarkupContent(7, "<thead>\n            <tr>\n                <th>ID</th>\n                <th>Name</th>\n                <th>Actions</th>\n            </tr>\n        </thead>\n        ");
            builder.OpenElement(8, "tbody");
            builder.AddContent(9, "\n");
#line 22 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
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
            builder.AddContent(18, "\n                    ");
            builder.OpenElement(19, "td");
            builder.OpenElement(20, "button");
            builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(()=>deletePerson(@person.id)));
            builder.AddContent(22, "Delete");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddContent(23, "\n                ");
            builder.CloseElement();
            builder.AddContent(24, "\n");
#line 29 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
            }

#line default
#line hidden
            builder.AddContent(25, "        ");
            builder.CloseElement();
            builder.AddContent(26, "\n    ");
            builder.CloseElement();
            builder.AddContent(27, "\n");
#line 32 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 34 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml"
            
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

    async void deletePerson(int delete_id)
    {
        var response = await Http.DeleteAsync("https://fxns-at-azure.azurewebsites.net/api/delete_data?id="+delete_id);

        if (response.IsSuccessStatusCode) {
            people = await Http.GetJsonAsync<Person[]>("https://fxns-at-azure.azurewebsites.net/api/get_data");
            this.StateHasChanged();
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591