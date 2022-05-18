namespace Lab3{
    public class Gamer{
    
        string name;
        Dice dice;
    
        public Gamer(string name){
            this.name = name;
            dice = new Dice();
        }
    
        public int SeansGame(){
            return dice.Roll();
        }
    
        public override string ToString(){
            return name;
        }
    }
}
