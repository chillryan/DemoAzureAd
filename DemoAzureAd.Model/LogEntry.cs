using System;

namespace DemoAzureAd.Model
{
    public class LogEntry
    {
        public DateTime Date { get; private set; } = DateTime.Now;

        public string Content { get; set; }

        public string Title { get; set; }

        public AccessLevel AccessLevel {get;set;}
    }
}
