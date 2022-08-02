using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Base
{
    public class Client
    {
        public void ClientCode(IComponent component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
