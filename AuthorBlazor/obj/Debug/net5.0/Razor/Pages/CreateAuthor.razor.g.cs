#pragma checksum "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\CreateAuthor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bcec41fb64095383b33b0355b1a2d777ac2ddd0"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthorBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using AuthorBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\_Imports.razor"
using AuthorBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\CreateAuthor.razor"
using AuthorBlazor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\CreateAuthor.razor"
using AuthorBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateAuthor")]
    public partial class CreateAuthor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateAuthor</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\CreateAuthor.razor"
                 newAuthor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\CreateAuthor.razor"
                                           NewAuthor

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.AddMarkupContent(7, "\r\n        First Name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\CreateAuthor.razor"
                                newAuthor.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAuthor.FirstName = __value, newAuthor.FirstName))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAuthor.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\r\n        Last Name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\CreateAuthor.razor"
                                newAuthor.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAuthor.LastName = __value, newAuthor.LastName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAuthor.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.AddMarkupContent(21, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\"> Create</button></p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "p");
            __builder.AddContent(24, "Author Id : ");
            __builder.AddContent(25, 
#nullable restore
#line 20 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\CreateAuthor.razor"
                newAuthor.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\CreateAuthor.razor"
       
    private Author newAuthor = new Author();

    private async Task NewAuthor()
    {
        newAuthor = await authorServices.PostAuthor(newAuthor);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthorServices authorServices { get; set; }
    }
}
#pragma warning restore 1591
