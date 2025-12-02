using SchoolManagementSystem.DAL.Context;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Repositries
{
   public  class installmentRepositry
    {
        private AppDbContext con = new AppDbContext();

        public void addIstallment(Installment installment)
        {
            con.Installments.Add(installment);
            con.SaveChanges();
        }
        public void removeInstallment(Installment installment)
        {
            con.Installments.Remove(installment);
            con.SaveChanges();

        }
        public void updateInstallment( Installment installment)
        {
            var a_installment = con.Installments.Find(installment.InstallmentId);

            a_installment.Type = installment.Type;
           a_installment.StudentId=installment.StudentId;
            a_installment.amount = installment.amount;
            a_installment.date=installment.date;
            con.SaveChanges();


        }
        public  List<Installment> getStudentInstallment(Student student)
        {
            var studentInstallments = con.Installments.Where(f => f.StudentId == student.StudentId).ToList();
            return studentInstallments;
            con.SaveChanges();
        
        }
        public List<Installment> getAllInstallment()
        {
            return con.Installments.ToList();
            con.SaveChanges();
        }

    }
}
