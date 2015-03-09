using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Data;
using StudentSystem.Data.Migrations;
using StudentSystem.Models;

namespace StudentSystem.ConsoleApp
{
    class ConsoleClient
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

            var db = new StudentSystemDbContext();

            var courses = db.Courses.ToList();
            var students = db.Students.ToList();

            Console.WriteLine("================ Students - Homeworks ===============");
            foreach (var student in students)
            {
                Console.WriteLine(student.FullName);
                foreach (var homework in student.HomeworkSubmissions)
                {
                    Console.WriteLine("\t{0}", homework.Content);
                }
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine();

            Console.WriteLine("================ Courses - Resources ===============");
            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
                foreach (var resource in course.Resources)
                {
                    Console.WriteLine("\t{0}", resource.Name);
                }
                Console.WriteLine("--------------------------------");
            }

            var newCourse = AddCourse(db,
                "PHP Basics (New Course)",
                "Programming with PHP!!!",
                new DateTime(2015, 2, 1),
                new DateTime(2015, 3, 20),
                300);

            AddResource(db, "PHP Video 1", "media/web", "youtu.be/asads1", newCourse.Id);
            AddResource(db, "PHP Video 2", "media/web", "youtu.be/asd2", newCourse.Id);
            AddResource(db, "PHP Video 3", "media/web", "youtu.be/asadsxc3", newCourse.Id);

            AddStudent(db, "Natalia Matanova", "089432552", new DateTime(1987, 1, 25), new DateTime(2014, 2, 5));
        }

        public static Course AddCourse(StudentSystemDbContext context, string name, string description, DateTime startDate,
            DateTime endDate, decimal price)
        {
            var course = context.Courses.Add(new Course()
            {
                Name = name,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                Price = price
            });

            context.SaveChanges();
            return course;
        }

        public static Resource AddResource(StudentSystemDbContext context, string name, string type, string url,
            Guid courseId)
        {
            var resource = context.Resources.Add(new Resource()
            {
                Name = name,
                Type = type,
                Url = url,
                CourseId = courseId
            });

            context.SaveChanges();
            return resource;
        }

        public static Student AddStudent(StudentSystemDbContext context, string fullName, string phoneNumber,
            DateTime birthday, DateTime registrationDate)
        {
            var student = context.Students.Add(new Student()
            {
                FullName = fullName,
                PhoneNumber = phoneNumber,
                Birthday = birthday,
                RegistrationDate = registrationDate
            });

            context.SaveChanges();
            return student;
        }
    }
}
