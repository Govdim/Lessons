namespace Lab2;

public class ArithmeticProgression : Progression{

    private int a;
    private int d;

    public ArithmeticProgression(int a, int d){
        this.a = a;
        this.d = d;
    }

    public override int GetElement(int k){
        return a + d * (k - 1);
    }

    public override int SumElement(int k){
        int sum = 0;

        for(int i = 1; i <= k; i++){
            sum += GetElement(i);
        }
        
        return sum;
    }
}
