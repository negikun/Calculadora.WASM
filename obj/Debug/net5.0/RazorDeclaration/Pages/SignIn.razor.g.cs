// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Calculadora")]
    public partial class SignIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\pc\source\repos\Calculadora.WASM\Calculadora.WASM\Pages\SignIn.razor"
       
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
        Edad = Convert.ToInt32(eventArgs.Value)  ;
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

        double  a;
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
        d = (b  + c) / 2;

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
        else if (IMC > 18.5  && IMC < 24.9)
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
        else if (IMC > 40 )
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
