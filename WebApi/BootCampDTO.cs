using System;

namespace WebApi
{
    public class BootCampDTO //DTO data transfer object
    {
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
    }
}
