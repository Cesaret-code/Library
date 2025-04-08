namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            bool aaaa =true;

            while (aaaa)
            {
                Console.WriteLine("1.Add Book,  2.Getbookbyid,  3.Remove book,  4.Update book, 5.GetAllBooks, 0.Exit");
                Console.WriteLine("Secim edin:");
                string Sechim = Console.ReadLine();

                switch (Sechim)
                {
                    case "1":
                        Console.Write("Ad dakil edin: ");
                        string name = Console.ReadLine();
                        Console.Write("Authorname dakil edin: ");
                        string authorname = Console.ReadLine();
                        Console.Write("Qiymet dakil edin: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Book bookmenu = new Book(name, authorname, price);
                        library.AddBook(bookmenu, []);
                        Console.WriteLine("kitab add olundu");

                        break;

                    case "2":
                        library.GetBookById(5);

                        break;

                    case "3":
                        library.RemoveBook([], 5);
                        break;

                    case "4":
                        library.Update(6, []);

                        break;

                    case "5":
                        library.GetAllBooks();

                        break;
                    case "0":
                        aaaa = false;
                        break;



                    default:
                        break;
                }



            }
        }
    }
}
