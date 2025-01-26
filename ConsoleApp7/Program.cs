using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Создать класс Books («Книги»), содержащий следующие члены:

            //1. поля: название, автор, год выпуска, объем в листах.

            //2. метод Info, позволяющий выводить на экран всю информацию об объекте.

            //2) Добавить UML-диаграмму классов Book и Program.


            Books books = new Books();
            string name = books.Name;
            string author = books.Author;
            int data = books.Data;
            int page = books.Page;
            books.Info();
            Console.ReadKey();
        }
    }
}
