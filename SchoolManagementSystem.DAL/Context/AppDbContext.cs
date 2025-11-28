using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Context
{
    public  class AppDbContext : DbContext
    {
        public AppDbContext() : base("MyDbConnection")
        {
          
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers{ get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<SchoolClass> Classes{ get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Fee> Fees { get; set; }

        public DbSet<Installment> Installments { get; set; }
        public DbSet<Purchase> Purchases { get; set; }






}
}
