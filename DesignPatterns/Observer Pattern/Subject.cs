using System.Collections.Generic;

namespace Observer_Pattern
{
    abstract class Subject
    {
        protected List<Observer> _observerList;

        public void RegisterObserver(Observer o)
        {
            _observerList.Add(o);
        }

        public void UnregisterObserver(Observer o)
        {
            _observerList.Remove(o);
        }

        public abstract void NotifyObservers();
    }
}
