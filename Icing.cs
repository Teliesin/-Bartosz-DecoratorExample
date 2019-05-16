using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternExample
{
    public class IcingDecorator : IDecorator
    {
        public IComponent Component { get; set; }

        public string DescribeYourself()
        {
            return String.Format("{0} {1}", Component.DescribeYourself(), "i z polewą");
        }
    }
}
