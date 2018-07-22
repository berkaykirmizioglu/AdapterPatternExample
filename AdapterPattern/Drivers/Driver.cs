using AdapterPattern.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Drivers
{
    class Driver : IDriver
    {
        private ChromeDriver _chromeDriver;

        public Driver(ChromeDriver chromeDriver)
        {
            _chromeDriver = chromeDriver;
        }

        public void Request()
        {
            _chromeDriver.SpecificRequest();
        }
    }
}
