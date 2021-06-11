using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.MainPage
{
    public class GetGroupsByLectorQ : ADTOQuery
    {
        public int Id { get; set; }

        public GetGroupsByLectorQ()
        {
        }

        public GetGroupsByLectorQ(int id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetGroupsByLectorQ)obj);
        }

        private bool Equals(GetGroupsByLectorQ other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            return hashCode.ToHashCode();
        }
    }
}