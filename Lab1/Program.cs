using System;

namespace Lab1{
    class Program{

        static void Main(){
            Book book1 = new Book();
            book1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
            Book.SetPrice(12);
            book1.Show();
            Console.WriteLine(" Итоговая стоимость аренды: " + book1.PriceBook(3) + " р.");

            Book book2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013);
            book2.Show();

            Book book3 = new Book("Лермонтов М.Ю.", "Мцыри");
            book3.Show();
            
            
            
            Triangle triangle = new Triangle(1, 2, 2);
            triangle.ShowSides();

            if(triangle.Exists()){
                Console.WriteLine(" Периметр: " + triangle.GetPerimeter());
                Console.WriteLine(" Площадь: " + triangle.GetArea());
            } else {
                Console.WriteLine("Треугольника с такими сторонами не существует!");
            }
            
            
            
            Money money = new Money(100, 8);
            money.Show();
            Console.WriteLine(" Общая сумма: " + money.Sum);

            int price = 350;
            if(money.Enough(price)){
                Console.WriteLine("Денег достаточно для покупки товара на сумму " + price);
                Console.WriteLine("На эту сумму можно купить " + money.GetCountGoods(price) + " единиц товара");
            } else {
                Console.WriteLine("Денег недостаточно для покупки товара на сумму " + price);
            }
        }
    }
}
