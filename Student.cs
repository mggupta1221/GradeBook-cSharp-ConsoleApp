using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Student
    {
        public string Name { set; get; }
        public StudentType Type { set; get; }
        public EnrollmentType Enrollment { set; get; }
        public List<double> Grades { get; set; }//created property to store grades

        public Student(string name, StudentType type, EnrollmentType enrollment )
        {
            this.Name = name;
            Type = type;
            Enrollment = enrollment;
            this.Grades = new List<double>();

        }
        public double averageGrade
        {
            get { return Grades.Average(); }
        }

        public char LetterGrade { set; get; }
        public double GPA{set;get;}

        public void AddGrade(double grade)
        {
            if(grade<0 || grade > 100)
            {
                throw new ArgumentException("grade must be between 0 and 100");
            }
            Grades.Add(grade);
        }
        public void RemoveGrade(double grade)
        {
            if (Grades.Count == 0)
            {
                Console.WriteLine("Can't be removed as no grades are there.");
            }
            Grades.Remove(grade);
        }


    }
}
