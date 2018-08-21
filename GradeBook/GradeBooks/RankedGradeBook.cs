using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Cannot get letterGrade when there are less than 5 students");
            }
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
            int threshold = 0;

            for (double i = 0.2, j = 0; i < 1.0; i += 0.2, j++)
            {
                threshold = (int)Math.Ceiling(Students.Count * i);
                if (grades[threshold - 1] <= averageGrade)
                {
                    return (char)('A' + j);
                }
            }

            return 'F';
        }
    }
}
