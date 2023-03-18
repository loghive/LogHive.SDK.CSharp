using LogHive.Model;
using System.Threading.Tasks;

namespace LogHive.Contracts
{
    /// <summary>
    /// add a insight
    /// </summary>
    public interface IInsightChannelAPI
    {
        /// <summary>
        /// add a insight
        /// </summary>
        public Task<FeedbackDto> AddInsightAsync(InsightDataSDKDto eventData);
    }
}