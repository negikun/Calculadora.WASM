#pragma checksum "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38c86e19bdd5fc7563c356c22f68e30c9d1e67a7"
// <auto-generated/>
#pragma warning disable 1591
namespace Calculadora.WASM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using Calculadora.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\_Imports.razor"
using Calculadora.WASM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sign-form");
            __builder.OpenElement(2, "p");
            __builder.AddAttribute(3, "class", "welcome-text");
            __builder.AddContent(4, "Usuario - Hoy es ");
            __builder.AddContent(5, 
#nullable restore
#line 5 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                              Day

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, "!");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "Gender-Div");
            __builder.AddMarkupContent(10, "<p>Sexo: </p>\r\n        ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "Gender-select btn shadow-sm p-3 mb-5 bg-white rounded");
            __builder.AddAttribute(13, "style", "background-image:" + " url(" + (
#nullable restore
#line 8 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                            icon1

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddAttribute(14, "type", "submit");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                                                            MaleHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "Gender-select btn shadow-sm p-3 mb-5 bg-white rounded");
            __builder.AddAttribute(19, "style", "background-image:" + " url(" + (
#nullable restore
#line 9 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                            icon2

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddAttribute(20, "type", "submit");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                                                            FemaleHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "Gender-select btn shadow-sm p-3 mb-5 bg-white rounded");
            __builder.AddAttribute(25, "style", "background-image:" + " url(" + (
#nullable restore
#line 10 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                            icon3

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddAttribute(26, "type", "submit");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                                                            PregnantHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "number");
            __builder.AddAttribute(32, "class", "sign-input form-control");
            __builder.AddAttribute(33, "placeholder", "Edad");
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                           HandleUserAge

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "number");
            __builder.AddAttribute(38, "class", "sign-input form-control");
            __builder.AddAttribute(39, "placeholder", "Altura en mts");
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                    HandleUserHeight

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "number");
            __builder.AddAttribute(44, "class", "sign-input form-control");
            __builder.AddAttribute(45, "placeholder", "Peso en kgs");
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                  HandleUserWeight

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "Act-Div");
            __builder.AddMarkupContent(50, "<p>Actividad: </p>\r\n        ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "Act-btn btn shadow-sm p-0 mb-0 bg-white rounded-circle");
            __builder.AddAttribute(53, "type", "submit");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                       LAHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "10%");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "Act-btn btn shadow-sm p-0 mb-0  bg-white rounded-circle");
            __builder.AddAttribute(59, "type", "submit");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                        MAHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "15%");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "class", "Act-btn btn shadow-sm p-0 mb-0 bg-white rounded-circle");
            __builder.AddAttribute(65, "type", "submit");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                       HAHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "20%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "class", "signup btn rounded-pill border-success shadow p-3 mb-5 bg-white rounded ");
            __builder.AddAttribute(71, "type", "submit");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                                     ObtainData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "\r\n        Calcular\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "Act-Div");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "Image-Container");
            __builder.OpenElement(79, "img");
            __builder.AddAttribute(80, "class", "image-female");
            __builder.AddAttribute(81, "src", 
#nullable restore
#line 28 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                           img1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(82, "style", "opacity" + " :" + " " + (
#nullable restore
#line 28 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                  opacity1

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "img");
            __builder.AddAttribute(85, "class", "image-female");
            __builder.AddAttribute(86, "src", 
#nullable restore
#line 29 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                           img2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(87, "style", "opacity" + " :" + " " + (
#nullable restore
#line 29 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                  opacity2

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenElement(89, "img");
            __builder.AddAttribute(90, "class", "image-female");
            __builder.AddAttribute(91, "src", 
#nullable restore
#line 30 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                           img3

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(92, "style", "opacity" + " :" + " " + (
#nullable restore
#line 30 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                  opacity3

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenElement(94, "img");
            __builder.AddAttribute(95, "class", "image-female");
            __builder.AddAttribute(96, "src", 
#nullable restore
#line 31 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                           img4

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(97, "style", "opacity" + " :" + " " + (
#nullable restore
#line 31 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                  opacity4

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.OpenElement(99, "img");
            __builder.AddAttribute(100, "class", "image-female");
            __builder.AddAttribute(101, "src", 
#nullable restore
#line 32 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                           img5

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(102, "style", "opacity" + " :" + " " + (
#nullable restore
#line 32 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                  opacity5

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.OpenElement(104, "img");
            __builder.AddAttribute(105, "class", "image-female");
            __builder.AddAttribute(106, "src", 
#nullable restore
#line 33 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                           img6

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(107, "style", "opacity" + " :" + " " + (
#nullable restore
#line 33 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                  opacity6

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "Meter-container");
            __builder.AddMarkupContent(111, "<img class=\"Image-Meter\" src=\"/Images/Medidor.svg\">\r\n            ");
            __builder.OpenElement(112, "img");
            __builder.AddAttribute(113, "class", "arrow-meter");
            __builder.AddAttribute(114, "src", "/Images/Flecha.svg");
            __builder.AddAttribute(115, "style", "transform:" + " rotate(" + (
#nullable restore
#line 37 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                        deg

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n    ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "Act-Div");
            __builder.OpenElement(119, "section");
            __builder.AddAttribute(120, "class", "Data-Container");
            __builder.OpenElement(121, "p");
            __builder.AddAttribute(122, "class", "Data-Text");
            __builder.AddContent(123, "IMC: ");
            __builder.AddContent(124, 
#nullable restore
#line 42 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                       IMC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n            ");
            __builder.OpenElement(126, "p");
            __builder.AddAttribute(127, "class", "Data-Text");
            __builder.AddContent(128, "Peso teorico maximo: ");
            __builder.AddContent(129, 
#nullable restore
#line 43 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                       PTMax

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(130, " kg");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n            ");
            __builder.OpenElement(132, "p");
            __builder.AddAttribute(133, "class", "Data-Text");
            __builder.AddContent(134, "Peso teorico minimo: ");
            __builder.AddContent(135, 
#nullable restore
#line 44 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                       PTMin

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(136, " kg ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n            ");
            __builder.OpenElement(138, "p");
            __builder.AddAttribute(139, "class", "Data-Text");
            __builder.AddContent(140, "Peso ideal: ");
            __builder.AddContent(141, 
#nullable restore
#line 45 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                              PIdeal

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(142, " kg ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.OpenElement(144, "p");
            __builder.AddAttribute(145, "class", "Data-Text");
            __builder.AddContent(146, "GEB: ");
            __builder.AddContent(147, 
#nullable restore
#line 46 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                       Geb

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n            ");
            __builder.OpenElement(149, "p");
            __builder.AddAttribute(150, "class", "Data-Text");
            __builder.AddContent(151, "GET: ");
            __builder.AddContent(152, 
#nullable restore
#line 47 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                       Get

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n            ");
            __builder.OpenElement(154, "p");
            __builder.AddAttribute(155, "class", "Data-Text");
            __builder.AddContent(156, "Kcal para perdida de peso: ");
            __builder.AddContent(157, 
#nullable restore
#line 48 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                             Per

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(158, " kcal ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n            ");
            __builder.OpenElement(160, "p");
            __builder.AddAttribute(161, "class", "Data-Text");
            __builder.AddContent(162, "Proteina para aumento muscular: ");
            __builder.AddContent(163, 
#nullable restore
#line 49 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                  Mus

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(164, " gr ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
       
    private string Day { get; } = DateTime.Now.DayOfWeek.ToString();

    private int Edad { get; set; }

    private double Height { get; set; }

    private double Weight { get; set; }

    private double IMC { get; set; }

    private double PTMax { get; set; }

    private double PTMin { get; set; }

    private double PIdeal { get; set; }

    private double Geb { get; set; }

    private double Get { get; set; }

    private double Act { get; set; }

    private double Per { get; set; }

    private double Mus { get; set; }

    private int sex { get; set; } = 0;

    private string deg { get; set; } = "210deg";


    private string img1 { get; set; } = "/Images/Gray1.svg";
    private string img2 { get; set; } = "/Images/Gray2.svg";
    private string img3 { get; set; } = "/Images/Gray3.svg";
    private string img4 { get; set; } = "/Images/Gray4.svg";
    private string img5 { get; set; } = "/Images/Gray5.svg";
    private string img6 { get; set; } = "/Images/Gray6.svg";


    private string opacity1 { get; set; } = "20%";
    private string opacity2 { get; set; } = "20%";
    private string opacity3 { get; set; } = "20%";
    private string opacity4 { get; set; } = "20%";
    private string opacity5 { get; set; } = "20%";
    private string opacity6 { get; set; } = "20%";

    private string icon1 { get; set; } = "/Images/malegrayicon.svg";
    private string icon2 { get; set; } = "/Images/fGrayIcon.svg";
    private string icon3 { get; set; } = "/Images/PGrayIcon.svg";



    private void MaleHandler()
    {
        sex = 1;
        icon1 = "/Images/malegreenicon.svg";
        icon2 = "/Images/fGrayIcon.svg";
        icon3 = "/Images/PGrayIcon.svg";
        img1 = "/Images/desMale.svg";
        img2 = "/Images/normMale.svg";
        img3 = "/Images/sobrepesoMale.svg";
        img4 = "/Images/ob1Male.svg";
        img5 = "/Images/ob2Male.svg";
        img6 = "/Images/ob3Male.svg";
    }

    private void FemaleHandler()
    {
        sex = 2;
        icon1 = "/Images/malegrayicon.svg";
        icon2 = "/Images/fGreenicon.svg";
        icon3 = "/Images/PGrayIcon.svg";
        img1 = "/Images/Desnutricion.svg";
        img2 = "/Images/Normal.svg";
        img3 = "/Images/sobrepeso.svg";
        img4 = "/Images/obesidad 1.svg";
        img5 = "/Images/obesidad2.svg";
        img6 = "/Images/obesidad3.svg";
    }

    private void PregnantHandler()
    {
        sex = 3;
        icon1 = "/Images/malegrayicon.svg";
        icon2 = "/Images/fGrayIcon.svg";
        icon3 = "/Images/PPinkIcon.svg";
        img1 = "/Images/Desnutricion.svg";
        img2 = "/Images/Normal.svg";
        img3 = "/Images/sobrepeso.svg";
        img4 = "/Images/obesidad 1.svg";
        img5 = "/Images/obesidad2.svg";
        img6 = "/Images/obesidad3.svg";
    }

    private void HandleUserAge(ChangeEventArgs eventArgs)
    {
        Edad = Convert.ToInt32(eventArgs.Value);
    }

    private void HandleUserHeight(ChangeEventArgs eventArgs)
    {
        Height = Convert.ToDouble(eventArgs.Value);
    }

    private void HandleUserWeight(ChangeEventArgs eventArgs)
    {
        Weight = Convert.ToDouble(eventArgs.Value);
    }

    private void LAHandler()
    {
        Act = 0.1;
    }

    private void MAHandler()
    {
        Act = 0.15;
    }

    private void HAHandler()
    {
        Act = 0.2;
    }

    private void ObtainData()
    {

        double a;
        double b;
        double c;
        double d;
        double g;
        double get;
        double af;
        double eta;

        a = Weight / Math.Pow(Height, 2);
        b = Math.Pow(Height, 2) * 24.9;
        c = Math.Pow(Height, 2) * 18.5;
        d = (b + c) / 2;

        IMC = Math.Round(a, 2);
        PTMax = Math.Round(b, 2);
        PTMin = Math.Round(c, 2);
        PIdeal = Math.Round(d, 2);


        if (sex == 1)
        {

            if (IMC <= 25)
            {
                g = (66.5 + (13.75 * PTMax) + (5.003 * (Height * 100)) - (6.775 * Edad));
                Geb = Math.Round(g, 2);
                af = Geb * Act;
                eta = Geb * 0.1;
                get = (Geb + af + eta);
                Get = Math.Round(get, 2);
            }
            else
            {
                g = (66.5 + (13.75 * Weight) + (5.003 * (Height * 100)) - (6.775 * Edad));
                Geb = Math.Round(g, 2);
                af = Geb * Act;
                eta = Geb * 0.1;
                get = (Geb + af + eta);
                Get = Math.Round(get, 2);
            }
        }
        else if (sex == 2)
        {
            if (IMC <= 25)
            {
                g = (655.1 + (9.563 * PTMax) + (1.85 * (Height * 100)) - (4.676 * Edad));
                Geb = Math.Round(g, 2);
                af = Geb * Act;
                eta = Geb * 0.1;
                get = (Geb + af + eta);
                Get = Math.Round(get, 2);
            }
            else
            {
                g = (655.1 + (9.563 * Weight) + (1.85 * (Height * 100)) - (4.676 * Edad));
                Geb = Math.Round(g, 2);
                af = Geb * Act;
                eta = Geb * 0.1;
                get = (Geb + af + eta);
                Get = Math.Round(get, 2);
            }
        }
        else if (sex == 3)
        {
            if (IMC <= 25)
            {
                g = (655.1 + (9.563 * PTMax) + (1.85 * (Height * 100)) - (4.676 * Edad));
                Geb = Math.Round(g, 2);
                af = Geb * Act;
                eta = Geb * 0.1;
                get = (Geb + af + eta);
                Get = Math.Round(get, 2);
            }
            else
            {
                g = (655.1 + (9.563 * Weight) + (1.85 * (Height * 100)) - (4.676 * Edad));
                Geb = Math.Round(g, 2);
                af = Geb * Act;
                eta = Geb * 0.1;
                get = (Geb + af + eta);
                Get = Math.Round(get, 2);
            }
        }


        if (IMC < 18.5)
        {
            opacity1 = "100%";
            opacity2 = "20%";
            opacity3 = "20%";
            opacity4 = "20%";
            opacity5 = "20%";
            opacity6 = "20%";
            deg = "230deg";
            Per = 0.0;
            Mus = Geb + Weight;
        }
        else if (IMC > 18.5 && IMC < 24.9)
        {
            opacity1 = "20%";
            opacity2 = "100%";
            opacity3 = "20%";
            opacity4 = "20%";
            opacity5 = "20%";
            opacity6 = "20%";
            deg = "262deg";
            Per = 0.0;
            Mus = Geb + Weight;
        }
        else if (IMC > 25 && IMC < 29.9)
        {
            opacity1 = "20%";
            opacity2 = "20%";
            opacity3 = "100%";
            opacity4 = "20%";
            opacity5 = "20%";
            opacity6 = "20%";
            deg = "295deg";
            Per = Geb - 300;
            Mus = 0.0;
        }
        else if (IMC > 30 && IMC < 34.9)
        {
            opacity1 = "20%";
            opacity2 = "20%";
            opacity3 = "20%";
            opacity4 = "100%";
            opacity5 = "20%";
            opacity6 = "20%";
            deg = "325deg";
            Per = Geb - 300;
            Mus = 0.0;
        }
        else if (IMC > 35 && IMC < 39.9)
        {
            opacity1 = "20%";
            opacity2 = "20%";
            opacity3 = "20%";
            opacity4 = "20%";
            opacity5 = "100%";
            opacity6 = "20%";
            deg = "355deg";
            Per = Geb - 300;
            Mus = 0.0;
        }
        else if (IMC > 40)
        {
            opacity1 = "20%";
            opacity2 = "20%";
            opacity3 = "20%";
            opacity4 = "20%";
            opacity5 = "20%";
            opacity6 = "100%";
            deg = "385deg";
            Per = Geb - 300;
            Mus = 0.0;
        }
        else
        {
            opacity1 = "20%";
            opacity2 = "20%";
            opacity3 = "20%";
            opacity4 = "20%";
            opacity5 = "20%";
            opacity6 = "20%";
            deg = "210deg";
        }


    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591