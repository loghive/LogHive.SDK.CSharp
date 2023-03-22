using System;

namespace LogHive.Model
{
    public class InsightDataSDKDto
    {
        public string? Project { get; set; } = String.Empty;
        public string? Insight { get; set; } = String.Empty;
        public double? Value { get; set; }
    }
}