using System;
using System.Collections.Generic;

namespace Observer_Pattern
{
    class LapTime : Subject
    {
        private float _lapTime = 0.00f;

        public LapTime()
        {
            _observerList = new List<Observer>();
        }

        public override void NotifyObservers()
        {
            //This will cause the observers to react to a change in LapTime. Perhaps use this alongside the Strategy Pattern,
            //we can use an Interface as the expected parameter in the update function to allow flexibility with what kind of data we pass in
            foreach (Observer o in _observerList)
                o.Update();
        }

        public void SetLapTime(float newTime)
        {
            _lapTime = newTime;
            Console.WriteLine("New lap time: 1:00:57");
            NotifyObservers();
        }
    }
}
