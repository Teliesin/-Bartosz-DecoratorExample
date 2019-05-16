using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternExample
{
    public class CandelsDecorator : IDecorator
    {
        public IComponent Component { get; set; }

        public string DescribeYourself()
        {
           return string.Format("{0} {1}", Component.DescribeYourself(), "ze świeczkami");
        }
    }
}
