using System;

namespace LogHive.Model
{
    public class EventPushFeedbackDto
    {
        public bool? Error { get; set; }
        public string? ErrorMessage { get; set; } = String.Empty;
        public int? ResponseCode { get; set; }
    }
}
