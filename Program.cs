using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the implementations
            ILogger logger = new FileLogger();
            IAlert alert = new EmailAlert();

            // Inject dependencies into EmergencyHandler
            EmergencyHandler handler = new EmergencyHandler(logger, alert);

            // Invoke the Shutdown method
            handler.EmergencyShutdown();
        }
    }


}
