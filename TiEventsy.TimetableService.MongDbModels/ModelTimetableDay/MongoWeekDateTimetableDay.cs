using System;
using System.Collections.Generic;
using System.Linq;

namespace TiEventsy.TimetableService.MongoDB.Models.Timetable.ModelTimetableDay
{
    public class MongoWeekDateTimetableDay
    {
        public List<DayOfWeek> DayOfWeeksList { get; set; }

        public MongoWeekDateTimetableDay(List<DayOfWeek> dayOfWeeksList)
        {
            DayOfWeeksList = dayOfWeeksList;
        }

        public bool Proofreading()
        {
            return DayOfWeeksList.Any(day => day == DateTime.UtcNow.DayOfWeek);
        }
    }
}