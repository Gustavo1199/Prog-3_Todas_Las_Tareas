#pragma checksum "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\Pages\Ejercicio7.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc87ef21cdd076d035595390eb2360bc201cc9c6"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\Pages\Ejercicio7.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\Pages\Ejercicio7.razor"
using TareaRealBase.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio7")]
    public partial class Ejercicio7 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ejercicio 4</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-dark");
            __builder.AddMarkupContent(3, "<thead><tr><th>\r\n                Cantidad \r\n            </th></tr></thead>\r\n\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 18 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\Pages\Ejercicio7.razor"
         foreach (var item in GetConsulta())
        {
            cantidadx += item.cantidad;
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 23 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\Pages\Ejercicio7.razor"
                  cantidadx

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Ernest Sanchez\desktop\tarea5\tarearealbase\Pages\Ejercicio7.razor"
           
   decimal cantidadx = 0;
    northwindContext get = new northwindContext();
    List<DataConsulta7> GetConsulta() => (from od in get.OrderDetails
                                            join o in get.Orders on od.OrderId equals o.Id
                                            group od by od.Quantity into r
                                            select new DataConsulta7 {
                                                cantidad = r.Key
                                            }).ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591