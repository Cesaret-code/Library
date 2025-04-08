namespace Library
{
    internal class LibraryBase
    {

        //GetBookById() - id qebul edəcek və həmin id-li book obyektini tapıb geriyə qaytaracaq

        public Book GetBookById(int id)
        {
            int ID = Convert.ToInt32(Console.ReadLine());
            if (ID == id)
            {
                return books[id];
            }

        }
    }
}