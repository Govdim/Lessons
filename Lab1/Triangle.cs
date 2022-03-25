using System;

namespace Lab1{
    public class Triangle{

        private int a;
        private int b;
        private int c;

        public Triangle(int a, int b, int c){
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool Exists(){
            return a < b + c && b < a + c && c < a + b;
        }

        public void ShowSides(){
            Console.WriteLine("Треугольник:\n Сторона a: " + a + "\n Сторона b: " + b + "\n Сторона c: " + c);
        }

        public int GetPerimeter(){
            return a + b + c;
        }

        public double GetArea(){
            var p = (double) GetPerimeter() / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }
    }
}
