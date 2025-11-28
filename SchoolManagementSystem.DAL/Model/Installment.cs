using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Model
{
   public  class Installment
    {
        public int InstallmentId { get; set; }
        public string Type { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public string date { get; set; }
        public decimal amount { get; set; }


    }
}
