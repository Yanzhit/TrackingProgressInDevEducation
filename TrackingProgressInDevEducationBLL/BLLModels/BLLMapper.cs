using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationBLL.BLLModels.Bases;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels
{
    public class BLLMapper
    {
        public class DTOToBLL
        {
            public BCity CityToBCity(City city)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<City, BCity>());
                Mapper mapper = new Mapper(config);
                BCity tmpBCity = mapper.Map<BCity>(city);
                return tmpBCity;
            }

            public List<BCity> CitiesToBCities(List<City> cities)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<City, BCity>());
                Mapper mapper = new Mapper(config);
                List<BCity> tmpBCities = mapper.Map<List<BCity>>(cities);
                return tmpBCities;
            }

            public BComment CommentToBComment(Comment comment)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, BComment>());
                Mapper mapper = new Mapper(config);
                BComment tmpBComment = mapper.Map<BComment>(comment);
                return tmpBComment;
            }

            public List<BComment> CommentsToBComments(List<Comment> comments)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, BComment>());
                Mapper mapper = new Mapper(config);
                List<BComment> tmpBComments = mapper.Map<List<BComment>>(comments);
                return tmpBComments;
            }

            public BCommentFor CommentForToBCommentFor(CommentFor commentFor)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, BComment>());
                Mapper mapper = new Mapper(config);
                BCommentFor tmpBCommentFor = mapper.Map<BCommentFor>(commentFor);
                return tmpBCommentFor;
            }

            public List<BCommentFor> CommentsForToBCommentsFor(List<CommentFor> commentsFor)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<CommentFor, BCommentFor>());
                Mapper mapper = new Mapper(config);
                List<BCommentFor> tmpBComments = mapper.Map<List<BCommentFor>>(commentsFor);
                return tmpBComments;
            }

            public BCourse CourseToBCourse(Course course)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, BCourse>());
                Mapper mapper = new Mapper(config);
                BCourse tmpBCourse = mapper.Map<BCourse>(course);
                return tmpBCourse;
            }

            public List<BCourse> CoursesToBCourses(List<Course> courses)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, BCourse>());
                Mapper mapper = new Mapper(config);
                List<BCourse> tmpBCourses = mapper.Map<List<BCourse>>(courses);
                return tmpBCourses;
            }

            public BCType CTypeToBCType(CType cType)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<CType, BCType>());
                Mapper mapper = new Mapper(config);
                BCType tmpBCType = mapper.Map<BCType>(cType);
                return tmpBCType;
            }

            public List<BCType> CTypesToBCTypes(List<CType> cTypes)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<CType, BCType>());
                Mapper mapper = new Mapper(config);
                List<BCType> tmpBCTypes = mapper.Map<List<BCType>>(cTypes);
                return tmpBCTypes;
            }

            public BGroup GroupToBGroup(Group group)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, BGroup>());
                Mapper mapper = new Mapper(config);
                BGroup tmpBGroup = mapper.Map<BGroup>(group);
                return tmpBGroup;
            }

            public List<BGroup> GroupsToBGroups(List<Group> groups)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, BGroup>());
                Mapper mapper = new Mapper(config);
                List<BGroup> tmpBGroups = mapper.Map<List<BGroup>>(groups);
                return tmpBGroups;
            }

            public BHomework HomeworkToBHomework(Homework homework)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Homework, BHomework>());
                Mapper mapper = new Mapper(config);
                BHomework tmpBHomework = mapper.Map<BHomework>(homework);
                return tmpBHomework;
            }

            public List<BHomework> HomeworksToBHomeworks(List<Homework> homeworks)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Homework, BHomework>());
                Mapper mapper = new Mapper(config);
                List<BHomework> tmpBHomeworks = mapper.Map<List<BHomework>>(homeworks);
                return tmpBHomeworks;
            }

            public BHWComplete HWCompleteToBHWComplete(HWComplete hwComplete)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HWComplete, BHWComplete>());
                Mapper mapper = new Mapper(config);
                BHWComplete tmpBHomework = mapper.Map<BHWComplete>(hwComplete);
                return tmpBHomework;
            }
            public List<BHWComplete> HWCompletesToBHWCompletes(List<HWComplete> hwCompletes)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HWComplete, BHWComplete>());
                Mapper mapper = new Mapper(config);
                List<BHWComplete> tmpBHomeworks = mapper.Map<List<BHWComplete>>(hwCompletes);
                return tmpBHomeworks;
            }

            public BHWGroup HWGroupToBHWGroup(HWGroup hwGroup)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HWGroup, BHWGroup>());
                Mapper mapper = new Mapper(config);
                BHWGroup tmpBHomework = mapper.Map<BHWGroup>(hwGroup);
                return tmpBHomework;
            }
            public List<BHWGroup> HWGroupToBHWGroup(List<HWGroup> hwGroups)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HWGroup, BHWGroup>());
                Mapper mapper = new Mapper(config);
                List<BHWGroup> tmpBHomeworks = mapper.Map<List<BHWGroup>>(hwGroups);
                return tmpBHomeworks;
            }

            public BLection LectionToBLection(Lection lection)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Lection, BLection>());
                Mapper mapper = new Mapper(config);
                BLection tmpBHomework = mapper.Map<BLection>(lection);
                return tmpBHomework;
            }
            public List<BLection> LectionsToBLections(List<Lection> lections)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Lection, BLection>());
                Mapper mapper = new Mapper(config);
                List<BLection> tmpBHomeworks = mapper.Map<List<BLection>>(lections);
                return tmpBHomeworks;
            }

            public BLector LectorToBLector(Lector lector)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Lector, BLector>());
                Mapper mapper = new Mapper(config);
                BLector tmpBHomework = mapper.Map<BLector>(lector);
                return tmpBHomework;
            }

            public List<BLector> LectorsToBLectors(List<Lector> lectors)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Lector, BLector>());
                Mapper mapper = new Mapper(config);
                List<BLector> tmpBHomeworks = mapper.Map<List<BLector>>(lectors);
                return tmpBHomeworks;
            }

            public BLectorCourse LectorCourseBLectorCourse(LectorCourse lectorCourse)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorCourse, BLectorCourse>());
                Mapper mapper = new Mapper(config);
                BLectorCourse tmpBHomework = mapper.Map<BLectorCourse>(lectorCourse);
                return tmpBHomework;
            }

            public List<BLectorCourse> LectorCourseBLectorCourse(List<LectorCourse> lectorCourses)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorCourse, BLectorCourse>());
                Mapper mapper = new Mapper(config);
                List<BLectorCourse> tmpBHomeworks = mapper.Map<List<BLectorCourse>>(lectorCourses);
                return tmpBHomeworks;
            }

            public BLectorGroup LectorGroupToBLectorGroup(LectorGroup lectorGroup)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorGroup, BLectorGroup>());
                Mapper mapper = new Mapper(config);
                BLectorGroup tmpBHomework = mapper.Map<BLectorGroup>(lectorGroup);
                return tmpBHomework;
            }

            public List<BLectorGroup> LectorGroupsToBLectorGroups(List<LectorGroup> lectorGroups)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorGroup, BLectorGroup>());
                Mapper mapper = new Mapper(config);
                List<BLectorGroup> tmpBHomeworks = mapper.Map<List<BLectorGroup>>(lectorGroups);
                return tmpBHomeworks;
            }

            public BPayment PaymentToBPayment(Payment payment)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Payment, BPayment>());
                Mapper mapper = new Mapper(config);
                BPayment tmpBHomework = mapper.Map<BPayment>(payment);
                return tmpBHomework;
            }

            public List<BPayment> PaymentToBPayment(List<Payment> payments)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Payment, BPayment>());
                Mapper mapper = new Mapper(config);
                List<BPayment> tmpBHomeworks = mapper.Map<List<BPayment>>(payments);
                return tmpBHomeworks;
            }
        }

        public class BLLToDTO
        {
            public City BCityToCity(BCity bCity)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<BCity, City>());
                Mapper mapper = new Mapper(config);
                City tmpCity = mapper.Map<City>(bCity);
                return tmpCity;
            }

        }
    }
}
