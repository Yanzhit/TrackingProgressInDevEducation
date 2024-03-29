﻿using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Team : AbstractModel
    {
        public string Name { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

        public Team()
        {
        }

        public Team(string name, DateTime? from, DateTime? to)
        {
            Name = name;
            From = from;
            To = to;
        }

        public override bool Equals(object obj)
        {
            return Equals((Team)obj);
        }

        private bool Equals(Team other)
        {
            return Name == other.Name
                   && From == other.From
                   && To == other.To;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, From, To);
        }
    }
}
