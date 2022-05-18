namespace Lab5.Task{
    public class Admin : Worker{
    
        public Admin(string name, string surname) : base(name, surname){
        
        }
    
        public override string GetJobName(){
            return "Администратор";
        }
    }
}
