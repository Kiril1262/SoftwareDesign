using System;
using System.Collections.Generic;
using System.Linq;


namespace Task_2
{
    class CommandCentre
    {
        private readonly List<Runway> _runways;
        private readonly List<Aircraft> _aircrafts;

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            _runways = new List<Runway>(runways);
            _aircrafts = new List<Aircraft>(aircrafts);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            Console.WriteLine($"Літак {aircraft.Name} запитує посадку.");
            var freeRunway = _runways.FirstOrDefault(r => !r.IsBusy);
            if (freeRunway != null)
            {
                freeRunway.CurrentAircraft = aircraft;
                freeRunway.HighLightRed();
                Console.WriteLine($"Літак {aircraft.Name} успішно приземлився на смугу {freeRunway.Id}.");
            }
            else
            {
                Console.WriteLine($"Немає доступної смуги для посадки літака {aircraft.Name}.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            var runway = _runways.FirstOrDefault(r => r.CurrentAircraft == aircraft);
            if (runway != null)
            {
                runway.CurrentAircraft = null;
                runway.HighLightGreen();
                Console.WriteLine($"Літак {aircraft.Name} злетів зі смуги {runway.Id}.");
            }
            else
            {
                Console.WriteLine($"Літак {aircraft.Name} не знаходиться на жодній смузі.");
            }
        }
    }
}

