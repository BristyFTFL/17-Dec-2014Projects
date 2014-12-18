using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Item aItem1 = new Item();

            aItem1.name = "Product";
            aItem1.type = "IT";
            aItem1.unitPrice = "100";

            Item aItem2 = new Item();
            aItem2.name = "FTFL";
            aItem2.type = "Training";
            aItem2.unitPrice = "10000";

            string name = aItem1.name;
            string type = aItem1.type;
            string unitPrice = aItem1.unitPrice;

            string name1 = aItem2.name;
            string type1 = aItem2.type;
            string unitPrice1 = aItem2.unitPrice;

            Console.WriteLine(name +" "+type +" "+ unitPrice);
            Console.WriteLine(name1 + " " + type1 + " " + unitPrice1);
            Console.ReadLine();

        }
    }
}
