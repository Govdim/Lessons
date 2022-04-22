namespace Lab5.Task;

public class Staff{

    private List<Worker> workers;

    public delegate void DismissDelegate();
    public static event DismissDelegate DismissDimon;

    public static void Dimon(){
        Console.WriteLine("Димооооон!!!");
    }
    
    public Staff(){
        workers = new List<Worker>();
    }

    public void Hire(Worker worker){
        workers.Add(worker);
        
        Console.WriteLine(worker.GetName() + " " + worker.GetSurName() + " нанят на должность - " + worker.GetJobName());
    }

    public void Dismiss(Worker worker){
        workers.Remove(worker);
        Console.WriteLine(worker.GetName() + " " + worker.GetSurName() + " уволен");

        if(worker.GetName() == "Дмитрий"){
            DismissDimon();
        }
    }

    public void Show(){
        Console.WriteLine("Работники:");

        foreach(Worker worker in workers){
            Console.WriteLine("  " + worker.GetName() + " " + worker.GetSurName() + " - должность: " + worker.GetJobName());
        }
    }
}
