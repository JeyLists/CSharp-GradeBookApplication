using System;
using System.Linq;

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

            //var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
            //int threshold = (int)Math.Ceiling(Students.Count * 0.2);
            //
            //if (grades[threshold - 1] <= averageGrade)
            //{
            //    return 'A';
            //}
            //else if (grades[(threshold * 2) - 1] <= averageGrade)
            //{
            //    return 'B';
            //}
            //else if (grades[(threshold * 3) - 1] <= averageGrade)
            //{
            //    return 'C';
            //}
            //else if (grades[(threshold * 4) - 1] <= averageGrade)
            //{
            //    return 'D';
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    if (grades[(threshold * (i+1)) - 1] <= averageGrade)
            //    {
            //        Console.WriteLine('A' + i);
            //        return (char)('A' + i);
            //    }
            //}

            return 'F';
        }
    }
}
