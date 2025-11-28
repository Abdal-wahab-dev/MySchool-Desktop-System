using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Model
{
    public  class Purchase
    {
        public int PurchaseId { get; set; }
        public string PurchaseName { get; set; }
        public string ballNumber { get; set; }
        public string PurchaseType { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set;}
        public string Describtion{ get; set; }



    }
}
