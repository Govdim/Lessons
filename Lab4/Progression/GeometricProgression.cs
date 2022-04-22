namespace Lab4.Progression;

public class GeometricProgression : IProgression{
    
    private int b;
    private int q;

    public GeometricProgression(int b, int q){
        this.b = b;
        this.q = q;
    }

    public int GetElement(int k){
        int element = b;

        for(int i = 1; i < k; i++){
            element *= q;
        }

        return element;
    }
    
    public int SumElement(int k){
        int sum = 0;

        for(int i = 1; i <= k; i++){
            sum += GetElement(i);
        }
        
        return sum;
    }
}
