namespace TrackingProgressInDevEducationBLL.Models.Verification
{
    public class UpdLectorA : ADTOAnswer
    {
        public bool IsActivated { get; set; }


        public UpdLectorA()
        {
        }

        public UpdLectorA(int id, bool isActivated)
        {
            Id = id;
            IsActivated = isActivated;
        }
    }
}