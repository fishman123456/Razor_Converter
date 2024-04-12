using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Converter.Pages
{
    [IgnoreAntiforgeryToken]
    public class ConverterModel : PageModel
    {
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
            // 1 “онна Ч 106(1 000 000) граммов, или 1000 килограммов.
            // 2 ÷ентнер Ч 105(100 000) граммов, или 100 килограммов.
            // 3  арат Ч 0,2 грамма.
            // 4 Ўекель = 14 г
            // 5 фунт Ч 453,59237 г(точное и официальное значение)

            // вычислени€ (по факту тут обращааемс€ к алгоритмам)
            Value = number;
           
            // полученный результат записываетс€ в модель представлени€
            Value2 = (number / 100000 );
            Value3 = (number / 0.2);
            Value4 = (number / 14);
            Value5 = (number / 453.59237);
        }
    }
}
