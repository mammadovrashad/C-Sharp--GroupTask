using System;

namespace dogum_tarixi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 6. yas hesablanmasi
            /*
             * dogum tarixini daxil eden istifedecinin
             * yasini hesablayib ekrana cap edin
             */
            #endregion
            #region
            Console.WriteLine("dogum tarixinizi daxil edin: { gun/ay/il } meselen:   15/10/2001     seklinde daxil edin");
            string arrayElement = Console.ReadLine();
            var Array = arrayElement.Split("/");
            int il = DateTime.Now.Year;
            double age = il - int.Parse(Array[2]);
            Console.WriteLine($"sizin hazirki yasiniz {age} ");
            #endregion

        }
    }
}
