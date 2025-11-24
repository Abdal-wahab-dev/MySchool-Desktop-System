using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Repositries
{
    public class ClassReportDTO
    {
        public string ClassName { get; set; }
        public int SectionsCount { get; set; }
        public decimal ClassFee { get; set; }
        public int StudentsCount { get; set; }
        public decimal TotalFee { get; set; }
    }

}
