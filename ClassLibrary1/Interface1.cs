
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ClassLibrary1
{
    [ServiceContract]
    public interface Interface1
    {
        [OperationContract]
        [WebGet]
        string GetMessage(string inputMessage);
        [OperationContract]
        [WebInvoke]
        string PostMessage(string inputMessage);

    }
}
