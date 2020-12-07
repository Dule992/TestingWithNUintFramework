using Newtonsoft.Json;
using System;

namespace TestingWithNUintFramework.RestfulBooker.Api.Data
{
    public class Booking
    {
        /*
         * {
         *      "firstname": "John",
         *      "lastname": "Lennon",
         *      "totalprice": 369,
         *      "depositpaid": true,
         *      "bookingdates": {
         *          "checkin" "2013-04-29",
         *          "checkout" 2014-06-14",
         *          
         *      },
         *      "additionalneeds": "Breakfast"
         *      }
         */

        public Booking()
        {
            roomid = 0;
            totalprice = 0;
        }

        public int BookingId { get; set; }

        [JsonProperty("roomid")]
        public int roomid { get; set; }

        [JsonProperty("firstname")]
        public string firstname { get; set; }

        [JsonProperty("lastname")]
        public string lastname { get; set; }

        [JsonProperty("totalprice")]
        public int totalprice { get; set; }

        [JsonProperty("depositpaid")]
        public int depositpaid { get; set; }

        [JsonProperty("bookingdates")]
        public BookingDates bookingdate { get; set; }

        [JsonProperty("additionalneeds")]
        public string additionalneeds { get; set; }
    }
    public class BookingDates
    {

        public BookingDates()
        {

        }

        public string checkin { get; set; }

        public string checkout { get; set; }

        public BookingDates(DateTime checkIn, DateTime checkOut)
        {
            this.checkin = checkIn.ToString("yyyy-MM-dd");
            this.checkout = checkOut.ToString("yyyy-MM-dd");
        }

    }
}
