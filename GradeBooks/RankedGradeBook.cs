using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook:BaseGradeBook
    {

        public RankedGradeBook(string name):base(name)
        {

        }

        public RankedGradeBook()
        {
            Type = GradeBookType.Ranked;
        }



        public override char GetLetterGrade(double averageGrade)
        {
            Student s = new Student();
            if (s.Grades.Count<5)
            {
                throw new InvalidOperationException("Less than 5 Students");
            }
            else if (averageGrade >= 80)
            {
                return 'A';
            }
            else if (averageGrade >= 60 && averageGrade < 80 )
            {
                return 'B';
            }
            else if (averageGrade >= 60 && averageGrade < 80)
            {
                return 'C';
            }
            else if (averageGrade >= 40 && averageGrade < 60)
            {
                return 'D';
            }
            else if (averageGrade >= 20 && averageGrade < 40)
            {
                return 'B';
            }
            return 'F';
        }
    }
}
