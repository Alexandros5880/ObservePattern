using ObservePattern.ConcreteObservers;
using ObservePattern.ConcreteSubject;
using System;

namespace ObservePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource datashource = new DataSource();
            datashource.AddObserver(new Chart(datashource));
            datashource.AddObserver(new SpreadSheet(datashource));
            while(true)
            {
                Console.Write("\nEnter a Number: ");
                int value = int.Parse(Console.ReadLine());
                datashource.Value = value;
            }
        }
    }
}
