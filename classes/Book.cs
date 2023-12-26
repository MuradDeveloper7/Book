using System.Diagnostics.Contracts;

namespace MyBook.Classes
{
    class Book
    {

        public string CustomerName { get; set; }
        public string BooksName { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }

        public Book(string customer,
                    string name,
                    string author,
                    double price,
                    int year)
        {
            this.CustomerName = customer;
            this.BooksName = name;
            this.Author = author;
            this.Price = price;
            this.Year = year;
        }


        public void AskQuestionCustomer()
        {
            Console.WriteLine($"Dear {this.CustomerName} you made an order succesfully1");
            Console.WriteLine($"Your order is: Books name is {this.BooksName}, \nAuthors name-{this.Author}, '\nPrice-{this.Price}$, \nYear of publishment-{this.Year}");
        }
        public void AskInfo()
        {
            Console.WriteLine($"Dear {this.CustomerName}! Do you buy it now?");
            string askInfo = Console.ReadLine()!;
            string result = askInfo switch
            {
                "yes" => $"Please Dear {this.CustomerName} one second we will pack this for you now!",
                "no" => $"Okay Dear {this.CustomerName} You are allways wellcome",
                _ => $"Please choose one the options "

            };
            Console.WriteLine(result);

        }



    }

}

