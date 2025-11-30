//using SchoolManagementSystem.DAL.Repositries;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using SchoolManagementSystem.DAL.Model;

//namespace SchoolManagementSystem.BLL.Services
//{
//    public  class TeacherServices
//    {
//        public readonly teacherRepositry teacherRepositry = new teacherRepositry();


//        public List<Teacher> getTeacher()
//        {
//            return teacherRepositry.getAllTeacher();
//        }
//        public void addTeacher(Teacher teacher)
//        {
//            teacherRepositry.addTeacher(teacher);
//        }
//        public void updateTeacher(Teacher teacher)
//        {
//            teacherRepositry.updateTeacher(teacher);
//        }
//        public void removeTeacher(Teacher teacher)
//        {
//        teacherRepositry.removeTeacher(teacher);
//        }
//        public Teacher showDetials(Teacher teacher)
//        {
//            return teacherRepositry.ShowDetails(teacher);
//        }


//        }
//    }
using SchoolManagementSystem.DAL.Model;
using SchoolManagementSystem.DAL.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.BLL.Services
{
    public class TeacherService
    {
        // تهيئة مستودع المعلمين (TeacherRepository) مباشرة
        public readonly TeacherRepository teacherService = new TeacherRepository();

        // 1. ➕ دالة الإضافة مع التحقق (Validation)
        public void AddTeacher(Teacher teacher)
        {
            // ===================================
            // === منطق التحقق (Validation Logic) ===
            // ===================================

            if (string.IsNullOrWhiteSpace(teacher.Name))
            {
                // رمي استثناء ArgumentException عند وجود خطأ في البيانات المدخلة
                throw new ArgumentException("خطأ: يجب إدخال اسم المعلم.");
            }
            
            

            if (teacher.salary <= 0)
            {
                throw new ArgumentException("خطأ: الراتب يجب أن يكون قيمة موجبة.");
            }
            
            if (teacher.phoneNumber == null || teacher.phoneNumber.Length < 8)
            {
                throw new ArgumentException("خطأ: رقم الهاتف غير صالح أو قصير جداً.");
            }

            // ===================================
            // === استدعاء الـ Repository للحفظ ===
            // ===================================
            teacherService.AddNewTeacher(teacher);
        }

        // 2. ✏️ دالة التحديث مع التحقق (Validation)
        public void UpdateTeacher(Teacher teacher)
        {
            // التحقق من وجود المعلم قبل محاولة التحديث
            var existingTeacher = teacherService.ShowDetails(teacher.TeacherId);
            if (existingTeacher == null)
            {
                throw new KeyNotFoundException($"خطأ: المعلم ذو الهوية {teacher.TeacherId} غير موجود.");
            }

            // ===================================
            // === منطق التحقق (Validation Logic) ===
            // ===================================

            if (string.IsNullOrWhiteSpace(teacher.Name))
            {
                throw new ArgumentException("خطأ: يجب إدخال اسم المعلم.");
            }
            
            if (teacher.salary < 1000) // مثال لقاعدة عمل: لا يقل الراتب عن 1000
            {
                throw new ArgumentException("خطأ: يجب أن لا يقل الراتب عن 1000 وحدة نقدية.");
            }
            
            // ===================================
            // === استدعاء الـ Repository للتحديث ===
            // ===================================
            teacherService.UpdateTeacher(teacher);
        }

        // 3. ➖ دالة الحذف مع قواعد الأعمال
        public void RemoveTeacher(Teacher teacher)
        {
            // التحقق من وجود المعلم أولاً
            var existingTeacher = teacherService.ShowDetails(teacher.TeacherId);
            if (existingTeacher == null)
            {
                throw new KeyNotFoundException($"خطأ: المعلم ذو الهوية {teacher.TeacherId} غير موجود للحذف.");
            }
            
            // قاعدة عمل: منع الحذف إذا كان المعلم قد تم تعيينه مؤخراً (خلال أول 30 يوم)
            if (existingTeacher.Date > DateTime.Today.AddDays(-30))
            {
                throw new InvalidOperationException("خطأ: لا يمكن حذف المعلم قبل مرور 30 يوماً على تعيينه.");
            }
            
            teacherService.RemoveTeacher(teacher);
        }
        
        // ... (باقي الدوال مثل GetTeachers(), ShowDetails(), GetAllClasses(), GetAllSubjects() تبقى كما هي)
        
        public List<Teacher> GetTeachers()
        {
            return teacherService.GetAllTeachers();
        }
        
        public Teacher ShowDetails(int teacherId)
        {
            return teacherService.ShowDetails(teacherId);
        }

        public List<Subject> GetAllSubjects()
        {
            return teacherService.GetAvailableSubjects();
        }

        public List<SchoolClass> GetAllClasses()
        {
            return teacherService.GetAvailableClasses();
        }
    }
}

