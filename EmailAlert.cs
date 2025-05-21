using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class EmailAlert : IAlert
    {
        public void Alert(string message, string to)
        {
            Console.WriteLine($"sending message -{message}- to {to}.");
        }
    }
}
