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
    }
}
