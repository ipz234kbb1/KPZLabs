using System;

namespace Task2
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
        bool IsRunwayActive(Runway runway);
    }
} 