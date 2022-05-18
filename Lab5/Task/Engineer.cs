namespace Lab5.Task{
    
    public class Engineer : Worker{
    
        public Engineer(string name, string surname) : base(name, surname){
        
        }
    
        public override string GetJobName(){
            return "Инженер";
        }
    }
}
