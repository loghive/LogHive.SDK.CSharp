using LogHive.Model;
using LogHive.SDK.CSharp.Model;
using System.Threading.Tasks;

namespace LogHive.SDK.CSharp.Contracts
{
    /// <summary>
    /// push a event
    /// </summary>
    internal interface IEventChannelAPI
    {
        /// <summary>
        /// push a event
        /// </summary>
        public Task<EventPushFeedbackDto> AddEventAsync(EventDataSDKDto eventData);
    }
}