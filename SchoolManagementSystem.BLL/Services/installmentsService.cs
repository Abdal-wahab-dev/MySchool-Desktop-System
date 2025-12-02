using SchoolManagementSystem.DAL.Model;
using SchoolManagementSystem.DAL.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.BLL.Services
{
    public class installmentsService
    {
        public installmentRepositry installmentService = new installmentRepositry();

        public void addNewInstallment(Installment installment)
        {
            installmentService.addIstallment(installment);
        }
        public void removeInstallment(Installment installment)
        {
            installmentService.removeInstallment(installment);
        }
        public void updateInstallment(Installment installment)
        {
            installmentService.updateInstallment(installment);
        }
        public List<Installment> getStudentInstallments(Student student)
        {
            return  installmentService.getStudentInstallment(student);
        }
        public List<Installment> getInstallments()
        {
            return installmentService.getAllInstallment();
        }

    }
}
