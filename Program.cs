using MyBook.Classes;
namespace MyBook
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Hello enter your name please");
            string customer = Console.ReadLine()!;
            Console.WriteLine($"Hello {customer}, Wellcome to our Bookshop");
            Console.Write("Enter yuor favorute book: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter  author: ");
            string author = Console.ReadLine()!;

            Console.Write("Enter book`s price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("When is published: ");
            int year = Convert.ToInt32(Console.ReadLine());


            Book book = new Book(customer, name, author, price, year);
            book.AskQuestionCustomer();
            book.AskInfo();



        }
    }

}