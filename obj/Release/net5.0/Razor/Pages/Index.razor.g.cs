#pragma checksum "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6fff74d326a7084ecded17962d4ea0f5fad5e5"
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
            __builder.AddMarkupContent(2, "<div class=\"logo-div\"><img class=\"logo-icon\" src=\".\\logo webapp.svg\"></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "Gender-Div");
            __builder.AddMarkupContent(5, "<p>Sexo: </p>\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "Gender-select btn shadow-sm p-3 mb-5 bg-white rounded");
            __builder.AddAttribute(8, "style", "background-image:" + " url(" + (
#nullable restore
#line 10 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                            icon1

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddAttribute(9, "type", "submit");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                                                            MaleHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "Gender-select btn shadow-sm p-3 mb-5 bg-white rounded");
            __builder.AddAttribute(14, "style", "background-image:" + " url(" + (
#nullable restore
#line 11 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                            icon2

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddAttribute(15, "type", "submit");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                                                            FemaleHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "Gender-select btn shadow-sm p-3 mb-5 bg-white rounded");
            __builder.AddAttribute(20, "style", "background-image:" + " url(" + (
#nullable restore
#line 12 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                            icon3

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddAttribute(21, "type", "submit");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                                                            PregnantHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "number");
            __builder.AddAttribute(27, "class", "sign-input form-control");
            __builder.AddAttribute(28, "placeholder", "Edad");
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                           HandleUserAge

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "number");
            __builder.AddAttribute(33, "class", "sign-input form-control");
            __builder.AddAttribute(34, "placeholder", "Altura en mts");
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                    HandleUserHeight

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "number");
            __builder.AddAttribute(39, "class", "sign-input form-control");
            __builder.AddAttribute(40, "placeholder", "Peso en kgs");
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                  HandleUserWeight

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "Act-Div");
            __builder.AddMarkupContent(45, "<p>Actividad: </p>\r\n        ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "Act-btn btn shadow-sm p-0 mb-0 bg-white rounded-circle");
            __builder.AddAttribute(48, "type", "submit");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                       LAHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "10%");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "Act-btn btn shadow-sm p-0 mb-0  bg-white rounded-circle");
            __builder.AddAttribute(54, "type", "submit");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                        MAHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "15%");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "Act-btn btn shadow-sm p-0 mb-0 bg-white rounded-circle");
            __builder.AddAttribute(60, "type", "submit");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                       HAHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "20%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "signup btn rounded-pill border-success shadow p-3 mb-5 bg-white rounded ");
            __builder.AddAttribute(66, "type", "submit");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                                     ObtainData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "\r\n        Calcular\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "Act-Div");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "Image-Container");
            __builder.OpenElement(74, "img");
            __builder.AddAttribute(75, "class", "image-female img-fluid");
            __builder.AddAttribute(76, "src", 
#nullable restore
#line 30 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                     img1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(77, "style", "opacity" + " :" + " " + (
#nullable restore
#line 30 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                            opacity1

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "img");
            __builder.AddAttribute(80, "class", "image-female img-fluid");
            __builder.AddAttribute(81, "src", 
#nullable restore
#line 31 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                     img2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(82, "style", "opacity" + " :" + " " + (
#nullable restore
#line 31 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                            opacity2

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "img");
            __builder.AddAttribute(85, "class", "image-female img-fluid");
            __builder.AddAttribute(86, "src", 
#nullable restore
#line 32 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                     img3

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(87, "style", "opacity" + " :" + " " + (
#nullable restore
#line 32 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                            opacity3

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenElement(89, "img");
            __builder.AddAttribute(90, "class", "image-female img-fluid");
            __builder.AddAttribute(91, "src", 
#nullable restore
#line 33 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                     img4

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(92, "style", "opacity" + " :" + " " + (
#nullable restore
#line 33 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                            opacity4

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenElement(94, "img");
            __builder.AddAttribute(95, "class", "image-female img-fluid");
            __builder.AddAttribute(96, "src", 
#nullable restore
#line 34 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                     img5

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(97, "style", "opacity" + " :" + " " + (
#nullable restore
#line 34 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                            opacity5

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.OpenElement(99, "img");
            __builder.AddAttribute(100, "class", "image-female img-fluid");
            __builder.AddAttribute(101, "src", 
#nullable restore
#line 35 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                     img6

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(102, "style", "opacity" + " :" + " " + (
#nullable restore
#line 35 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                            opacity6

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n        ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "Meter-container ");
            __builder.AddMarkupContent(106, "<img class=\"Image-Meter img-fluid\" src=\"/Images/Medidor.svg\">\r\n            ");
            __builder.OpenElement(107, "img");
            __builder.AddAttribute(108, "class", "arrow-meter img-fluid");
            __builder.AddAttribute(109, "src", "/Images/Flecha.svg");
            __builder.AddAttribute(110, "style", "transform:" + " rotate(" + (
#nullable restore
#line 39 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                                                  deg

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n    ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "Act-Div");
            __builder.OpenElement(114, "section");
            __builder.AddAttribute(115, "class", "Data-Container");
            __builder.OpenElement(116, "p");
            __builder.AddAttribute(117, "class", "Data-Text");
            __builder.AddContent(118, "IMC: ");
            __builder.AddContent(119, 
#nullable restore
#line 44 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                       IMC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n            ");
            __builder.OpenElement(121, "p");
            __builder.AddAttribute(122, "class", "Data-Text");
            __builder.AddContent(123, "Peso teorico maximo: ");
            __builder.AddContent(124, 
#nullable restore
#line 45 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                       PTMax

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(125, " kg");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.OpenElement(127, "p");
            __builder.AddAttribute(128, "class", "Data-Text");
            __builder.AddContent(129, "Peso teorico minimo: ");
            __builder.AddContent(130, 
#nullable restore
#line 46 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                       PTMin

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(131, " kg ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n            ");
            __builder.OpenElement(133, "p");
            __builder.AddAttribute(134, "class", "Data-Text");
            __builder.AddContent(135, "Peso ideal: ");
            __builder.AddContent(136, 
#nullable restore
#line 47 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                              PIdeal

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(137, " kg ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n            ");
            __builder.OpenElement(139, "p");
            __builder.AddAttribute(140, "class", "Data-Text");
            __builder.AddContent(141, "GEB: ");
            __builder.AddContent(142, 
#nullable restore
#line 48 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                       Geb

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.OpenElement(144, "p");
            __builder.AddAttribute(145, "class", "Data-Text");
            __builder.AddContent(146, "GET: ");
            __builder.AddContent(147, 
#nullable restore
#line 49 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                       Get

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n            ");
            __builder.OpenElement(149, "p");
            __builder.AddAttribute(150, "class", "Data-Text");
            __builder.AddContent(151, "Kcal para perdida de peso: ");
            __builder.AddContent(152, 
#nullable restore
#line 50 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                             Per

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(153, " kcal ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n            ");
            __builder.OpenElement(155, "p");
            __builder.AddAttribute(156, "class", "Data-Text");
            __builder.AddContent(157, "Proteina para aumento muscular: ");
            __builder.AddContent(158, 
#nullable restore
#line 51 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
                                                                  Mus

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(159, " gr ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\Index.razor"
       
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
