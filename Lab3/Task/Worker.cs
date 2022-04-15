namespace Lab3.Task;

public abstract class Worker{

    private string name;
    private string surname;
    
    public Worker(string name, string surname){
        this.name = name;
        this.surname = surname;
    }

    public string GetName(){
        return name;
    }

    public string GetSurName(){
        return surname;
    }

    public abstract string GetJobName();
}
