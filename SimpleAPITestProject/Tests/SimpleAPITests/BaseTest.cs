using RestSharp;
using System.Net;

namespace SimpleAPITestProject.Tests.SimpleAPITests
{
    internal class BaseTest
    {
        [Test]
        public static void setURL()
        {
            string url = "https://jsonplaceholder.typicode.com";
            var client = new RestClient(url + "/users/1");
            var request = new RestRequest();
            var response = client.Get(request);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
