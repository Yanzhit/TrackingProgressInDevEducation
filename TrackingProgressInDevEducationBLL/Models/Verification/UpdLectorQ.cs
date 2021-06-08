namespace TrackingProgressInDevEducationBLL.Models.Verification
{
    public class UpdLectorQ : ADTOQuery
    {
        public int Id { get; set; }
        public bool IsActivated { get; set; }

        public UpdLectorQ()
        {
        }

        public UpdLectorQ(int id, bool isActivated)
        {
            Id = id;
            IsActivated = isActivated;
        }
    }
}