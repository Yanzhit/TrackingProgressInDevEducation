using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Lector : AbstractModel
    {
        public string Login { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActivated { get; set; }

        public Lector()
        {
        }

        public Lector(Lector lector) : base(lector)
        {
            Login = lector.Login;
            FullName = lector.FullName;
            Email = lector.Email;
            Password = lector.Password;
            IsActivated = lector.IsActivated;
        }
        public Lector(object obj) : base(obj)
        {
            var lector = (Lector) obj;
            Login = lector.Login;
            FullName = lector.FullName;
            Email = lector.Email;
            Password = lector.Password;
            IsActivated = lector.IsActivated;
        }

        public override bool Equals(object obj)
        {
            return Equals((Lector)obj);
        }

        private bool Equals(Lector other)
        {
            return Id == other.Id
                   && Login == other.Login
                   && FullName == other.FullName
                   && Email == other.Email
                   && Password == other.Password
                   && IsActivated == other.IsActivated;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Login);
            hashCode.Add(FullName);
            hashCode.Add(Email);
            hashCode.Add(Password);
            hashCode.Add(IsActivated);
            return hashCode.ToHashCode();
        }
    }
}
