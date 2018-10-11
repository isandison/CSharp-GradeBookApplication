using GradeBook.Enums;
using GradeBook.GradeBooks;

namespace GradeBook
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool weighted) : base(name, weighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
