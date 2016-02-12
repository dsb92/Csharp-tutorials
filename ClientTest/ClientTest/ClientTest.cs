using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientTest
{
    class ClientTest
    {
        static void Main(string[] args)
        {
            COMServerTest.clsCOMserverTest MinCOMServer;
            MinCOMServer = new COMServerTest.clsCOMServerTest();

            //Box værdien
            string MinStr = "Hej fra C#";
            object o = MinStr;

            MinCOMServer.VisBesked(ref o);
        }
    }
}
