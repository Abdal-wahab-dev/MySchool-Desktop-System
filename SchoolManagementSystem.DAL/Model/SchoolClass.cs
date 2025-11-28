using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Model
{
    public class SchoolClass
    {
        public int SchoolClassId { get; set; }             
        public string ClassName { get; set; }       
       public int? TeacherId { get; set; }

        public virtual ICollection<Fee> Fees { get; set; } = new List<Fee>();
        public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
        public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
        public virtual ICollection<Teacher> Teachers{ get; set; } = new List<Teacher>();
    }
}
