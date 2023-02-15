using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OCCTProxy proxy = new OCCTProxy();
            proxy.InitOCCTProxy();
            var obj1 = proxy.AddWireDraft(40);
            var l = proxy.IteratePoly(obj1);
            foreach (var item in l)
            {
                System.Console.WriteLine($"{item.X} {item.Y} {item.Z}");
            }
        }
    }
}
