using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternExample
{
    public class Cake : IComponent
    {
        public string DescribeYourself()
        {
            return "Ciastko";
        }
    }
}