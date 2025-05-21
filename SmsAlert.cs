using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    public class SmsAlert : IAlert
    {
        public void Alert(string number, string message)
        {
            Console.WriteLine($"Sending SMS: -{message}- to {number}");
        }
    }
}
