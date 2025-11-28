using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Model
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public DateTime dateGradute { get; set; }
        public DateTime Date { get; set; }
        public string address { get; set; }
        public  string phoneNumber {  get; set; }
        public string gender {  get; set; }
        public double salary { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
        public virtual ICollection<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();


    }
}
