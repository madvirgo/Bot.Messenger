using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class BoardingPass
    {
        [JsonProperty("passenger_name")]
        public virtual string PassengerName { get; set; }

        [JsonProperty("pnr_number")]
        public virtual string PnrNumber { get; set; }

        [JsonProperty("travel_class")]
        public virtual string TravelClass { get; set; }

        [JsonProperty("seat")]
        public virtual string Seat { get; set; }

        [JsonProperty("auxiliary_fields")]
        public virtual List<CustomField> AuxiliaryFields { get; set; }

        [JsonProperty("secondary_fields")]
        public virtual List<CustomField> SecondaryFields { get; set; }

        [JsonProperty("logo_image_url")]
        public virtual string LogoImageUrl { get; set; }

        [JsonProperty("header_image_url")]
        public virtual string HeaderImageUrl { get; set; }

        [JsonProperty("qr_code")]
        public virtual string QRCode { get; set; }

        [JsonProperty("above_bar_code_image_url")]
        public virtual string AboveBarCodeImageUrl { get; set; }

        [JsonProperty("flight_info")]
        public virtual FlightInfo FlightInfo { get; set; }
    }

}
