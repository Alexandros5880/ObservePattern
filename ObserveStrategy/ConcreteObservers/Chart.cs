using ObservePattern.Observe;
using System;

namespace ObservePattern.ConcreteObservers
{
    public class Chart : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"Chart got notifide. Value: {value}");
        }
    }
}
