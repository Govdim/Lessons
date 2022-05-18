using System;

namespace Lab4{
    
    public class Magazine : Item, IPubs{
    
        private string volume;
        private int number;
        private string title;
        private int year;
    
        public bool IfSubs { get; set; }
    
        public Magazine(){
        
        }
    
        public Magazine(string volume, int number, string title, int year,
            long invNumber, bool taken) : base(invNumber, taken){
        
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }
    
        public override void Return(){
            taken = true;
        }
    
        public override void Show(){
            Console.WriteLine("\nЖурнал:\n Том: " + volume + "\n Номер: " + number + 
                              "\n Название: " + title + "\n Год выпуска: " + year);
            base.Show();
        }
    
        public void Subs(){
            Console.WriteLine("Подписка на журнал '" + title +"': " + IfSubs + ".");
        }
    }
}
