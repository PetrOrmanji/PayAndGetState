using System.Xml.Linq;

namespace PayAndGetState.Payture.Responses
{
    public class GetStateResponse
    {
        public bool Success { get; set; }
        public string OrderId { get; set; }
        public string State { get; set; }
        public bool Forwarded { get; set; }
        public string MerchantContract { get; set; }
        public int Amount { get; set; }
        public string Rrn { get; set; }

        public static GetStateResponse FromXml(string xml)
        {
            var doc = XDocument.Parse(xml);
            var stateElement = doc.Root;

            if (stateElement == null || stateElement.Name != "GetState")
                throw new System.Exception("Некорректный XML-ответ");

            return new GetStateResponse
            {
                Success = stateElement.Attribute("Success")?.Value == "True",
                OrderId = stateElement.Attribute("OrderId")?.Value,
                State = stateElement.Attribute("State")?.Value,
                Forwarded = stateElement.Attribute("Forwarded")?.Value == "True",
                MerchantContract = stateElement.Attribute("MerchantContract")?.Value,
                Amount = int.TryParse(stateElement.Attribute("Amount")?.Value, out int amount) ? amount : 0,
                Rrn = stateElement.Attribute("RRN")?.Value
            };
        }
    }
}
