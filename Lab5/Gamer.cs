namespace Lab5;

public class Gamer{
    
    string name;
    Dice dice;

    public delegate void BingoDelegate();
    public static event BingoDelegate Bingo;
    
    public Gamer(string name){
        this.name = name;
        dice = new Dice();
    }
    
    public int SeansGame(){
        int point = dice.Roll();
        if(point == 6){
            Bingo();
        }
        
        return point;
    }

    public static void ShowBingo(){
        Console.WriteLine("Бинго! 6 очков!");
    }
    
    public override string ToString(){
        return name;
    }
}
