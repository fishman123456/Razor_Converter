using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Converter.Pages
{
    [IgnoreAntiforgeryToken]


    public class ConverterModel : PageModel
    {
        [BindProperty]
        public string numberSel { get; set; } = "�����";
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
            // 1 ����� � 106(1 000 000) �������, ��� 1000 �����������.
            // 2 ������� � 105(100 000) �������, ��� 100 �����������.
            // 3 ����� � 0,2 ������.
            // 4 ������ = 14 �
            // 5 ���� � 453,59237 �(������ � ����������� ��������)


            // ���������� (�� ����� ��� ����������� � ����������)
            Value = number;
            if (numberSel == "�����")
            {
                //Value = number;
                Value2 = (number * 10);
                Value3 = (number / 0.0000002);
                Value4 = (number / 0.000014);
                Value5 = (number / 0.000453);
            }
            else if (numberSel == "�������")
            {
                Value = (number / 10);
                Value2 = (number);
                Value3 = (number * 500000);
                Value4 = (number * 7142.85);
                Value5 = (number * 220.7);
            }
            else if (numberSel == "�����")
            {
                Value = (number / 5000000);
                Value2 = (number / 500000);
                Value3 = (number);
                Value4 = (number / 70);
                Value5 = (number / 2267.96185);
            }
            else if (numberSel == "������")
            {
                Value = (number / 71.428571);
                Value2 = (number / 714.28571);
                Value3 = (number * 70);
                Value4 = (number);
                Value5 = (number * 0.0308647167058829);
            }
            else if (numberSel == "����")
            {
                Value = (number * 0.000453);
                Value2 = (number * 0.00453);
                Value3 = (number * 2265);
                Value4 = (number * 32.399);
                Value5 = (number);
            }
            else
            {
                // �� ��������� ������
                Value = (number / 1000000);
                Value2 = (number / 100000);
                Value3 = (number / 0.2);
                Value4 = (number / 14);
                Value5 = (number / 453.59237);
                numberSel = "�����";
            }
            numberInt = number;
        }
    }
}
