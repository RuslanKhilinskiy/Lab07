using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) // Создание массива книг
        {
            Book[] books = new Book[3];
            books[0] = new Book();
            books[0].SetBook("Автор1", "Название1", 270, 1893);

            books[1] = new Book();
            books[1].SetBook("Автор2", "Название2", 312, 1723);

            books[2] = new Book();
            books[2].SetBook("Автор3", "Название3", 758, 2008);

            Array.Sort(books);

            Console.WriteLine("Отсортированные книги по году издания:");
            foreach (Book book in books)
            {
                book.Show();
            }
        }
    }
}
