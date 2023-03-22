using System;

namespace LogHive.SDK.CSharp.Model
{
    public class EventDataSDKDto
    {
        public string? Project { get; set; } = String.Empty;
        public string? Group { get; set; } = String.Empty;
        public string? Event { get; set; } = String.Empty;
        public string? Description { get; set; } = String.Empty;
        public bool? Notify { get; set; }
        public string? Tags { get; set; } = String.Empty;
    }
}