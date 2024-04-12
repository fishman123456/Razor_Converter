using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Converter.Pages
{
    [IgnoreAntiforgeryToken]
   
    
    public class ConverterModel : PageModel
    {
        [BindProperty]
        public string numberSel { get; set; } = "Тонна";
        public double Value { get; private set; }
        public double Value2 { get; private set; }
        public double Value3 { get; private set; }
        public double Value4 { get; private set; }
        public double Value5 { get; private set; }

        
        public void OnGet()
        {
            //Value = 0;
        }
        
        public void OnPost(double number, double number2, double number3, double number4)
        {
            // 1 Тонна — 106(1 000 000) граммов, или 1000 килограммов.
            // 2 Центнер — 105(100 000) граммов, или 100 килограммов.
            // 3 Карат — 0,2 грамма.
            // 4 Шекель = 14 г
            // 5 фунт — 453,59237 г(точное и официальное значение)
            
           
            // вычисления (по факту тут обращааемся к алгоритмам)
            Value = number;
           if(numberSel == "Тонна")
            {
                Value2 = (number / 10);
                Value3 = (number / 0.0000002);
                Value4 = (number / 0.000014);
                Value5 = (number / 0.0000453);
            }
            else { 
            // полученный результат записывается в модель представления
            Value2 = (number / 100000 );
            Value3 = (number / 0.2);
            Value4 = (number / 14);
            Value5 = (number / 453.59237);
            }
        }
    }
}
