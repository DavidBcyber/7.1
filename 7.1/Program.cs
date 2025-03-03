using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Program
    {
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            var nameTitle = title.Select(title => title);
            Console.WriteLine(nameTitle);

            var nameAuthor = author.Select(author => author);

            var sortedrPrice = prices.OrderBy(prices => prices);
            Console.WriteLine(sortedrPrice);

            var groubByGenre = genres.GroupBy(genres => genres);
            Console.WriteLine(groubByGenre);
        }
    }
}
