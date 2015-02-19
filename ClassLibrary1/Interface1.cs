
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
        [WebGet(UriTemplate = "GetMessage/{inputMessage}", ResponseFormat = WebMessageFormat.Json)]
        string GetMessage(string inputMessage);
        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "PostMessage/{inputMessage}", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        string PostMessage(string inputMessage);

    }
}
