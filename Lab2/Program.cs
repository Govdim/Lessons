using System;

namespace Lab2{
    class Program{

        static void Main(){
            Book book = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь",
                1234, 2013, 101, true);
            book.TakeItem();
            book.Show();
            
            Magazine magazine = new Magazine("О природе", 5,"Земля и мы", 2014, 1235, true);
            magazine.Show();
            
            Console.WriteLine("\nТестирование полиморфизма");
            
            Item item2 = book;
            item2.TakeItem();
            item2.Return();
            item2.Show();
            
            Item item3 = magazine;
            item3.TakeItem();
            item3.Return();
            item3.Show();

            
            ArithmeticProgression aProg = new ArithmeticProgression(5, 34);
            Console.WriteLine("\nАрифметическая прогрессия: a=5 d=34");
            Console.WriteLine("Элемент №100 = " + aProg.GetElement(100));
            Console.WriteLine("Сумма первых 5 элементов = " + aProg.SumElement(5) + "\n");
            
            GeometricProgression gProg = new GeometricProgression(3, 4);
            Console.WriteLine("Геометрическая прогрессия: b=3 q=4");
            Console.WriteLine("Элемент №12 = " + gProg.GetElement(12));
            Console.WriteLine("Сумма первых 3 элементов = " + gProg.SumElement(3));
            
            Console.ReadLine();
        }
    }
}
