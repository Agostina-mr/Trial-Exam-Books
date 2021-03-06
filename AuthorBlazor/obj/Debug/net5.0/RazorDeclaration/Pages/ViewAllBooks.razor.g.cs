// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\ViewAllBooks.razor"
using AuthorBlazor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\ViewAllBooks.razor"
using AuthorBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\ViewAllBooks.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAllBooks")]
    public partial class ViewAllBooks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorBlazor\Pages\ViewAllBooks.razor"
       
    private List<Author> _authors = new List<Author>();
    private List<Author> _authorsToDisplay = new List<Author>();
    
    protected override async Task OnInitializedAsync()
    {
        _authors = await _authorServices.GetAllAuthors();
        _authorsToDisplay = _authors;

    }

    private async Task RemoveBook(int bookIsbn)
    {
        await _authorServices.RemoveBook(bookIsbn);
        _authors = await _authorServices.GetAllAuthors();

    }

    private void FilterByAuthor(ChangeEventArgs lastName)
    {
        _authorsToDisplay = _authors.Where(a => a.LastName == (string) lastName.Value).ToList();
    }
    
    private void FilterByTitle(ChangeEventArgs title)
    {
        _authorsToDisplay = _authors.FindAll(a => a.Books.Exists(b =>
        {
            Debug.Assert(title.Value != null, "title.Value != null");
            return b.Title.Equals(title.Value.ToString());
        }));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthorServices _authorServices { get; set; }
    }
}
#pragma warning restore 1591
