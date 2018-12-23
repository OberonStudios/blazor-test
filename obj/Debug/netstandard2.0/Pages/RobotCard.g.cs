#pragma checksum "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/RobotCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5daf817b5647156024774a28f89b98c447aa3fe3"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/robot_details/{robot_name}/{robot_id}")]
    public class RobotCard : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h3>Your Robot</h3>\n");
            builder.OpenElement(1, "p");
            builder.OpenElement(2, "img");
            builder.AddAttribute(3, "class", "rounded-circle");
            builder.AddAttribute(4, "alt", "Generic placeholder image");
            builder.AddAttribute(5, "width", "400");
            builder.AddAttribute(6, "height", "400");
            builder.AddAttribute(7, "src", "https://robohash.org/" + (robot_id));
            builder.CloseElement();
            builder.CloseElement();
            builder.AddContent(8, "\n");
            builder.OpenElement(9, "h4");
            builder.AddContent(10, "Name: ");
            builder.AddContent(11, robot_name);
            builder.CloseElement();
            builder.AddContent(12, "\n");
            builder.AddMarkupContent(13, "<h5>Skills:</h5>\n\n");
            builder.AddMarkupContent(14, "<p><a class=\"btn btn-secondary btn-block\" href=\"/\" role=\"button\">Back</a></p>\n");
            builder.OpenElement(15, "p");
            builder.OpenElement(16, "button");
            builder.AddAttribute(17, "class", "btn btn-danger btn-block");
            builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(()=>deletePerson(@robot_id)));
            builder.AddAttribute(19, "role", "button");
            builder.AddContent(20, "Remove");
            builder.CloseElement();
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 14 "/home/aakatev/Documents/dotnet/BlazorApp1/Pages/RobotCard.cshtml"
            
    [Parameter]
    string robot_name { get; set; }
    [Parameter]
    string robot_id { get; set; }

    async void deletePerson(string delete_id)
    {
        var response = await Http.DeleteAsync("https://fxns-at-azure.azurewebsites.net/api/delete_data?id="+delete_id);

        if (response.IsSuccessStatusCode) {
            UriHelper.NavigateTo("/");
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591