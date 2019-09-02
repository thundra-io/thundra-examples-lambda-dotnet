using System;
using System.Collections.Generic;
using Amazon.Lambda.Core;
using Thundra.Agent.Lambda.Config;
using Thundra.Agent.Lambda.Core;
using Thundra.Agent.Lambda.Sample;

namespace ThundraSamplingExample
{
    public class Function : LambdaRequestHandler<string, string>
    {
        public Function()
        {
            ThundraConfig config = ThundraConfigProvider.GetThundraConfig();
            config.LogConfig.Sampler = new ErrorAwareSampler();
            config.TraceConfig.Sampler = new DurationAwareSampler(5000, true);            
            config.MetricConfig.Sampler = new CompositeSampler(CompositeSampler.SamplerCompositionOperator.OR,
                            new List<Sampler> {
                                new TimeAwareSampler(),
                                new CountAwareSampler()
                                }
                            );           
        }       

        public override string DoHandleRequest(string request, ILambdaContext context)
        {
            Console.WriteLine("request: " + request);
            return "Hello " + request;
        }
    }
}
