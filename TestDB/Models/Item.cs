using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TestDB.Models
{
    public class Item
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "semester")]
        public string Semester { get; set; }
       
        [JsonProperty(PropertyName = "instructor")]
        public string Instructor { get; set; }

        [JsonProperty(PropertyName = "Completed")]
        public bool Completed { get; internal set; }

    }
}