using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Library
    {
      public  List<Book> Books = new List<Book>();


        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (var item in Books)
            {
                if(item.Name==value)
                    NewBooks.Add(item);

            }
            return NewBooks;
        }

        public void RemoveAllBooksByName (string value)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (var item in Books)
            {
                if (item.Name == value)
                    NewBooks.Remove(item);

            }
          
        }
        public void RemoveBooksByCode(string value)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (var item in Books)
            {
                if (item.Code == value)
                    NewBooks.Remove(item);

            }

        }

        public List<Book> FindAllBooksByPageCountRange(int min,int max)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (var item in Books)
            {
                if (item.PageCount < max && item.PageCount>min) NewBooks.Add(item);
                  

            }
            return NewBooks;

        }


        public List<Book> SearchBooks(string value)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (var item in Books)
            {
                if (item.Name == value || item.AuthorName == value || item.PageCount == int.Parse(value)) ;
                NewBooks.Add(item);

            }
            return NewBooks;

        }

    }

}
