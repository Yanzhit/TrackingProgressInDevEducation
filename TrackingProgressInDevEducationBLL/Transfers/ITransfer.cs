using System;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public interface ITransfer
    {
        Type Query { get; set; }
        Type Base { get; set; }
        Type Answer { get; set; }
    }
}