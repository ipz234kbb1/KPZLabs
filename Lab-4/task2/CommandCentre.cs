using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class CommandCentre : IMediator
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private Dictionary<Runway, Aircraft> _runwayAssignments = new Dictionary<Runway, Aircraft>();

        public void RegisterRunway(Runway runway)
        {
            _runways.Add(runway);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public bool IsRunwayActive(Runway runway)
        {
            if (_runwayAssignments.TryGetValue(runway, out Aircraft aircraft))
            {
                return aircraft.IsTakingOff;
            }
            return false;
        }

        public void Notify(object sender, string ev)
        {
            if (sender is Aircraft aircraft)
            {
                if (ev == "landing")
                {
                    HandleAircraftLanding(aircraft);
                }
                else if (ev == "takeoff")
                {
                    HandleAircraftTakeoff(aircraft);
                }
            }
        }

        private void HandleAircraftLanding(Aircraft aircraft)
        {
            Console.WriteLine($"Checking runways for {aircraft.Name}.");
            
            var availableRunway = _runways.FirstOrDefault(r => !_runwayAssignments.ContainsKey(r));
            
            if (availableRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                _runwayAssignments[availableRunway] = aircraft;
                availableRunway.HighLightRed();
            }
            else
            {
                Console.WriteLine($"Could not land, all runways are busy.");
            }
        }

        private void HandleAircraftTakeoff(Aircraft aircraft)
        {
            var runway = _runwayAssignments.FirstOrDefault(x => x.Value == aircraft).Key;
            
            if (runway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
                _runwayAssignments.Remove(runway);
                runway.HighLightGreen();
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not currently on any runway.");
            }
        }
    }
} 