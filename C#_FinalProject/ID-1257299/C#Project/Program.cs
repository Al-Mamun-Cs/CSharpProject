using ConPJ1.MyApp;
using ConPJ1.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory.SelectedPackage = Packages.Product;
            IMyApps app = Factory.GetApp();

            app.ReadMenuSelection();

            Console.ReadLine();
        }
    }
}
