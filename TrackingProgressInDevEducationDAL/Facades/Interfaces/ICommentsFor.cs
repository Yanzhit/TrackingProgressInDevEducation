using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ICommentsFor
    {
        CommentFor SetNewCFor();
        IEnumerable<CommentFor> NullifyCFor();
    }
}