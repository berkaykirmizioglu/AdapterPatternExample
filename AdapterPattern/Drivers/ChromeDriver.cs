using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Drivers
{
    class ChromeDriver
    {
        public void SpecificRequest()
        {
            Console.WriteLine("You are in ChromeDriver request");
        }
    }
}
