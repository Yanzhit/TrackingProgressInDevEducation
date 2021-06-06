using System.Collections.Generic;

namespace TrackingProgressInDevEducationBLL
{
    /// <summary>
    /// Не трогать
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Sources<T>
    {
        public IEnumerable<T> Values { get; set; }
    }
}