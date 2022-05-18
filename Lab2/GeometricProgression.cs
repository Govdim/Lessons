namespace Lab2{
    public class GeometricProgression : Progression{
    
        private int b;
        private int q;

        public GeometricProgression(int b, int q){
            this.b = b;
            this.q = q;
        }

        public override int GetElement(int k){
            int element = b;

            for(int i = 1; i < k; i++){
                element *= q;
            }

            return element;
        }
    
        public override int SumElement(int k){
            int sum = 0;

            for(int i = 1; i <= k; i++){
                sum += GetElement(i);
            }
        
            return sum;
        }
    }
}
