using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
//using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;

namespace K2DataObjects
{
    [DataContract]
    [JsonObject(MemberSerialization.OptIn)]
    public class OpenPricesRequest
    {
        [DataMember]
        [JsonProperty]
        public Product Product {get; set;}

        [DataMember]
        [JsonProperty]
        public int DepthLevels  {get; set;}

        [DataMember]
        [JsonProperty]
        public string RequestID { get; set; }
    }
}
