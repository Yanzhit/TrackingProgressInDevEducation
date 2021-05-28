﻿using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyTeamStudent : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyTeamStudent()
        {
            Type = typeof(TeamStudent);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}