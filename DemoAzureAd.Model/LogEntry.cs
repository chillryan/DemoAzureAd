using System;
using System.ComponentModel.DataAnnotations;

namespace DemoAzureAd.Model
{
    public class LogEntry
    {
        [Key]
        public Guid Id { get; set; }

        public AccessLevel AccessLevel { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; private set; } = DateTime.Now;

        public string Title { get; set; }
    }
}