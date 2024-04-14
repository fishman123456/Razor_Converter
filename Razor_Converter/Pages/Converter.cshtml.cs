using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Converter.Pages
{
    [IgnoreAntiforgeryToken]


    public class ConverterModel : PageModel
    {
        [BindProperty]
        public string numberSel { get; set; } = "Грамм";
        [BindProperty]
        public double numberInt { get; set; } = 0.00;
        public double Value { get; private set; }
        public double Value2 { get; private set; }
        public double Value3 { get; private set; }
        public double Value4 { get; private set; }
        public double Value5 { get; private set; }


        public void OnGet()
        {
            //Value = 0;
        }

        public void OnPost(double number)
        {
            // 1 Тонна — 106(1 000 000) граммов, или 1000 килограммов.
            // 2 Центнер — 105(100 000) граммов, или 100 килограммов.
            // 3 Карат — 0,2 грамма.
            // 4 Шекель = 14 г
            // 5 фунт — 453,59237 г(точное и официальное значение)


            // вычисления (по факту тут обращааемся к алгоритмам)
            Value = number;
            if (numberSel == "Тонна")
            {
                //Value = number;
                Value2 = (number * 10);
                Value3 = (number / 0.0000002);
                Value4 = (number / 0.000014);
                Value5 = (number / 0.000453);
            }
            else if (numberSel == "Центнер")
            {
                Value = (number / 10);
                Value2 = (number);
                Value3 = (number * 500000);
                Value4 = (number * 7142.85);
                Value5 = (number * 220.7);
            }
            else if (numberSel == "Карат")
            {
                Value = (number / 5000000);
                Value2 = (number / 500000);
                Value3 = (number);
                Value4 = (number / 70);
                Value5 = (number / 2267.96185);
            }
            else if (numberSel == "Шекель")
            {
                Value = (number / 71.428571);
                Value2 = (number / 714.28571);
                Value3 = (number * 70);
                Value4 = (number);
                Value5 = (number * 0.0308647167058829);
            }
            else if (numberSel == "Фунт")
            {
                Value = (number * 0.000453);
                Value2 = (number * 0.00453);
                Value3 = (number * 2265);
                Value4 = (number * 32.399);
                Value5 = (number);
            }
            else
            {
                // по умолчанию граммы
                Value = (number / 1000000);
                Value2 = (number / 100000);
                Value3 = (number / 0.2);
                Value4 = (number / 14);
                Value5 = (number / 453.59237);
                numberSel = "Грамм";
            }
            numberInt = number;
        }
    }
}
