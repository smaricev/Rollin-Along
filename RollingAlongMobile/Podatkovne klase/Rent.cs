﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace RollingAlongMobile.Podatkovne_klase
{
    class Rent
    {
        [JsonProperty(PropertyName = "date_from")]
        public string Date_from { get; set; }
        [JsonProperty(PropertyName = "date_to")]
        public string Date_to { get; set; }
        [JsonProperty(PropertyName = "rentid")]
        public int Rentid { get; set; }
        [JsonProperty(PropertyName = "bicycle")]
        public Bicycle Bicycle { get; set; }
        [JsonProperty(PropertyName = "status")]
        public int Status { get; set; }
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }
        [JsonProperty(PropertyName = "review")]
        public Review Review { get; set; }
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }




    }
}