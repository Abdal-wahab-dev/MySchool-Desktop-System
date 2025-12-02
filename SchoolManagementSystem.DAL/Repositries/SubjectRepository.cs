using SchoolManagementSystem.DAL.Context;
using SchoolManagementSystem.DAL.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SchoolManagementSystem.DAL.Repositries
{
    public class SubjectRepository
    {
        // جلب المواد مع البيانات المرتبطة (Include مهم جداً هنا)
        public List<Subject> GetAllSubjects()
        {
            using (var context = new AppDbContext())
            {
                return context.Subjects
                              .Include(s => s.SchoolClasses)
                              .Include(s => s.Teachers)
                              .ToList();
            }
        }

        // دالة الإضافة: نربط المادة بالصف والمعلم المختارين
        public void AddSubject(Subject subject, int classId, int teacherId)
        {
            using (var context = new AppDbContext())
            {
                // 1. جلب الكيانات المرتبطة
                var schoolClass = context.Classes.Find(classId);
                var teacher = context.Teachers.Find(teacherId);

                // 2. إضافتها لقوائم المادة
                if (schoolClass != null) subject.SchoolClasses.Add(schoolClass);
                if (teacher != null) subject.Teachers.Add(teacher);

                // 3. الحفظ
                context.Subjects.Add(subject);
                context.SaveChanges();
            }
        }

        // دالة التحديث
        public void UpdateSubject(Subject subjectData, int classId, int teacherId)
        {
            using (var context = new AppDbContext())
            {
                // جلب المادة القديمة مع علاقاتها
                var existingSubject = context.Subjects
                                             .Include(s => s.SchoolClasses)
                                             .Include(s => s.Teachers)
                                             .FirstOrDefault(s => s.SubjectId == subjectData.SubjectId);

                if (existingSubject != null)
                {
                    // تحديث البيانات النصية
                    existingSubject.SubjectName = subjectData.SubjectName;
                    existingSubject.SubjectGrade = subjectData.SubjectGrade;

                    // تحديث العلاقات (مسح القديم وإضافة الجديد)
                    existingSubject.SchoolClasses.Clear();
                    existingSubject.Teachers.Clear();

                    var schoolClass = context.Classes.Find(classId);
                    var teacher = context.Teachers.Find(teacherId);

                    if (schoolClass != null) existingSubject.SchoolClasses.Add(schoolClass);
                    if (teacher != null) existingSubject.Teachers.Add(teacher);

                    context.SaveChanges();
                }
            }
        }

        // دالة الحذف
        public void DeleteSubject(int id)
        {
            using (var context = new AppDbContext())
            {
                var subject = context.Subjects.Find(id);
                if (subject != null)
                {
                    context.Subjects.Remove(subject);
                    context.SaveChanges();
                }
            }
        }

        // دوال تعبئة القوائم
        public List<SchoolClass> GetAllClasses()
        {
            using (var context = new AppDbContext()) return context.Classes.ToList();
        }

        public List<Teacher> GetAllTeachers()
        {
            using (var context = new AppDbContext()) return context.Teachers.ToList();
        }
        public Subject GetSubjectById(int id)
        {
            using (var context = new AppDbContext())
            {
                // نجلب المادة مع الصفوف والمعلمين المرتبطين بها
                return context.Subjects
                              .Include("SchoolClasses")
                              .Include("Teachers")
                              .FirstOrDefault(s => s.SubjectId == id);
            }
        }
    }
}