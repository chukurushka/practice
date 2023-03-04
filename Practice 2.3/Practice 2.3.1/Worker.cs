using System;

namespace _2
{

    public class Worker
    {
        
        public string Name { get; }
        
        public string Surname { get; }

        public int Rate { get; }
    
        public int Days { get; }
        
                          
        public Worker()
        {
            Name = "Kostik";
            Surname = "Rusanov";
            Rate = 2000;
            Days = 31;
        }   
        public void GetSalary()
        {
            Console.WriteLine($"Зарплата сотрудника {Name} {Surname} составляет {Rate*Days}");
        }


    }
}