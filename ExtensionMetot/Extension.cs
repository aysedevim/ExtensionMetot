using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMetot
{
    public static class Extension
    {
        public static string IlkHarfBuyuk(this string value) //this stringe ek özellik kazandırır.
        {
            return value.Substring(0,1).ToUpper()+value.Substring(1);
        }

        public static string AyAdi(this DateTime date)
        {
         
            int ay = date.Month;
            switch(ay)
            {
                case 1:
                    Console.WriteLine("OCAK");
                    break;
                case 2:
                    Console.WriteLine("ŞUBAT");
                    break;
                case 3:
                    Console.WriteLine("MART");
                    break;
                case 4:
                    Console.WriteLine("NİSAN");
                    break;
                case 5:
                    Console.WriteLine("MAYIS");
                    break;
                case 6:
                    Console.WriteLine("HAZİRAN");
                    break;
                case 7:
                    Console.WriteLine("TEMMUZ");
                    break;
                case 8:
                    Console.WriteLine("AĞUSTOS");
                    break;
                case 9:
                    Console.WriteLine("EYLÜL");
                    break;
                case 10:
                    Console.WriteLine("EKİM");
                    break;
                case 11:
                    Console.WriteLine("KASIM");
                    break;
                case 12:
                    Console.WriteLine("ARALIK");
                    break;

            }
            return ay.ToString();
        }
    }
}
