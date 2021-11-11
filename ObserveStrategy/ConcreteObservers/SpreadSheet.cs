using ObservePattern.Observe;
using System;

namespace ObservePattern.ConcreteObservers
{
    public class SpreadSheet : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"SpreadSheet got notified. Values: {value}");
        }
    }
}
