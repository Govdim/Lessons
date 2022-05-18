using System;
using System.Collections.Generic;

namespace Lab3.Task{
    
    public class Staff{

        private List<Worker> workers;

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
        }

        public void Show(){
            Console.WriteLine("Работники:");

            foreach(Worker worker in workers){
                Console.WriteLine("  " + worker.GetName() + " " + worker.GetSurName() + " - должность: " + worker.GetJobName());
            }
        }
    }
}
