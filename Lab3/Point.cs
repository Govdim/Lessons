using System;

namespace Lab3{
    
    public class Point{
    
        private double x;
        private double y;

        public Point(){
        
        }
    
        public Point(double x, double y){
            this.x = x;
            this.y = y;
        }
    
        public void Show(){
            Console.WriteLine("Точка с координатами: (" + x + ";" + y + ")");
        }
    
        public double Interval(Point p){
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }
    
        public override string ToString(){
            return "(" + x + ";" + y + ")";
        }
    }
}
