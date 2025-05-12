using System;

namespace Task2
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        private IMediator _mediator;
        public object IsBusyWithAircraft { get; private set; }

        public Runway(IMediator mediator)
        {
            _mediator = mediator;
        }

        public bool CheckIsActive()
        {
            return _mediator.IsRunwayActive(this);
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }
} 