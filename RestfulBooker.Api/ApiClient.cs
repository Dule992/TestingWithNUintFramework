using Newtonsoft.Json;
using RestfulBooker.Api.Services;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization;

namespace RestfulBooker.Api
{
    public class RestfulBookerClient
    {
        public BookingsService Bookings { get; }

        public RoomsService Rooms { get; }
        public RestfulBookerClient(string username, string password, string baseUrl = "https://restful-booker.herokuapp.com")
        {
            var client = new RestClient(baseUrl) { Authenticator = new HttpBasicAuthenticator(username, password) };
            client.UseSerializer(() => new JsonNetSerializer());
            client.AddDefaultHeader("Accept", "application/json");

            Bookings = new BookingsService(client);
            Rooms = new RoomsService(client);


        }

    }

    public class JsonNetSerializer : IRestSerializer
    {
        public string Serialize(object obj) => JsonConvert.SerializeObject(obj);

        [System.Obsolete]
        public string Serialize(Parameter parameter) => JsonConvert.SerializeObject(parameter.Value);

        public T Deserialize<T>(IRestResponse response) => JsonConvert.DeserializeObject<T>(response.Content);

        public string[] SupportedContentTypes { get; } =
        {
            "application/json", "text/json","text/x-json","text/javascript","+json"
        };

        public string ContentType { get; set; } = "application/json";

        public DataFormat DataFormat { get; } = DataFormat.Json;
    }
}
