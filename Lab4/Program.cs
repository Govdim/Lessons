using System;
using Lab4.Progression;

namespace Lab4{
    class Program{

        static void Main(){
            Magazine magazine = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            magazine.Show();
            magazine.IfSubs = true;
            magazine.Subs();
            
            Book book1 = new Book("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012, 106, true);
            Book book2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 104, true);
            Book book3 = new Book("Лермонтов М.Ю.", "Мцыри", "Искатель", 1235, 2018, 108, true);

            Item[] itmas = new Item[4];
            itmas[0] = book1;
            itmas[1] = book2;
            itmas[2] = book3;
            itmas[3] = magazine;
            Array.Sort(itmas);
            
            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach (Item x in itmas){
                x.Show();
            }
            
            
            
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
