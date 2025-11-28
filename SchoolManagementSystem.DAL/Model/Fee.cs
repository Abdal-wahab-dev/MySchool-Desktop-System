using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SchoolManagementSystem.DAL.Model
{
    public class Fee
    {
        public int FeeId { get; set; }
       
        public int SchoolClassId { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }
        public decimal Feebasic { get; set; }
        public decimal FeeActivities { get; set; }
        public decimal FeeTotal { get; set; }

    }
}
