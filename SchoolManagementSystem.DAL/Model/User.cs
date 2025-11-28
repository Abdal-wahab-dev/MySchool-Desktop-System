using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Model
{
    public  class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Type { get; set; }

    }
}
