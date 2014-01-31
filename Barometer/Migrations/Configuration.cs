namespace Barometer.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BaroDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BaroDB context)
        {
            Teacher t1 = new Teacher(12, "Marieke", "Versteijlen", TeacherAccess.tutor);
            Teacher t2 = new Teacher(13, "Jos", "Weert, van", TeacherAccess.mentor);
            Teacher t3 = new Teacher(14, "Ger", "Saris", TeacherAccess.mentor);
            Teacher t4 = new Teacher(15, "Angelique", "Boogaard, van den", TeacherAccess.tutor);
            Teacher t5 = new Teacher(16, "Bob", "Bus", TeacherAccess.mentor);
            Student s1 = new Student(2053429, "Jeroen", "Broekhuizen", 2, t2);
            Student s2 = new Student(2059821, "Alexander", "Doorn, van", 2, t4);
            Student s3 = new Student(2052712, "Benny", "Bijl", 2, t4);
            Student s4 = new Student(2052387, "Bryan", "Schreuder", 2, t3);
            Student s5 = new Student(2059370, "Joep", "Broek, van den", 2, t1);
            Student s6 = new Student(2062810, "Luuk", "Bruin, de", 2, t3);
            Student s7 = new Student(2063273, "Solo", "Schekermans", 2, t3);
            Student s8 = new Student(2059071, "Thomas", "Voogt", 2, t5);


            Teacher t6 = new Teacher(2053429, "Jeroen", "Broekhuizen", TeacherAccess.projectDocent);
            Teacher t7 = new Teacher(2059821, "Alexander", "Doorn, van", TeacherAccess.projectDocent);
            Teacher t8 = new Teacher(2052712, "Benny", "Bijl", TeacherAccess.projectDocent);
            Teacher t9 = new Teacher(2052387, "Bryan", "Schreuder", TeacherAccess.projectDocent);
            Teacher t10 = new Teacher(2059370, "Joep", "Broek, van den", TeacherAccess.projectDocent);
            Teacher t11 = new Teacher(2062810, "Luuk", "Bruin, de", TeacherAccess.projectDocent);
            Teacher t12 = new Teacher(2063273, "Solo", "Schekermans", TeacherAccess.projectDocent);
            Teacher t13 = new Teacher(2059071, "Thomas", "Voogt", TeacherAccess.projectDocent);
            

        //    //Project p1 = new Project("Barometer", t1, new DateTime(2013, 11, 01), new DateTime(2014, 02, 07), null);
        //    //ProjectGroup pg1 = new ProjectGroup("42IN06SOg", p1);
        //    //List<Student> students = new List<Student>();
        //    //students.AddRange();
        //    //pg1.ProjectStudents.AddRange(students);

        //    //foreach (Student s in students)
        //    //{
        //    //    s.ProjectGroup.Add(pg1);
        //    //}








            context.Teachers.AddOrUpdate(new Teacher[] { t6, t7, t8, t9, t10, t11, t12, t13 });
            context.Students.AddOrUpdate(new Student[] { s1, s2, s3, s4, s5, s6, s7, s8 });
        //    //context.Projects.AddOrUpdate(p1);
        //    //context.ProjectGroups.AddOrUpdate(pg1);


            context.SaveChanges();
        }
    }
}
