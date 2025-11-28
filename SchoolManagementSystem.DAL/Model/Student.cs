using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Model
{
    public class Student
    {
        public int StudentId {  get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string StudentClass { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string ImagePath { get; set; }
        public string StudentState { get; set; }

        public virtual ICollection<Grade> Grades{ get; set; } = new List<Grade>();
        public virtual ICollection<Installment> Installments { get; set; } = new List<Installment>();
        public int SectionId{ get; set; }
        public virtual Section Section { get; set; }

    }
}
