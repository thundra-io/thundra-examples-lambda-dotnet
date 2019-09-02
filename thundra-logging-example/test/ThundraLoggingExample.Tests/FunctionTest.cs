
using Xunit;
using Amazon.Lambda.TestUtilities;

namespace ThundraLoggingExample.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestFunction()
        {

            // Invoke the lambda function wrapped with Thundra and confirm the greeting was returned.
            var function = new Function();
            GetAlbumRequest alreq = new GetAlbumRequest();
            alreq.id = 3;
            var context = new TestLambdaContext();
            var upperCase = function.DoHandleRequest(alreq, context);

            Assert.Equal("Flower shower", upperCase.Name);
        }
    }
}
