using System;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public static class StudentManager
    {
        const short maxAge = 40;
        public static Student Create(string firstName, string lastName, int age)
            => new Student(firstName, lastName, age);
        public static Student[] Create(int count, int minAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"name{i}", $"surName{i}", rnd.Next(minAge, maxAge));
            }
            return students;
        }

        public static void Print(Student student)
        {
            Console.WriteLine("**********Student**********");
            Console.WriteLine($"id:{student._id} name:{student._firstName} lastName:{student._lastName} age:{student._age}");
            Console.WriteLine($"**********{student._id}-Teacher**********");
            if (student.teacher != null)
                Console.WriteLine($"id:{student.teacher._id} name:{student.teacher._firstName} lastName:{student.teacher._lastName} age:{student.teacher._age}");
            else
                Console.WriteLine("-------------------------------------------------------------------");
        }

        public static void Print(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("**********Student**********");
                Console.WriteLine($"id:{students[i]._id} name:{students[i]._firstName} lastName:{students[i]._lastName} age:{students[i]._age}");
                Console.WriteLine($"**********{students[i]._id}-Teacher**********");
                if (students[i].teacher != null)
                    Console.WriteLine($"id:{students[i].teacher._id} name:{students[i].teacher._firstName} lastName:{students[i].teacher._lastName} age:{students[i].teacher._age}");
                else
                    Console.WriteLine("-------------------------------------------------------------------");

            }
        }
    }
}
