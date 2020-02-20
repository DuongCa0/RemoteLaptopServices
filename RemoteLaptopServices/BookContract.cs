using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RemoteLaptopServices
{
    [DataContract]
    public class BookContract
    {
        [DataMember]
        public int LaptopCode { get; set; }
        [DataMember]
        public string LaptopName { get; set; }
        [DataMember]
        public Nullable<int> Price { get; set; }
        [DataMember]
        public Nullable<bool> FingerPrint { get; set; }
    }
}