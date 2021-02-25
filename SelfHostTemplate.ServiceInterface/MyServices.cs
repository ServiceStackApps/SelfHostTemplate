using System;
using ServiceStack;
using SelfHostTemplate.ServiceModel;

namespace SelfHostTemplate.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
