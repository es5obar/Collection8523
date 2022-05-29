using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling8523
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] isimler = new string[2];
                isimler[0] = "Çağıl";
                isimler[1] = "Leo";
                isimler[2] = "Muhittin";
            }
            catch 
            {
                Console.WriteLine("Upsss ! Hata oldu !");
            }
            try
            {
                string[] isimler = new string[2];
                isimler[0] = "Çağıl";
                isimler[1] = "Leo";
                isimler[2] = "Muhittin";
            }
            catch (Exception exc)
            {
                Console.WriteLine("Upsss ! Hata oldu !" + exc.Message);
            }
            finally
            {
                Console.WriteLine("Finally çalıştı");
            }
            Console.ReadLine();
        }
    }
}
