using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Thundra.Agent.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace ThundraSample
{
    public class Function : LambdaRequestHandler<string, string>
    {

        /// <summary>
        /// Handler class needs to extend `LambdaRequestHandler< Request, Response >`
        /// Please write all code within the DoHandleRequest method
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns>/Greeting Message/</returns>
        public override string DoHandleRequest(string request, ILambdaContext context)
        {
            return "Hello Thundra";
        }
    }
}