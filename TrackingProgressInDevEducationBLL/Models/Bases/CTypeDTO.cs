using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class CTypeDTO : ADTOAnswer
    {
        public string Name { get; set; }

        public CTypeDTO()
        {
        }

        public CTypeDTO(CType cType)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CType, CTypeDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            CTypeDTO tmpCTypeDTO = mapper.Map<CTypeDTO>(cType);

            this.Name = tmpCTypeDTO.Name;
        }

        public override bool Equals(object obj)
        {
            return Equals((CTypeDTO)obj);
        }

        private bool Equals(CTypeDTO other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}
