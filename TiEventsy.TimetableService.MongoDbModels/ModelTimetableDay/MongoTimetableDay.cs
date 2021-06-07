﻿using System.Collections.Generic;

namespace TiEventsy.TimetableService.MongoDbModels.ModelTimetableDay
{
    public class MongoTimetableDay
    {
        public string Name { get; set; }

        public enum TypeDateTimetableDay
        {
            Certain,
            Recurrence,
            Week
        }

        public TypeDateTimetableDay EnumTypeDateTimetableDay { get; set; }

        public MongoCertainDateTimetableDay CertainDateTimetableDay{ get; set;}
        public MongoRecurrenceDateTimetableDay RecurrenceDateTimetableDay { get; set; }
        public MongoWeekDateTimetableDay WeekDateTimetableDay { get; set; }
        
        public List<MongoPartTimetableDay> PartsTimetableDay{ get; set; }

    }
}