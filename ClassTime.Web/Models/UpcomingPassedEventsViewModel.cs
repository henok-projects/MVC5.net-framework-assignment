namespace ClassTime.Web.Models
{
    using System.Collections.Generic;

    public class UpcomingPassedEventsViewModel
    {
        public IEnumerable<EventViewModel> UpcomingEvents { get; set; }
        
        public IEnumerable<EventViewModel> PassedEvents { get; set; }

        public IEnumerable<EventDetailsViewModel> EventDetails { get; set; }
    }
}