using System.Collections.Generic;

namespace TrackingProgressInDevEducationBLL
{
    public class Destinations<T>
    {
        public IEnumerable<T> Values { get; set; }
    }
}