using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternExample
{
    public interface IDecorator : IComponent
    {
        IComponent Component { get; set; }
    }
}