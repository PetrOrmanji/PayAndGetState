using System;
using System.Collections.Generic;

namespace PayAndGetState.Payture.Requests
{
    public class GetStateRequest
    {
        public string Key { get; set; }
        public Guid OrderId { get; set; }

        public GetStateRequest(string key, Guid orderId)
        {
            Key = key;
            OrderId = orderId;
        }

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string>
            {
                { "Key", Key },
                { "OrderId", OrderId.ToString() }
            };
        }
    }
}
