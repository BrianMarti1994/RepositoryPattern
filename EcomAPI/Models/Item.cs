using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcomAPI.Models
{
    public  class Item
    {
        public string ItemCode { get; set; }
        public int UserId { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
    }
}