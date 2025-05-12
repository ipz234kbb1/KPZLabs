using System;

namespace Task1
{
    public abstract class SupportHandler
    {
        protected SupportHandler NextHandler { get; set; }

        public void SetNext(SupportHandler handler)
        {
            NextHandler = handler;
        }

        public abstract bool HandleRequest(string request);
    }
} 