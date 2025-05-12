using System;

namespace Task2
{
    public class Aircraft
    {
        private IMediator _mediator;
        public string Name { get; private set; }
        public bool IsTakingOff { get; set; }

        public Aircraft(IMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
            IsTakingOff = false;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {Name} is requesting to land.");
            _mediator.Notify(this, "landing");
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {Name} is requesting to take off.");
            IsTakingOff = true;
            _mediator.Notify(this, "takeoff");
            IsTakingOff = false;
        }
    }
} 