using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> Books = new List<Book>();
            Book book = new Book();
            book.Name = "programming";
            book.AuthorName = "Remzi";
            book.PageCount=400;
            Book book1 = new Book();
            book.Name = "programming-2";
            book.AuthorName = "Remzi";
            book.PageCount = 200;
            Books.Add(book1);
            Books.Add(book);
            Books.Remove(book1 );

            foreach (var item in Books)
            {
                Console.WriteLine(item);
            }


        }
    }
}