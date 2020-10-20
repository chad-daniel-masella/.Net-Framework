using System;
using System.Diagnostics;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using RestSharp;
using RestSharp.Authenticators;

namespace RestApiTests
{
    [TestClass]
    public class StatusCodeTests
    {
        [TestMethod]
        public void GetAllZipCodes()
        {
            // arrange the API Request data
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/90210", Method.GET);

            // execute the API using the arranged API request data
            IRestResponse response = client.Execute(request);

            // assert
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Assert.Fail("Test Case Failure");
            }
            
        }

        [TestMethod]
        public void GetZipCode()
        {
            // arrange the API Request data
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/90210", Method.GET);

            // execute the API using the arranged API request data
            IRestResponse response = client.Execute(request);

            // assert
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Assert.Fail("Test Case Failure");
            }

            Trace.WriteLine(response.Content);

        }
    }
}
