using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cholo_841665_As1.Models;

namespace Cholo_841665_As1.Controllers
{
    public class StudentController : Controller
    {
        
        public ViewResult Index() //Index methond as seen at index view
        {
            ViewBag.myName = "Cholo Cruz"; //declaration of ViewBag
            return View(); // returning view
        }

        // GET: Student
        public ViewResult StudentList()//StudentList methond as seen at StudentList view
        {
            //assigning of variables and value
            const double S1 = 3.0;
            const double S2 = 3.5;
            const double S3 = 3.7;
            var students = new List<Student>
        {
            //student details
            new Student { StudentID = 1, FirstName = "John", LastName = "Doe", GPA = (decimal)S1 },
            new Student { StudentID = 2, FirstName = "Jane", LastName = "Smith", GPA = (decimal)S2 },
            new Student { StudentID = 3, FirstName = "Cholo", LastName = "Cruz", GPA = (decimal)S3 },
        };
            //calculation of average and total GPA
            decimal totalGPA = students.Sum(student => student.GPA);
            decimal averageGPA = totalGPA / students.Count;

            //ViewBag of average and total GPA
            ViewBag.totalGPA = students.Sum(s => s.GPA).ToString("N2");
            ViewBag.AverageGPA = averageGPA;

            return View(students);// returning view
        }
    }
}
