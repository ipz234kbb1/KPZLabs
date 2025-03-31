using System;

namespace WarehouseManagementSystem
{
    public class Money
    {
        private int _wholePart;
        private int _fractionalPart; 
        private string _currencySymbol;
        
        public Money(int wholePart = 0, int fractionalPart = 0, string currencySymbol = "₴")
        {
            _wholePart = wholePart;
            _fractionalPart = fractionalPart;
            _currencySymbol = currencySymbol;
            NormalizeAmount();
        }
        
        private void NormalizeAmount()
        {
            if (_fractionalPart >= 100)
            {
                _wholePart += _fractionalPart / 100;
                _fractionalPart %= 100;
            }
        }
        
        public decimal GetAmount()
        {
            return _wholePart + (decimal)_fractionalPart / 100;
        }
        
        public void SetAmount(int wholePart, int fractionalPart)
        {
            _wholePart = wholePart;
            _fractionalPart = fractionalPart;
            NormalizeAmount();
        }
        
        public virtual string Display()
        {
            return $"{_currencySymbol}{_wholePart}.{_fractionalPart:D2}";
        }
        
        public Money Clone()
        {
            return new Money(_wholePart, _fractionalPart, _currencySymbol);
        }
    }
    
    public class UahMoney : Money
    {
        public UahMoney(int wholePart = 0, int fractionalPart = 0) 
            : base(wholePart, fractionalPart, "₴")
        {
        }
        
        public override string Display()
        {
            return $"{base.Display()} грн.";
        }
    }
}