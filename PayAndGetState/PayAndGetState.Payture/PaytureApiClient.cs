using System;
using System.Net.Http;
using System.Threading.Tasks;
using EnsureThat;
using PayAndGetState.Payture.Requests;
using PayAndGetState.Payture.Responses;

namespace PayAndGetState.Payture
{
    public class PaytureApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        private Uri PayUri => new Uri($"{_apiUrl}/Pay");
        private Uri GetStateUri => new Uri($"{_apiUrl}/GetState");

        public PaytureApiClient(string apiUrl)
        {
            EnsureArg.IsNotNullOrWhiteSpace(apiUrl, nameof(apiUrl));

            _apiUrl = apiUrl;
            _httpClient = new HttpClient();
        }

        public async Task<PayResponse> SendPaymentRequestAsync(PayRequest payRequest)
        {
            var content = new FormUrlEncodedContent(payRequest.ToDictionary());

            var response = await _httpClient.PostAsync(PayUri, content);
            var responseString = await response.Content.ReadAsStringAsync();

            return PayResponse.FromXml(responseString);
        }

        public async Task<GetStateResponse> GetPaymentStateAsync(GetStateRequest getStateRequest)
        {
            var content = new FormUrlEncodedContent(getStateRequest.ToDictionary());

            var response = await _httpClient.PostAsync(GetStateUri, content);
            var responseString = await response.Content.ReadAsStringAsync();

            return GetStateResponse.FromXml(responseString);
        }
    }
}
