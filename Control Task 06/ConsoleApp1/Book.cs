using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book : IComparable
    {
        private string author;
        private string title;
        private int pages;
        private int year;
        public void SetBook(string author, string title, int pages, int year) //метод, устанавливающий значения характеристик книги
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }
        public void Show() //метод, выводящий на экран информацию о книге 
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n", author, title, year, pages);
        }
        int IComparable.CompareTo(object obj)  // реализация метода CompareTo интерфейса IComparable
        {
            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }
    }
}
