#pragma checksum "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40f72e279bd618c2d88d533c1ccbccf38f6a3a1e"
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
#line 2 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
using Assignment1.Persistance;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Adult</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                  newAdultItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                                AddNewAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, " Adult Id: <br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdult.TypeInference.CreateInputNumber_0(__builder2, 12, 13, 
#nullable restore
#line 14 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                  newAdultItem.Id

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Id = __value, newAdultItem.Id)), 15, () => newAdultItem.Id);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n        First Name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                newAdultItem.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.FirstName = __value, newAdultItem.FirstName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n        Last Name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                newAdultItem.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.LastName = __value, newAdultItem.LastName))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "\r\n        Age:<br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdult.TypeInference.CreateInputNumber_1(__builder2, 36, 37, 
#nullable restore
#line 26 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                  newAdultItem.Age

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Age = __value, newAdultItem.Age)), 39, () => newAdultItem.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n        Sex:<br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdult.TypeInference.CreateInputRadioGroup_2(__builder2, 44, 45, 
#nullable restore
#line 30 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                      newAdultItem.Sex

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Sex = __value, newAdultItem.Sex)), 47, () => newAdultItem.Sex, 48, (__builder3) => {
#nullable restore
#line 31 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
             foreach (var sex in Sex)
            {

#line default
#line hidden
#nullable disable
                    __Blazor.Assignment1.Pages.AddAdult.TypeInference.CreateInputRadio_3(__builder3, 49, 50, 
#nullable restore
#line 33 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                   sex

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(51, 
#nullable restore
#line 33 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                           sex

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 33 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                              
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(52, "<br>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "\r\n        Job title:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                newAdultJob.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultJob.JobTitle = __value, newAdultJob.JobTitle))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultJob.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "\r\n        Salary:<br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdult.TypeInference.CreateInputNumber_4(__builder2, 65, 66, 
#nullable restore
#line 44 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                  newAdultJob.Salary

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultJob.Salary = __value, newAdultJob.Salary)), 68, () => newAdultJob.Salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "\r\n        Hair color:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(73);
                __builder2.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                newAdultItem.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.HairColor = __value, newAdultItem.HairColor))));
                __builder2.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group");
                __builder2.AddMarkupContent(80, "\r\n        Eye color:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(81);
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                newAdultItem.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.EyeColor = __value, newAdultItem.EyeColor))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "\r\n        Weight:<br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdult.TypeInference.CreateInputNumber_5(__builder2, 89, 90, 
#nullable restore
#line 56 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                  newAdultItem.Weight

#line default
#line hidden
#nullable disable
                , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Weight = __value, newAdultItem.Weight)), 92, () => newAdultItem.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n    ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group");
                __builder2.AddMarkupContent(96, "\r\n        Height:<br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdult.TypeInference.CreateInputNumber_6(__builder2, 97, 98, 
#nullable restore
#line 60 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
                                  newAdultItem.Height

#line default
#line hidden
#nullable disable
                , 99, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Height = __value, newAdultItem.Height)), 100, () => newAdultItem.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.AddMarkupContent(102, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Create</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\STUDIA\3.1\DNP\Assignments\Assignment1\Pages\AddAdult.razor"
 
    public Adult newAdultItem = new Adult();
    public Job newAdultJob = new Job();
    List<char> Sex = new List<char> {'F', 'M'};

    private void AddNewAdult()
    {
        newAdultItem.JobTitle = newAdultJob;
        FileAdapter.AddAdult(newAdultItem);
        NavigationManager.NavigateTo("/Adults");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileAdapter FileAdapter { get; set; }
    }
}
namespace __Blazor.Assignment1.Pages.AddAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputRadioGroup_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
