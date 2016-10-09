using EntityFramework_CodeFirst_Manual.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Manual
{
    class Program
    {
        static void Main(string[] args)
        {
            LunchBoxModel db = new LunchBoxModel();
            int count = db.Product.Count();

            Console.WriteLine("Table Count: " + count);
            Console.ReadKey();
        }
    }
}
