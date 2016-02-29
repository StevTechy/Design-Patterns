using System;

namespace Observer_Pattern
{
    class ElectronicBillboard : Observer
    {
        public void Update()
        {
            Console.WriteLine("Electronic Billboard: Oh my god!! I have just been told a new lap time has been set!");
        }
    }
}
