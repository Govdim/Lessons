using System;

namespace Lab5{
    public abstract class Item{

        protected long invNumber;
        protected bool taken;

        public Item(){
            taken = true;
        }

        public Item(long invNumber, bool taken){
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public bool IsAvailable(){
            return taken;
        }

        public long GetInvNumber(){
            return invNumber;
        }

        private void Take(){
            taken = false;
        }

        public abstract void Return();

        public virtual void Show(){
            Console.WriteLine("Состояние единицы хранения:\n Инвентарный номер: " + invNumber + "\n Наличие: " + taken);
        }

        public void TakeItem(){
            if(IsAvailable()){
                Take();
            }
        }
    }
}
