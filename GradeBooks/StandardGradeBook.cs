﻿using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    internal class StandardGradeBook:BaseGradeBook
    {
        public StandardGradeBook(string name):base(name)
        {
          
        }

        public StandardGradeBook()
        {
            Type = GradeBookType.Standard;
        }
    }
}
