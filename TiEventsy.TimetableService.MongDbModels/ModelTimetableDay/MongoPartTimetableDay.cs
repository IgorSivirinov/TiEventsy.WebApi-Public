using System;

namespace TiEventsy.TimetableService.MongDbModels.ModelTimetableDay
{
    public class MongoPartTimetableDay
    {
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan StopTime { get; set; }
        public string Review { get; set; }

        public MongoPartTimetableDay(TimeSpan startTime)
        {
            StartTime = startTime;
        }
    }
}