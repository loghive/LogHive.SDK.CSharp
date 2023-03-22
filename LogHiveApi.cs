using LogHive.APIs;
using LogHive.Contracts;
using LogHive.Model;
using LogHive.SDK.CSharp.APIs;
using LogHive.SDK.CSharp.Contracts;
using LogHive.SDK.CSharp.Model;
using System.Threading.Tasks;

namespace LogHive.SDK.CSharp
{
    /// <summary>
    /// client to access the public api with the given key
    /// </summary>
    public class LogHiveApi
    {
        private readonly IEventChannelAPI _eventChannelAPI;
        private readonly IInsightChannelAPI _insightChannelAPI;

        /// <summary>
        /// Constructor fasade class API
        /// </summary>
        /// <param name="key">your personal api key</param>
        /// <param name="url">[optional] the url to the api endpoint</param>
        public LogHiveApi(string key, string url = "")
        {
            _eventChannelAPI = new EventChannelAPI(key, url);
            _insightChannelAPI = new InsightChannelAPI(key, url);
        }

        /// <summary>
        /// push a event
        /// </summary>
        /// <param name="project">name of the project</param>
        /// <param name="group">name of the group</param>
        /// <param name="eventName">name of the event</param>
        /// <param name="notify">optional: push mobile notification</param>
        /// <param name="description">optional description</param>
        /// <param name="tags">optional: add tags</param>
        /// <returns></returns>
        public async Task<FeedbackDto> AddEventAsync(string project, string group, string eventName, string description = "", bool notify = false, string tags = "")
        {
            var request = new EventDataSDKDto()
            {
                Project = project,
                Group = group,
                Event = eventName,
                Description = description,
                Notify = notify,
                Tags = tags
            };
            return await _eventChannelAPI.AddEventAsync(request);
        }

        /// <summary>
        /// push a insight
        /// </summary>
        /// <param name="project">name of the project</param>
        /// <param name="insight">name of the insight</param>
        /// <param name="value">value of the insight</param>
        /// <returns></returns>
        public async Task<FeedbackDto> AddInsightAsync(string project, string insight, double value)
        {
            var request = new InsightDataSDKDto()
            {
                Project = project,
                Insight = insight,
                Value = value
            };
            return await _insightChannelAPI.AddInsightAsync(request);
        }

        /// <summary>
        /// set system online
        /// </summary>
        /// <param name="project">name of the project</param>
        /// <param name="system">name of system</param>
        /// <returns></returns>
        public async Task<FeedbackDto> SetSystemOnlineAsync(string project, string system)
        {
            var request = new InsightDataSDKDto()
            {
                Project = project,
                Insight = system,
                Value = 1
            };
            return await _insightChannelAPI.AddInsightAsync(request);
        }

        /// <summary>
        /// set system offline
        /// </summary>
        /// <param name="project">name of the project</param>
        /// <param name="system">name of system</param>
        /// <returns></returns>
        public async Task<FeedbackDto> SetSystemOfflineAsync(string project, string system)
        {
            var request = new InsightDataSDKDto()
            {
                Project = project,
                Insight = system,
                Value = 0
            };
            return await _insightChannelAPI.AddInsightAsync(request);
        }
    }
}