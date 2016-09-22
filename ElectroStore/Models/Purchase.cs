using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectroStore.Models
{
    public class Purchase
    {
        //Id of purchase
        public int PurchaseId { get; set; }

        //Name and Surname of buyer or Company name
        public string Person { get; set; }

        //buyer's address
        public string Address { get; set; }

        //id of good
        public int GoodId { get; set; }

        //date of purchase
        public DateTime DatePurchase { get; set; }
    }
}