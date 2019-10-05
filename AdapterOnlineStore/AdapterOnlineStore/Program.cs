using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOnlineStore
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget adapter = new VendorAdapter();
            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}
