using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent ciastko = new Cake();

            CandelsDecorator swieczki = new CandelsDecorator();
            swieczki.Component = ciastko;
            ciastko = swieczki;

            IcingDecorator polewa = new IcingDecorator();
            polewa.Component = ciastko;
            ciastko = polewa;

            Console.WriteLine(ciastko.DescribeYourself());

            Console.ReadKey();
        }
    }
}
