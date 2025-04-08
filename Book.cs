using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
		private  int _id;

        public static int Id { get; set; }

        public string Name { get; set; }

        public string AuthorName { get; set; }

        public double Price { get; set; }


        public Book(string name, string authorname, double price) 
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorname;
            Price = price;
        }



        public string ShowInfo()
        {
            return $" ID:{Id}, Name:{Name}, AuthorName:{AuthorName},  Price:{Price}";
        }


        public override string ToString()
        {
            return ShowInfo();
        }




    }
}
