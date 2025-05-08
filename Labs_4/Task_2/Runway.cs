using System;


namespace Task_2
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusy => CurrentAircraft != null;
        public Aircraft CurrentAircraft; // без ?

        public void HighLightRed()
        {
            Console.WriteLine($"Злітна смуга {Id} зайнята!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Злітна смуга {Id} вільна!");
        }
    }
}



