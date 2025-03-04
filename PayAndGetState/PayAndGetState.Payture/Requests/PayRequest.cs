using System;
using System.Collections.Generic;

namespace PayAndGetState.Payture.Requests
{
    public class PayRequest
    {
        public string Key { get; set; }
        public int Amount { get; set; }
        public string OrderId { get; set; }
        public string Pan { get; set; }
        public int EMonth { get; set; }
        public int EYear { get; set; }
        public string CardHolder { get; set; }
        public string SecureCode { get; set; }
        public string Ip { get; set; }
        public string Product { get; set; }

        public PayRequest(Guid orderId, string key, int amount, string pan, int eMonth, int eYear, string cardHolder, string secureCode, string ip, string product)
        {
            Key = key;
            Amount = amount;
            OrderId = orderId.ToString();
            Pan = pan;
            EMonth = eMonth;
            EYear = eYear;
            CardHolder = cardHolder;
            SecureCode = secureCode;
            Ip = ip;
            Product = product;
        }

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string>
            {
                { "Key", Key },
                { "Amount", Amount.ToString() },
                { "OrderId", OrderId },
                { "PayInfo", $"PAN={Pan};EMonth={EMonth:D2};EYear={EYear};CardHolder={CardHolder};SecureCode={SecureCode};OrderId={OrderId};Amount={Amount}" },
                { "CustomFields", $"IP={Ip};Product={Product}" }
            };
        }
    }
}
