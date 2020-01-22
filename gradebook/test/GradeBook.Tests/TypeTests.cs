using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello");
            Assert.Equal(3, count);

        }

        
         string IncrementCount(string message)
        {
            count++;
            return message.ToLower();

        }

        string ReturnMessage(string message)
        {
            count++;
            return message;

        }

        [Fact]
        public void Test1()
        {

            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpIsPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);

        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);

        }


        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Josenildo";
            var upper = MakeUpperCase(name);

            Assert.Equal("Josenildo", name);
            Assert.Equal("JOSENILDO", upper);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book = GetBook("Book 1");
            var book2 = book;

            Assert.Same(book, book2);
            Assert.True(Object.ReferenceEquals(book, book2));
        }


        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
