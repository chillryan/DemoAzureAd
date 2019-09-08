using System;
using System.ComponentModel.DataAnnotations;

namespace DemoAzureAd.Model
{
    public class LogEntry
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Date { get; private set; } = DateTime.Now;

        public string Content { get; set; }

        public string Title { get; set; }

        public AccessLevel AccessLevel {get;set;}
    }
}
