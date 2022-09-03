using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class zp
    {
        private double month_zp;
        public double year_zp
        {
            get { return month_zp * 12; }
            set { month_zp = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            zp a = new zp();
            Console.WriteLine("Расчет годовой зарплаты");
            Console.Write("Месячная зарплата: ");
            a.year_zp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nГодовая зарплата: " + a.year_zp);
            Console.ReadKey();
        }
    }
}
