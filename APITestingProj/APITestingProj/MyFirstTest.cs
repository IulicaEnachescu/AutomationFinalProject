namespace APITestingProj    
{
    using Newtonsoft.Json.Linq;
    using NUnit.Framework;
    using RestSharp;
    using System;
    using System.Net;

    [TestFixture]
    public class MyFirstTest

    {
        private string token;

        [SetUp]
        public void Setup()
        {

        }


        [Test]
        public void ValidateHealthgRequest()
        {
            //create client connection
            RestClient restClient = new RestClient("https://restful-booker.herokuapp.com/ping");

            //create request
            RestRequest restRequest = new RestRequest(Method.GET);

            //execute request restClient.restRequest
            IRestResponse restResponse = restClient.Execute(restRequest);
            string response = restResponse.Content;
           

            //Assert
            
            
            Assert.IsTrue(response.Contains("Created"));
        }
        [Test]
        public void ValidateGetBookingRequest()
        {
            //create client connection
            RestClient restClient = new RestClient("https://restful-booker.herokuapp.com/booking/");

            //create request
            RestRequest restRequest = new RestRequest(Method.GET);

            //execute request restClient.restRequest
            IRestResponse restResponse = restClient.Execute(restRequest.AddHeader("Accept","application/json"));
            string response = restResponse.Content;

            //Assert


            Assert.IsTrue(response.Length>3);
        }
        [Test]
        public void ValidateCreateTokenRequest()
        {
            //create client connection
            RestClient restClient = new RestClient("https://restful-booker.herokuapp.com/auth");
            JObject objectBody = new JObject();
            objectBody.Add("username","admin");
            objectBody.Add("password", "password123");

            //create request
            RestRequest restRequest = new RestRequest(Method.POST);
            restRequest.AddParameter("application/json",objectBody, ParameterType.RequestBody);

            //execute request restClient.restRequest
            IRestResponse restResponse = restClient.Execute(restRequest);
           // restRequest.RequestFormat = DataFormat.Json;
            string response = restResponse.Content;

            //Assert


            Assert.IsTrue(response.Contains("token"));
        }
        [Test]
        public void ValidatePostRequest()
        {
            var client = new RestClient("https://restful-booker.herokuapp.com/booking");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"firstname\": \"IulicaTestCase\",\r\n " +
                "       \"lastname\": \"TestCase\",\r\n        \"totalprice\": 11111,\r\n    " +
                "    \"depositpaid\": true,\r\n        \"bookingdates\": {\r\n           " +
                " \"checkin\": \"2020-12-20\",\r\n            \"checkout\": \"2020-12-25\"\r\n        }" +
                ",\r\n          \"additionalneeds\": \"Breakfast\"\r\n      \r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            // Assert.IsTrue(response.Content.Contains("IulicaTestCase"));
            //Assert.IsTrue(response.StatusCode.ToString().Contains("OK"));
            //"bookingid": 17
            Assert.AreEqual((int)response.StatusCode, 200);
        }
        [Test]
        [TestCase(25)]
        public void ValidateGetBookingByIdRequest(int input)
        {
            //create client connection
            RestClient restClient = new RestClient($"https://restful-booker.herokuapp.com/booking/{input}");

            //create request
            RestRequest restRequest = new RestRequest(Method.GET);

            //execute request restClient.restRequest
            IRestResponse restResponse = restClient.Execute(restRequest.AddHeader("Accept", "application/json"));
            string response = restResponse.Content;

            //Assert


            Assert.IsTrue(response.Contains("IulicaTestCase"));
        }
        [Test]
        [TestCase (25)]
        public void ValidateDeleteRequest(int input)
        {
            //create client connection
            RestClient restClient = new RestClient($"https://restful-booker.herokuapp.com/booking/{input}");

            //create request
            RestRequest restRequest = new RestRequest(Method.DELETE);

            //execute request restClient.restRequest
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("Cookie", "token=3af76dbcdb55a33");
            restRequest.AddHeader("Authorization", "Basic Og==");
            restRequest.AddParameter("text/plain", "", ParameterType.RequestBody);
            IRestResponse restResponse = restClient.Execute(restRequest);
            string response = restResponse.Content;

            //Assert


            Assert.IsTrue(response.Contains("Created"));
        }
    }
}
