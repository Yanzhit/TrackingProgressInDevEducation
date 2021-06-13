using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Models.Others
{
    public class SetNewGroupJ : Group
    {
        public int? GroupId { get; set; }
        public int LectorId { get; set; }

        public SetNewGroupJ()
        {
        }

        public SetNewGroupJ(SetNewGroupJ model) : base(model)
        {
            GroupId = model.GroupId;
            LectorId = model.LectorId;
        }
    }
}