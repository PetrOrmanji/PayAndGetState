using System;

namespace PayAndGetState.Objects
{
    public class Order
    {
        public Guid OrderId { get; }
        public string Key { get; }
        public int Amount { get;}
        public string State { get; private set; }

        public Order(Guid orderId, string key, int amount)
        {
            OrderId = orderId;
            Amount = amount;
            Key = key;
            State = "Undefined";
        }

        public void SetState(string state)
        {
            State = state;
        }
    }
}
