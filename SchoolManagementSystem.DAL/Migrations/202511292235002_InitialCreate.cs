namespace SchoolManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SchoolClasses",
                c => new
                    {
                        SchoolClassId = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.SchoolClassId);
            
            CreateTable(
                "dbo.Fees",
                c => new
                    {
                        FeeId = c.Int(nullable: false, identity: true),
                        SchoolClassId = c.Int(nullable: false),
                        Feebasic = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FeeActivities = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FeeTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FeeId)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClassId, cascadeDelete: true)
                .Index(t => t.SchoolClassId);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        SectionId = c.Int(nullable: false, identity: true),
                        SectionName = c.String(),
                        SchoolClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SectionId)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClassId, cascadeDelete: true)
                .Index(t => t.SchoolClassId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        Address = c.String(),
                        StudentClass = c.String(),
                        PhoneNumber = c.String(),
                        Gender = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        ImagePath = c.String(),
                        StudentState = c.String(),
                        SectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        ExamType = c.String(),
                        Score = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxScore = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.GradeId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                        SubjectGrade = c.String(),
                    })
                .PrimaryKey(t => t.SubjectId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Major = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Date = c.DateTime(nullable: false),
                        address = c.String(),
                        phoneNumber = c.String(),
                        gender = c.String(),
                        salary = c.Double(nullable: false),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.Installments",
                c => new
                    {
                        InstallmentId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        StudentId = c.Int(nullable: false),
                        date = c.String(),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.InstallmentId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        PurchaseId = c.Int(nullable: false, identity: true),
                        PurchaseName = c.String(),
                        ballNumber = c.String(),
                        PurchaseType = c.String(),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Describtion = c.String(),
                    })
                .PrimaryKey(t => t.PurchaseId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.Int(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.SubjectSchoolClasses",
                c => new
                    {
                        Subject_SubjectId = c.Int(nullable: false),
                        SchoolClass_SchoolClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_SubjectId, t.SchoolClass_SchoolClassId })
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClass_SchoolClassId, cascadeDelete: true)
                .Index(t => t.Subject_SubjectId)
                .Index(t => t.SchoolClass_SchoolClassId);
            
            CreateTable(
                "dbo.TeacherSchoolClasses",
                c => new
                    {
                        Teacher_TeacherId = c.Int(nullable: false),
                        SchoolClass_SchoolClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherId, t.SchoolClass_SchoolClassId })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClass_SchoolClassId, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherId)
                .Index(t => t.SchoolClass_SchoolClassId);
            
            CreateTable(
                "dbo.TeacherSubjects",
                c => new
                    {
                        Teacher_TeacherId = c.Int(nullable: false),
                        Subject_SubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherId, t.Subject_SubjectId })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherId)
                .Index(t => t.Subject_SubjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Installments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Grades", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.TeacherSubjects", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.TeacherSubjects", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.TeacherSchoolClasses", "SchoolClass_SchoolClassId", "dbo.SchoolClasses");
            DropForeignKey("dbo.TeacherSchoolClasses", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.SubjectSchoolClasses", "SchoolClass_SchoolClassId", "dbo.SchoolClasses");
            DropForeignKey("dbo.SubjectSchoolClasses", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Grades", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Sections", "SchoolClassId", "dbo.SchoolClasses");
            DropForeignKey("dbo.Fees", "SchoolClassId", "dbo.SchoolClasses");
            DropIndex("dbo.TeacherSubjects", new[] { "Subject_SubjectId" });
            DropIndex("dbo.TeacherSubjects", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.TeacherSchoolClasses", new[] { "SchoolClass_SchoolClassId" });
            DropIndex("dbo.TeacherSchoolClasses", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.SubjectSchoolClasses", new[] { "SchoolClass_SchoolClassId" });
            DropIndex("dbo.SubjectSchoolClasses", new[] { "Subject_SubjectId" });
            DropIndex("dbo.Installments", new[] { "StudentId" });
            DropIndex("dbo.Grades", new[] { "SubjectId" });
            DropIndex("dbo.Grades", new[] { "StudentId" });
            DropIndex("dbo.Students", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "SchoolClassId" });
            DropIndex("dbo.Fees", new[] { "SchoolClassId" });
            DropTable("dbo.TeacherSubjects");
            DropTable("dbo.TeacherSchoolClasses");
            DropTable("dbo.SubjectSchoolClasses");
            DropTable("dbo.Users");
            DropTable("dbo.Purchases");
            DropTable("dbo.Installments");
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Grades");
            DropTable("dbo.Students");
            DropTable("dbo.Sections");
            DropTable("dbo.Fees");
            DropTable("dbo.SchoolClasses");
        }
    }
}
