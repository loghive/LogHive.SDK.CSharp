using System;

namespace LogHive.Model
{
    public class InsightDataSDKDto
    {
        public string? ProjectName { get; set; } = String.Empty;
        public string? Name { get; set; } = String.Empty;
        public double? Value { get; set; }
    }
}