using System;

namespace _2
{
    public class Worker
    {
        
        private string Name { get; }
        
        private string Surname { get; }
      
        private int Rate { get; }
       
        private int Days { get; }
       


        public Worker()
        {
            Name = "Kostik";
            Surname = "Rusanov";
            Rate = 2000;
            Days = 31;
        }
        public void GetSalary()
        {
            Console.WriteLine($"Зарплата сотрудника {Name} {Surname} составляет {Rate * Days}");
        }


    }
}