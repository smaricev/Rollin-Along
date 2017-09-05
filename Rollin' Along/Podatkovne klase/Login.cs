using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rollin__Along.Podatkovne_klase
{
    public partial class Login
    {
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        public Prijava Prijava
        {
            get => default(Prijava);
            set
            {
            }
        }
    }
}