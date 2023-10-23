using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Book
    {
        public Book()
        {
            _id++;
            Id = _id;
        }
        private string _code;
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code 
        { get => _code;
            set { _code = Name.Trim().Substring(0, 2).ToUpper() + Id; }
        }
    }
}
