using ObservePattern.ConcreteSubject;
using ObservePattern.Observe;
using System;

namespace ObservePattern.ConcreteObservers
{
    public class SpreadSheet : IObserver
    {
        private DataSource _dataSource;
        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine($"SpreadSheet got notified. Values: {_dataSource.Value}");
        }
    }
}
