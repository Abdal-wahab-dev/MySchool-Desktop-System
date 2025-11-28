using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SchoolManagementSystem.DAL.Model
{
    public class Section
    {
        public int SectionId { get; set; }           
        public string SectionName { get; set; }      

        public int SchoolClassId { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
