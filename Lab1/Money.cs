using System;

namespace Lab1{
    public class Money{

        private int denomination;
        private int count;
        
        public int Denomination{
            get{ return denomination; }
            set{ denomination = value; }
        }
        public int Count{
            get{ return count; }
            set{ count = value; }
        }

        public int Sum{
            get{ return denomination * count; }
        }

        public Money(int denomination, int count){
            this.denomination = denomination;
            this.count = count;
        }

        public void Show(){
            Console.WriteLine("Деньги:\n Номинал: " + denomination + "\n Количество купюр: " + count);
        }

        public bool Enough(int price){
            return denomination * count >= price;
        }

        public int GetCountGoods(int price){
            return (int) Math.Floor((double) denomination * count / price);
        }
    }
}