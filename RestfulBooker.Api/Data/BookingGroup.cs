using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestingWithNUintFramework.RestfulBooker.Api.Data
{
    public class BookingGroup
    {
        [JsonProperty("bookings")]
        public List<Booking> Bookings { get; set; }
    }
}
