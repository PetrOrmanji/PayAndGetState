using System;
using System.Xml.Linq;

namespace PayAndGetState.Payture.Responses
{
    public class PayResponse
    {
        public Guid OrderId { get; set; }
        public string Key { get; set; }
        public bool Success { get; set; }
        public int Amount { get; set; }

        public static PayResponse FromXml(string xml)
        {
            var doc = XDocument.Parse(xml);
            var payElement = doc.Root;

            if (payElement == null || payElement.Name != "Pay")
                throw new System.Exception("Некорректный XML-ответ");

            return new PayResponse
            {
                OrderId = Guid.Parse(payElement.Attribute("OrderId")?.Value),
                Key = payElement.Attribute("Key")?.Value,
                Success = payElement.Attribute("Success")?.Value == "True",
                Amount = int.TryParse(payElement.Attribute("Amount")?.Value, out int amount) ? amount : 0
            };
        }
    }
}
