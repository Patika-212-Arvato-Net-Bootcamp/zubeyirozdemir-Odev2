using System;
using System.Collections.Generic;

namespace WebApi
{
    public class BootCamp
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<SubscriberInfo> Subscribers { get; set; }  // BootCamp participant list
        public DateTime StartTime { get; set; }    
        public DateTime FinishTime { get; set; }

    }
}
