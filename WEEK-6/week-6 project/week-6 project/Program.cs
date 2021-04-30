using System;

namespace week_6_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("uzunlugu daxil edin : 1,2,3 .......");
            rectangle.Uzunluq = int.Parse(Console.ReadLine());
            Console.WriteLine("en daxil edin :1,2,3 .......");
            rectangle.En = int.Parse(Console.ReadLine());

            if(rectangle.Uzunluq <=0 || rectangle.En <=0)
            {
                Console.WriteLine("Duzbucaqlinin sahesi  0 -di");
            }
            else
            {
                Console.WriteLine($"Duzbucaqlinin sahesi : {rectangle.Hasil}-dir");
            }
        }
    }
}
