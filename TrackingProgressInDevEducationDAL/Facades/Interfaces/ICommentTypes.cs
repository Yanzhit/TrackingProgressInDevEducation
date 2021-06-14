using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ICommentTypes
    {
        public CType SetNewCType(CType cType);
        IEnumerable<CType> NullifyCTypes();
    }
}