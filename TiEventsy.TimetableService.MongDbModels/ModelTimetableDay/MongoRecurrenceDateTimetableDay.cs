using System;

namespace TiEventsy.TimetableService.MongDbModels.ModelTimetableDay
{
    public class MongoRecurrenceDateTimetableDay
    {
        public int RecurrenceDay { get; set; }
        public DateTime DateStart { get; set; }

        public MongoRecurrenceDateTimetableDay(int recurrenceDay, DateTime dateStart)
        {
            RecurrenceDay = recurrenceDay;
            DateStart = dateStart;
        }
        public bool Proofreading()
        {

            if (DateTime.UtcNow.TimeOfDay.TotalDays >= DateStart.TimeOfDay.TotalDays)
                return (DateTime.UtcNow.TimeOfDay.TotalDays - DateStart.TimeOfDay.TotalDays) % RecurrenceDay == 0;
            return false;
        }
    }
}