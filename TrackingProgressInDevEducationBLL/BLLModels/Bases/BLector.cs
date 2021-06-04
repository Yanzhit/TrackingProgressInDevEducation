using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BLector
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public BLector()
        {
        }

        public BLector(Lector lector)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Lector, BLector>());
            Mapper mapper = new Mapper(config);
            BLector tmpBLector = mapper.Map<BLector>(lector);

            this.FullName = tmpBLector.FullName;
            this.Email = tmpBLector.Email;
            this.Password = tmpBLector.Password;
        }
        public override bool Equals(object obj)
        {
            return Equals((BLector)obj);
        }

        private bool Equals(BLector other)
        {
            return FullName == other.FullName
                   && Email == other.Email
                   && Password == other.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FullName, Email, Password);
        }
    }
}
