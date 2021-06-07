using System;
using System.Collections.Generic;
using System.Linq;

namespace TiEventsy.TimetableService.MongoDbModels.ModelTimetableDay
{
    public class MongoCertainDateTimetableDay
    {
        public List<DateTime> Dates  { get; set; }

        public MongoCertainDateTimetableDay (List<DateTime> dates)
        {
            Dates = dates;
        }
        
        public bool Proofreading()
        {
            return Dates.Any(date => date.TimeOfDay.TotalDays == DateTime.UtcNow.TimeOfDay.TotalDays);
        }
    }
}