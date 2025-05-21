using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid_Principle
{
    internal class EmergencyHandler
    {
        private readonly ILogger _logger;
        private readonly IAlert _alert;

        public EmergencyHandler(ILogger logger, IAlert alert)
        {
            _logger = logger;
            _alert = alert;
        }       

        public void EmergencyShutdown()
        {
            Console.WriteLine("Emergency shutdown triggered!");
            _logger.Log("EMERGENCY OCCURRED");
            _alert.Alert("Emergency triggered", "benjy@email.com");
        }
    }
}
