
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity; // نحتاجه لاستخدام Include وربما EntityState
using SchoolManagementSystem.DAL.Context;
using SchoolManagementSystem.DAL.Model;

namespace SchoolManagementSystem.DAL.Repositries
{
    // ملاحظة: تم تغيير اسم الفئة إلى TeacherRepository ليتوافق مع المعلمين
    public class TeacherRepository
    {
        // استخدام الـ DbContext الخاص بك
        private readonly AppDbContext con = new AppDbContext();

        /// <summary>
        /// استرجاع قائمة بجميع المعلمين من قاعدة البيانات.
        /// </summary>
        /// <returns>قائمة بكائنات المعلمين (Teacher).</returns>
        public List<Teacher> GetAllTeachers()
        {
            // قد ترغب في تضمين (Include) الكيانات المرتبطة مثل Subjects أو SchoolClasses إذا كنت بحاجة لبياناتها فوراً.
            return con.Teachers
                        .Include(t => t.Subjects) // إذا كنت تحتاج لتحميل المواد المسندة للمعلم
                        .ToList();
        }

        /// <summary>
        /// إضافة معلم جديد إلى قاعدة البيانات.
        /// </summary>
        /// <param name="teacher">كائن المعلم المراد إضافته.</param>
        public void AddNewTeacher(Teacher teacher)
        {
            con.Teachers.Add(teacher);
            con.SaveChanges();
        }

        /// <summary>
        /// حذف معلم من قاعدة البيانات.
        /// </summary>
        /// <param name="teacher">كائن المعلم المراد حذفه.</param>
        public void RemoveTeacher(Teacher teacher)
        {
            // يفضل استخدام con.Teachers.Attach(teacher) قبل Remove إذا كان الكائن مفصولاً (Detached)
            con.Teachers.Remove(teacher);
            con.SaveChanges();
        }

        /// <summary>
        /// تحديث بيانات معلم موجود في قاعدة البيانات.
        /// </summary>
        /// <param name="teacher">كائن المعلم بالبيانات الجديدة (يجب أن يحتوي على TeacherId).</param>
        public void UpdateTeacher(Teacher teacher)
        {
            // 1. البحث عن الكائن الحالي في الـ Context باستخدام المفتاح الأساسي (TeacherId)
            var teacher_a = con.Teachers.Find(teacher.TeacherId);

            if (teacher_a != null)
            {
                // 2. تحديث الخصائص واحدة تلو الأخرى (Mapping)
                teacher_a.Name = teacher.Name;
                teacher_a.dateGradute = teacher.dateGradute;
                teacher_a.Date = teacher.Date;
                teacher_a.address = teacher.address;
                teacher_a.phoneNumber = teacher.phoneNumber;
                teacher_a.gender = teacher.gender;
                teacher_a.salary = teacher.salary;

                // ملاحظة: لم يتم تحديث الكيانات المتعددة (Subjects, SchoolClasses) هنا.
                // تحديث العلاقات يتطلب منطقاً إضافياً.

                // 3. حفظ التغييرات
                con.SaveChanges();
            }
            // يمكن إضافة 'else' هنا لرمي استثناء إذا لم يتم العثور على المعلم.
        }

        /// <summary>
        /// استرجاع تفاصيل معلم محدد بواسطة الهوية.
        /// </summary>
        /// <param name="teacherId">هوية المعلم.</param>
        /// <returns>كائن Teacher المطابق، أو null إذا لم يتم العثور عليه.</returns>
        public Teacher ShowDetails(int teacherId)
        {
            // استخدام Find هي الطريقة الأسرع للبحث بالمفتاح الأساسي.
            Teacher teacher_s = con.Teachers.Find(teacherId);

            // يمكن تضمين الكيانات المرتبطة هنا أيضاً إذا لزم الأمر
            // Teacher teacher_s = con.Teachers.Include(t => t.Subjects).FirstOrDefault(t => t.TeacherId == teacherId);

            return teacher_s;
        }

        // بما أن المعلمين لديهم Subjects و SchoolClasses مرتبطة بهم (1:M أو M:M)
        // قد تحتاج إلى دوال مساعدة هنا:

        /// <summary>
        /// الحصول على قائمة بكل المواد المتاحة.
        /// </summary>
        public List<Subject> GetAvailableSubjects()
        {
            // نفترض أن Subjects هو DbSet في الـ AppDbContext
            return con.Subjects.ToList();
        }

        /// <summary>
        /// الحصول على قائمة بكل الفصول المدرسية المتاحة.
        /// </summary>
        public List<SchoolClass> GetAvailableClasses()
        {
            // نفترض أن SchoolClasses هو DbSet في الـ AppDbContext
            return con.Classes.ToList();
        }
    }
}