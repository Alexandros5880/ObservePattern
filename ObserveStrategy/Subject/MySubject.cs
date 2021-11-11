﻿using ObservePattern.Observe;
using System.Collections.Generic;

namespace ObservePattern.Subject
{
    public class MySubject
    {
        List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(int value)
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(value);
            }
        }
    }
}