using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BCType : BAbstractModel
    {
        public string Name { get; set; }

        public BCType()
        {
        }

        public BCType(CType cType)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CType, BCType>());
            Mapper mapper = new Mapper(config);

            BCType tmpBCType = new BCType();
            tmpBCType = mapper.Map<BCType>(cType);
            this.Name = tmpBCType.Name;
        }

        public override bool Equals(object obj)
        {
            return Equals((BCType)obj);
        }

        private bool Equals(BCType other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}
