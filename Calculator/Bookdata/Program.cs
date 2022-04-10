using System;
namespace Bookdata
{

    struct Book
    {
        public int BookId;
        public string Title;
        public float price;
        public int Booktype;
        public enum Books

        {
            Magazine, Novel, Reference_Book, Miscellaneous
        }

    };
    public class BookData
    {
        public static void Displaydetails(string bTitle, int bid, int type, float bprice)
        {
            Console.WriteLine("Book Title: {0}", bTitle);
            Console.WriteLine("Book ID: {0}", bid);
            switch (type)
            {
                case 1:
                    Console.WriteLine("Book Type: Magazine");
                    break;
                case 2:
                    Console.WriteLine("Book Type: Novel");
                    break;
                case 3:
                    Console.WriteLine("Book Type: Reference Book");
                    break;
                case 4:
                    Console.WriteLine("Book Type: Miscellaneous");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.WriteLine("Book Price: {0}", bprice);
        }

        static void Main()
        {
            Console.WriteLine("Enter the details of the book: ");
            Book book = new Book();
            Console.WriteLine("Enter Book Title: ");
            book.Title = Console.ReadLine();
            Console.WriteLine("Enter Book Price: ");
            book.price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Book Id: ");
            book.BookId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Type: \n1.Magazine\n2.Novel\n3.Reference\n4.Miscellaneous");
            book.Booktype = Convert.ToInt32(Console.ReadLine());
            BookData.Displaydetails(book.Title, book.BookId, book.Booktype, book.price);

        }
    }
}