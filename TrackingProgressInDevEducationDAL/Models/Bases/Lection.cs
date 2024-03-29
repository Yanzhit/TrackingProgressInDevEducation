﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Lection : AbstractModel
    {
        public int GroupId { get; set; }
        public int LectorId { get; set; }
        public DateTime StartedOn { get; set; }

        public Lection()
        {
        }

        public Lection(int groupId, int lectorId, DateTime startedOn)
        {
            GroupId = groupId;
            LectorId = lectorId;
            StartedOn = startedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((Lection)obj);
        }

        private bool Equals(Lection other)
        {
            return GroupId == other.GroupId
                   && LectorId == other.LectorId
                   && StartedOn == other.StartedOn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GroupId, LectorId, StartedOn);
        }
    }
}
