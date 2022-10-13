using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    internal class BaseGradeBook
    {
        public GradeBookType Type { get; set; }

        public BaseGradeBook(string name)
        {

        }

        public BaseGradeBook()
        {

        }
        public virtual char GetLetterGrade(double averageGrade)
        {
            return 'a';
        }





    }
}
