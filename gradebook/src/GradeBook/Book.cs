namespace GradeBook
{
    public abstract class Book : NamedObjects, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract event InMemoryBook.GradeAddeddelegate GradeAdded;
        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();
    }
}