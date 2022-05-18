using System;

namespace Lab3{
    
    public class Segment{
    
        private Point pStart;
        private Point pEnd;

        public Segment(){
        
        }
    
        public Segment(Point pStart, Point pEnd){
            this.pStart = pStart;
            this.pEnd = pEnd;
        }
    
        public void Show(){
            Console.WriteLine("Отрезок с координатами: " + pStart + "-" + pEnd);
        }
    
        public double Length(){
            return pStart.Interval(pEnd);
        }
    }
}
