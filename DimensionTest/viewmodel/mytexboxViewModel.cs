using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionTest.viewmodel
{
    class mytexboxViewModel:NotifyPropertyChanged
    {
       "https://search-maps.yandex.ru/v1/?text={0}&type=biz&lang=ru_RU&apikey=andry"
        // TwilioApi.cs
        public class TwilioApi
        {
            const string BaseUrl = "https://api.twilio.com/2008-08-01";

            readonly string _accountSid;
            readonly string _secretKey;

            public TwilioApi(string accountSid, string secretKey)
            {
                _accountSid = accountSid;
                _secretKey = secretKey;
            }

            public T Execute<T>(RestRequest request) where T : new()
            {
                var client = new RestClient();
                client.BaseUrl = new System.Uri(BaseUrl);
                client.Authenticator = new HttpBasicAuthenticator(_accountSid, _secretKey);
                request.AddParameter("AccountSid", _accountSid, ParameterType.UrlSegment); // used on every request
                var response = client.Execute<T>(request);

                if (response.ErrorException != null)
                {
                    const string message = "Error retrieving response.  Check inner details for more info.";
                    var twilioException = new ApplicationException(message, response.ErrorException);
                    throw twilioException;
                }
                return response.Data;
            }

        }

        // Call.cs
        public class Call
        {
            public string Sid { get; set; }
            public DateTime DateCreated { get; set; }
            public DateTime DateUpdated { get; set; }
            public string CallSegmentSid { get; set; }
            public string AccountSid { get; set; }
            public string Called { get; set; }
            public string Caller { get; set; }
            public string PhoneNumberSid { get; set; }
            public int Status { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public int Duration { get; set; }
            public decimal Price { get; set; }
            public int Flags { get; set; }
        }

        // TwilioApi.cs, method of TwilioApi class
        public Call GetCall(string callSid)
        {
            var request = new RestRequest();
            request.Resource = "Accounts/{AccountSid}/Calls/{CallSid}";
            request.RootElement = "Call";

            request.AddParameter("CallSid", callSid, ParameterType.UrlSegment);

            return Execute<Call>(request);
        }

        // TwilioApi.cs, method of TwilioApi class
    public void InitiateOutboundCall() 
    {
        var client = new RestClient();
        client.BaseUrl = new Uri("http://twitter.com");
        client.Authenticator = new HttpBasicAuthenticator("username", "password");

        var request = new RestRequest();
        request.Resource = "statuses/friends_timeline.xml";

        IRestResponse response = client.Execute(request);
    }
       
        public void test()
        {
            var client = new RestClient("http://example.com");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest("resource/{id}", Method.POST);
            request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
            request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

            // easily add HTTP Headers
            request.AddHeader("header", "value");

            // add files to upload (works with compatible verbs)
            request.AddFile(path);

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            // or automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            RestResponse<Person> response2 = client.Execute<Person>(request);
            var name = response2.Data.Name;

            // easy async support
            client.ExecuteAsync(request, response =>
            {
                Console.WriteLine(response.Content);
            });

            // async with deserialization
            var asyncHandle = client.ExecuteAsync<Person>(request, response =>
            {
                Console.WriteLine(response.Data.Name);
            });

            // abort the request on demand
            asyncHandle.Abort();
        }

    }
}
