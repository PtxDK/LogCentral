using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogCentral.Models
{
    public class LogEntry
    {
        public long Id { get; set; }
        public string ApplicationId { get; set; }
        public string TraceId { get; set; }
        public string Severity { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }


    }
}
