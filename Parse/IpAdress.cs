using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Parse
{
    public class IpAdress
    {
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("ip")]
        public string ip { get; set; }

        [Newtonsoft.Json.JsonProperty("region")]
        public string region { get; set; }

        [Newtonsoft.Json.JsonProperty("country")]
        public string country { get; set; }

        [Newtonsoft.Json.JsonProperty("loc")]
        public string loc { get; set; }

        [Newtonsoft.Json.JsonProperty("org")]
        public string org { get; set; }

        [Newtonsoft.Json.JsonProperty("timezone")]
        public string timezone { get; set; }

        [Newtonsoft.Json.JsonProperty("city")]
        public string city { get; set; }

    }


}
