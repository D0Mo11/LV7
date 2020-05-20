using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treci_Cetvrti
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider provider = new SystemDataProvider();
            FileLogger fileLogger1 = new FileLogger("log1.txt");
            FileLogger fileLogger2 = new FileLogger("log2.txt");
            ConsoleLogger consoleLogger = new ConsoleLogger();
            provider.Attach(consoleLogger);
            provider.Attach(fileLogger1);
            provider.Attach(fileLogger2);

            while(1<2)
            {
                provider.GetAvailableRAM();
                provider.GetCPULoad();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
