using System;

namespace Lesson_5Task1{
    public class L5Task1{

        static void Main(string[] args){
            Console.Write("Введите 3 стороны треугольника через пробел: ");
            int[] sides = Array.ConvertAll(Console.ReadLine().Split(" "), i => int.Parse(i));
            Perimeter(sides[0], sides[1], sides[2]);

            Console.ReadLine();
        }

        static void Perimeter(int side1, int side2, int side3){
            int perimeter = side1 + side2 + side3;
        }
    }
}
