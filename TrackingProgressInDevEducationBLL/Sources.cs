using System.Collections.Generic;

namespace TrackingProgressInDevEducationBLL
{
    public class Sources<T>
    {
        public IEnumerable<T> Values { get; set; } 
    }
}