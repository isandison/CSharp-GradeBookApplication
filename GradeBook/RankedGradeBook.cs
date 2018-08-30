﻿using System;
using GradeBook.Enums;
using GradeBook.GradeBooks;

namespace GradeBook
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException(message: "not enough students");
            }
            if (averageGrade >= 80)
                return 'A';
            else if (averageGrade < 80 && averageGrade >= 60)
                return 'B';
            else if (averageGrade < 60 && averageGrade >= 40)
                return 'C';
            else if (averageGrade < 40 && averageGrade >= 20)
                return 'D';

            return 'F';

        }
    }
}
