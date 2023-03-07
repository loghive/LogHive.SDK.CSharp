using LogHive.Model;
using LogHive.SDK.CSharp.Contracts;
using LogHive.SDK.CSharp.Model;
using System.Threading.Tasks;

namespace LogHive.SDK.CSharp.APIs
{
    internal class EventChannelAPI : LogHiveAPIBase, IEventChannelAPI
    {
        private static readonly string _endpoint = "event/add";

        public EventChannelAPI(string apiKey, string url = "") : base(apiKey, url)
        {
        }

        public async Task<EventPushFeedbackDto> AddEventAsync(EventDataSDKDto eventData)
        {
            var url = $"{_url}{_endpoint}";
            return await PostAsync(url, eventData);
        }
    }
}
