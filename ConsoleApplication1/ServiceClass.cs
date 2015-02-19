using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class ServiceClass : Interface1
    {
        public string GetMessage(string inputMessage)
        {
            return "Calling Get for you " + inputMessage;
        }
        public string PostMessage(string inputMessage)
        {
            return "Calling Post for you " + inputMessage;
        }
    }
}
