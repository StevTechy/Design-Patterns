using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LapTime lapTime = new LapTime();

            lapTime.RegisterObserver(new ElectronicBillboard());

            //Observers will see that a new lap time has been posted and act accordingly
            lapTime.SetLapTime(105.34f);

            Console.ReadKey();
        }
    }
}
