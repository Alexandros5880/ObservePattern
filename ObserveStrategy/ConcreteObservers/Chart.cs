using ObservePattern.ConcreteSubject;
using ObservePattern.Observe;
using System;

namespace ObservePattern.ConcreteObservers
{
    public class Chart : IObserver
    {
        private DataSource _dataSource;
        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine($"Chart got notifide. Value: {_dataSource.Value}");
        }
    }
}
