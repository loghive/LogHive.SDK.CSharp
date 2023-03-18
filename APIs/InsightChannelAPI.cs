using LogHive.Contracts;
using LogHive.Model;
using LogHive.SDK.CSharp.APIs;
using System.Threading.Tasks;

namespace LogHive.APIs
{
    internal class InsightChannelAPI : LogHiveAPIBase, IInsightChannelAPI
    {
        private static readonly string _endpoint = "insight/add";

        public InsightChannelAPI(string apiKey, string url = "") : base(apiKey, url)
        {
        }

        public async Task<FeedbackDto> AddInsightAsync(InsightDataSDKDto request)
        {
            var url = $"{_url}{_endpoint}";
            return await PostAsync(url, request);
        }
    }
}