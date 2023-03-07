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

        /// <summary>
        /// Constructor fasade class API
        /// </summary>
        /// <param name="key">your personal api key</param>
        /// <param name="url">[optional] the url to the api endpoint</param>
        public LogHiveApi(string key, string url = "")
        {
            _eventChannelAPI = new EventChannelAPI(key, url);
        }

        /// <summary>
        /// push a event
        /// </summary>
        /// <param name="projectName">name of the project</param>
        /// <param name="groupName">name of the group</param>
        /// <param name="eventName">name of the event</param>
        /// <param name="notify">optional: push mobile notification</param>
        /// <param name="description">optional description</param>
        /// <param name="tags">optional: add tags</param>
        /// <returns></returns>
        public async Task<EventPushFeedbackDto> AddEventAsync(string projectName, string groupName, string eventName, string description = "", bool notify = false, string tags = "")
        {
            var eventDs = new EventDataSDKDto()
            {
                ProjectName = projectName,
                GroupName = groupName,
                EventName = eventName,
                Description = description,
                Notify = notify,
                Tags = tags
            };
            return await _eventChannelAPI.AddEventAsync(eventDs);
        }
    }
}