using System;
using System.Collections;
using TrackingProgressInDevEducationDAL.Repositories;
using Getter = TrackingProgressInDevEducationDAL.Senders.Getter;
using Remove = TrackingProgressInDevEducationDAL.Senders.Remove;
using Setter = TrackingProgressInDevEducationDAL.Senders.Setter;
using Update = TrackingProgressInDevEducationDAL.Senders.Update;
using Nullify = TrackingProgressInDevEducationDAL.Senders.Nullify;


namespace TrackingProgressInDevEducationDAL
{
    public class QueriesManager
    {
        public Getter Getter => new();
        public Setter Setter => new();
        public Update Update => new();
        public Remove Remove => new();
        public Nullify Nullify => new();
    }
}