using System;

namespace Lab1{
    class Program{

        static void Main(){
            /*
            Book book1 = new Book();
            book1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
            Book.SetPrice(12);
            book1.Show();
            Console.WriteLine(" Итоговая стоимость аренды: " + book1.PriceBook(3) + " р.");

            Book book2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013);
            book2.Show();

            Book book3 = new Book("Лермонтов М.Ю.", "Мцыри");
            book3.Show();
            */

            Triangle triangle = new Triangle(1, 2, 2);
            triangle.ShowSides();

            if(triangle.Exists()){
                Console.WriteLine(" Периметр: " + triangle.GetPerimeter());
                Console.WriteLine(" Площадь: " + triangle.GetArea());
            } else {
                Console.WriteLine("Треугольника с такими сторонами не существует!");
            }
        }
    }
}