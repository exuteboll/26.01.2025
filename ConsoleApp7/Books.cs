using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // 1) Создать класс Books («Книги»), содержащий следующие члены:

    //1. поля: название, автор, год выпуска, объем в листах.

    //2. метод Info, позволяющий выводить на экран всю информацию об объекте.

    //2) Добавить UML-диаграмму классов Book и Program.


    internal class Books
    {
        public string Name = "Трансферинг себя";
        public string Author = "Вадим Зеланд";
        public int Data = 2024;
        public int Page = 387;
        public void Info()
        {
            Console.WriteLine($"Название книги: {Name}\nАвтор книги: {Author}\nГод выпуска: {Data}\nОбъем страниц: {Page}");
        }
    }
}
