using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace ConsoleApp2_0
{
    internal class UserAgentEndpointBehavior : IEndpointBehavior
    {
        public UserAgentEndpointBehavior() { }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            //throw new System.NotImplementedException();
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.ClientMessageInspectors.Add(new ClientUserAgentMessage());
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            //throw new System.NotImplementedException();
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            //throw new System.NotImplementedException();
        }
    }
}
