namespace Lab4.Progression{
    
    public class ArithmeticProgression : IProgression{

        private int a;
        private int d;

        public ArithmeticProgression(int a, int d){
            this.a = a;
            this.d = d;
        }

        public int GetElement(int k){
            return a + d * (k - 1);
        }

        public int SumElement(int k){
            int sum = 0;

            for(int i = 1; i <= k; i++){
                sum += GetElement(i);
            }
        
            return sum;
        }
    }
}
