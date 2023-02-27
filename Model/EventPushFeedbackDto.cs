using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHive.Model
{
    public class EventPushFeedbackDto
    {
        public bool? Error { get; set; }
        public string? ErrorMessage { get; set; } = String.Empty;
        public int? ResponseCode { get; set; }
    }
}
