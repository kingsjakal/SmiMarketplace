using System;
using Smi.Core.Events;
using Smi.Services.Events;

namespace Smi.Web.MVC.Tests.Events
{
    public class DateTimeConsumer : IConsumer<DateTime>
    {
        public void HandleEvent(DateTime eventMessage)
        {
            DateTime = eventMessage;
        }

        // For testing
        public static DateTime DateTime { get; set; }
    }
}
