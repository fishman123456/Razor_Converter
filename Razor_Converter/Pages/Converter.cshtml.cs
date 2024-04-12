using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Converter.Pages
{
    [IgnoreAntiforgeryToken]
   
    
    public class ConverterModel : PageModel
    {
        [BindProperty]
        public string numberSel { get; set; } = "�����";
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
            // 1 ����� � 106(1 000 000) �������, ��� 1000 �����������.
            // 2 ������� � 105(100 000) �������, ��� 100 �����������.
            // 3 ����� � 0,2 ������.
            // 4 ������ = 14 �
            // 5 ���� � 453,59237 �(������ � ����������� ��������)
            
           
            // ���������� (�� ����� ��� ����������� � ����������)
            Value = number;
           if(numberSel == "�����")
            {
                Value2 = (number / 10);
                Value3 = (number / 0.0000002);
                Value4 = (number / 0.000014);
                Value5 = (number / 0.0000453);
            }
            else { 
            // ���������� ��������� ������������ � ������ �������������
            Value2 = (number / 100000 );
            Value3 = (number / 0.2);
            Value4 = (number / 14);
            Value5 = (number / 453.59237);
            }
        }
    }
}
