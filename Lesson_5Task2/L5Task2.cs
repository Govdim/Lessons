using System;

namespace Lesson_5Task2{
    public class L5Task2{

        static void Main(string[] args){
            Console.Write("Введите 3 стороны треугольника через пробел: ");
            int[] sides = Array.ConvertAll(Console.ReadLine().Split(" "), i => int.Parse(i));
            int perimeter = Perimeter(sides[0], sides[1], sides[2]);

            Console.WriteLine("Периметр треугольника: " + perimeter);
            Console.ReadLine();
        }

        static int Perimeter(int side1, int side2, int side3){
            return side1 + side2 + side3;
        }
    }
}
