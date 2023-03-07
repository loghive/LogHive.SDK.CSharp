using System;

namespace LogHive.SDK.CSharp.Model
{
    public class EventDataSDKDto
    {
        public string? ProjectName { get; set; } = String.Empty;
        public string? GroupName { get; set; } = String.Empty;
        public string? EventName { get; set; } = String.Empty;
        public string? Description { get; set; } = String.Empty;
        public bool? Notify { get; set; }
        public string? Tags { get; set; } = String.Empty;
    }
}