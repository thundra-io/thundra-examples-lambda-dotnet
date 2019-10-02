using Amazon.Lambda.Core;
using Thundra.Agent.Lambda.Core;

namespace ThundraSample
{
    public class Function
    {
        public string MyEntryPoint(string request, ILambdaContext context)
        {
            return "Hello Thundra Proxy";
        }
    }
}