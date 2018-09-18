using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace ConsoleApp2_0
{
    internal class ClientUserAgentMessage : IClientMessageInspector
    {
        public ClientUserAgentMessage() { }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            //throw new System.NotImplementedException();
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            HttpRequestMessageProperty property = new HttpRequestMessageProperty();

            //This is an example user agent that fails, and we would not expect it to.
            property.Headers["User-Agent"] = "Mozilla /4.0 (compatible; MSIE 6.0; MS Web Services Client Protocol 4.0.30319.42000)";
            request.Properties.Add(HttpRequestMessageProperty.Name, property);

            return null;
        }
    }
}
