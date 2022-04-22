using Lab5.Task;

namespace Lab5{
    class Program{

        static void Main(){
            Book book1 = new Book("Толстой Л.Н.", "Анна Каренина", "Знание", 1204, 2014, 103, true);
            Book book2 = new Book("Неш Т", "Программирование для профессионалов", "Вильямс", 1200, 2014, 108, true);
            
            Book.RetSrok += Operation.MetodObrabotchik;
            book1.ReturnSrok = true;
            book2.ReturnSrok = true;
            
            Console.WriteLine("\nКниги возвращены в срок:");
            book1.ProcessPaperbackBooks(Operation.PrintTitle);
            book2.ProcessPaperbackBooks(Operation.PrintTitle);
            
            
            
            Gamer gamer = new Gamer("Василий");
            Gamer.Bingo += Gamer.ShowBingo;
            for(int i = 1; i <= 6; i++){
                Console.WriteLine("Выпало количество очков " + gamer.SeansGame() + " для игрока по имени " + gamer);
            }
            
            
            
            Staff staff = new Staff();
            Staff.DismissDimon += Staff.Dimon;
            
            Admin admin = new Admin("Алексей", "Захаров");
            Engineer engineer1 = new Engineer("Дмитрий", "Комаров");
            Engineer engineer2 = new Engineer("Владимир", "Шевцов");
            Engineer engineer3 = new Engineer("Никита", "Ковтунов");
            
            staff.Hire(admin);
            staff.Hire(engineer1);
            staff.Hire(engineer2);
            staff.Hire(engineer3);
            staff.Dismiss(engineer1);
            
            Console.ReadLine();
        }
    }
}
