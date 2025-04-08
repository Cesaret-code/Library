using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        public string Name { get; set; }

        public Book[] books { get; set; }

        public int Id { get; set; }

        public void AddBook(Book book, Book[] books)
        {

            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
            
        }

        //GetBookById() - id qebul edəcek və həmin id-li book obyektini tapıb geriyə qaytaracaq

        public Book GetBookById(int id)
        {

            //foreach (var book in books)
            //{
            //    if (Id == id)
            //    {
            //        return book;
            //    }
            //}
            return null;
        }
        
        

        //RemoveBook() - id qebul edəcək və həmin id-li book obyektini tapıb siləcək.

        public void RemoveBook(Book[] books, int id)
        {
            Array.Resize(ref books, books.Length - 1);
            books[books.Length - 1] = null;

        }


        //GetBook() - string name qəbul edir. O adlı bütün kitabları geriyə qaytaracaq.
        public Book GetBook(string name)
        {
            foreach (var book in books)
            {
                if (Name==name)
                    return book;
            }
            return books[0];
            
        }

        //GetAllBooks() method bütün kitabları Console-a yazsın.
        public void GetAllBooks()
        {
            foreach (var book in books)
            {
                book.ShowInfo();  
            }
        }


        public void Update(int id, Book[] book)
        {
            
        }


    }
}
