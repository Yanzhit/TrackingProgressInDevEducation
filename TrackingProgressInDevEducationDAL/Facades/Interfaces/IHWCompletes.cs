using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface IHWCompletes
    {
        HWComplete SetNewHWComplete(HWComplete hWComplete);
        IEnumerable<HWComplete> GetHomeWorkProcedureScore();
        IEnumerable<HWComplete> NullifyHWComplete();
    }
}