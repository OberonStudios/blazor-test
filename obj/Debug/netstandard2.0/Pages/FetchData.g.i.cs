#pragma checksum "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "492f54838e5d9a94bac11d0d7027a2b5e57ed253"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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