using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaptopClient.Models
{
    public class Book
    {
        public int LaptopCode { get; set; }
        public string LaptopName { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<bool> FingerPrint { get; set; }
    }
}