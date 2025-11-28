using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Model
{
    public class Grade
    {
        public int GradeId { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

        public string ExamType { get; set; }

        public decimal Score { get; set; }
        public decimal MaxScore { get; set; }
    }
}
