using TrackingProgressInDevEducationBLL.Answers;
using TrackingProgressInDevEducationBLL.Queries;

namespace TrackingProgressInDevEducationBLL
{
    public class BLLManager
    {
        public QSignIns QSignIns => new();
        public ASignIns ASignIns => new();
    }
}