using System;
using UniversityConsoleApp.BL;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = StudentManager.Create("Emma", "Smit", 19);
            StudentManager.Print(st);
            Student[] students = StudentManager.Create(21,18);
            StudentManager.Print(students);

            Teacher tch = TeacherManager.Create("Samuel", "Peres", 21);
            Teacher[] teachers = TeacherManager.Create(5, 19);

            //Delay...
            Console.ReadKey();
        }
    }
}
