﻿namespace TrackingProgressInDevEducationDAL.Models
{
    public abstract  class AbstractModel
    {
        public int Id { get; }
        protected AbstractModel()
        {
        }
        protected AbstractModel(AbstractModel model)
        {
            Id = model.Id;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return -1;
        }
    }
}