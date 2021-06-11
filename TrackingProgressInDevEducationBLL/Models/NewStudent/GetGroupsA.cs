namespace TrackingProgressInDevEducationBLL.Models.NewStudent
{
    public class GetGroupsA : ADTOAnswer
    {
        public string Name { get; set; }

        public GetGroupsA()
        {
        }

        public GetGroupsA(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetGroupsA)obj);
        }

        private bool Equals(GetGroupsA other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}