// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TareaRealBase.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using TareaRealBase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\_Imports.razor"
using TareaRealBase.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\Pages\Ejercicio5.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\Pages\Ejercicio5.razor"
using TareaRealBase.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio5")]
    public partial class Ejercicio5 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\Pages\Ejercicio5.razor"
       
  northwindContext postContext = new northwindContext();
  List<DataConsulta5> GetConsulta5() => (from p in postContext.Products
                                          join o in postContext.OrderDetails
                                          on p.Id equals o.ProductId
                                          orderby o.Quantity descending
                                          select new DataConsulta5{
                                            producto = p.ProductName,
                                            cantidad = o.Quantity
                                          }).ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
