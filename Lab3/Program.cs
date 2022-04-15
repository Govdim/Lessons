using Lab3.Task;

namespace Lab3{
    class Program{

        static void Main(){
            Point point1 = new Point();
            point1.Show();
            Point point2 = new Point(12, 13);
            point2.Show();
            
            Segment segment = new Segment(point1, point2);
            segment.Show();
            double d = segment.Length();
            Console.WriteLine("Длина отрезка: " + d + "\n");
            
            
            
            Gamer gamer = new Gamer("Василий");
            for(int i = 1; i <= 6; i++){
                Console.WriteLine("Выпало количество очков " + gamer.SeansGame() + " для игрока по имени " + gamer);
            }



            Staff staff = new Staff();
            Admin admin = new Admin("Алексей", "Захаров");
            Engineer engineer1 = new Engineer("Василий", "Комаров");
            Engineer engineer2 = new Engineer("Владимир", "Шевцов");
            Engineer engineer3 = new Engineer("Никита", "Ковтунов");
            
            staff.Hire(admin);
            staff.Hire(engineer1);
            staff.Hire(engineer2);
            staff.Hire(engineer3);
            Console.WriteLine();
            staff.Show();
            Console.WriteLine();
            staff.Dismiss(engineer1);
            staff.Show();

            Console.ReadLine();
        }
    }
}
