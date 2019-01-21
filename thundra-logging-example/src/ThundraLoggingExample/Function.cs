using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Microsoft.Extensions.Logging;
using Thundra.Agent.Lambda.Config;
using Thundra.Agent.Lambda.Core;
using Thundra.Agent.Log.AspNetCore;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace ThundraLoggingExample
{
    public class Function : LambdaRequestHandler<GetAlbumRequest, Album>
    {
        private Dictionary<int, Album> albumRepository = new Dictionary<int, Album>();

        public Function()
        {
            albumRepository[0] = new Album("Cat got my tongue", "Monks", 1996);
            albumRepository[1] = new Album("Zero experience", "The Cafeteria", 2005);
            albumRepository[2] = new Album("Elephant in the room", "Mutant Pink Riders", 2013);
            albumRepository[3] = new Album("Flower shower", "After the Soda", 2012);
            albumRepository[4] = new Album("Rocket science", "The Basement", 1976);
            albumRepository[5] = new Album("Beginner\'s luck", "Lost Dogs", 1999);
            albumRepository[6] = new Album("So far so great", "The Last Chairs", 1981);
            albumRepository[7] = new Album("Knowledge bomb", "Robots", 2003);
            albumRepository[8] = new Album("Crowd control", "Super Object", 2015);
            albumRepository[9] = new Album("Hold the phone", "That Sofa", 2009);

        }
        public override Album DoHandleRequest(GetAlbumRequest request, ILambdaContext context)
        {
            var album = albumRepository[request.id];

            var loggerFactory = new LoggerFactory().AddThundraProvider();
            var logger = loggerFactory.CreateLogger<Function>();

            Console.WriteLine("Successfully fetched album.");

            logger.LogInformation("id is {0}", request.id);
            logger.LogTrace("name is {0}", album.Name);
            logger.LogDebug("band is {0}", album.Band);
            logger.LogDebug("year is {0}", album.Year);

            return albumRepository[request.id];
        }
    }
}
