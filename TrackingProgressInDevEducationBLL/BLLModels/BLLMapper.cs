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
            BHWComplete tmpHWBComplete = mapper.Map<BHWComplete>(hwComplete);
            return tmpHWBComplete;
        }
        public List<BHWComplete> HWCompletesToBHWCompletes(List<HWComplete> hwCompletes)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HWComplete, BHWComplete>());
            Mapper mapper = new Mapper(config);
            List<BHWComplete> tmpHWBCompletes = mapper.Map<List<BHWComplete>>(hwCompletes);
            return tmpHWBCompletes;
        }

        public BHWGroup HWGroupToBHWGroup(HWGroup hwGroup)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HWGroup, BHWGroup>());
            Mapper mapper = new Mapper(config);
            BHWGroup tmpBHWGroup = mapper.Map<BHWGroup>(hwGroup);
            return tmpBHWGroup;
        }
        public List<BHWGroup> HWGroupToBHWGroup(List<HWGroup> hwGroups)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HWGroup, BHWGroup>());
            Mapper mapper = new Mapper(config);
            List<BHWGroup> tmpBHWGroups = mapper.Map<List<BHWGroup>>(hwGroups);
            return tmpBHWGroups;
        }

        public BLection LectionToBLection(Lection lection)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Lection, BLection>());
            Mapper mapper = new Mapper(config);
            BLection tmpBLection = mapper.Map<BLection>(lection);
            return tmpBLection;
        }
        public List<BLection> LectionsToBLections(List<Lection> lections)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Lection, BLection>());
            Mapper mapper = new Mapper(config);
            List<BLection> tmpBLections = mapper.Map<List<BLection>>(lections);
            return tmpBLections;
        }

        public BLector LectorToBLector(Lector lector)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Lector, BLector>());
            Mapper mapper = new Mapper(config);
            BLector tmpBLector = mapper.Map<BLector>(lector);
            return tmpBLector;
        }

        public List<BLector> LectorsToBLectors(List<Lector> lectors)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Lector, BLector>());
            Mapper mapper = new Mapper(config);
            List<BLector> tmpBLectors = mapper.Map<List<BLector>>(lectors);
            return tmpBLectors;
        }

        public BLectorCourse LectorCourseBLectorCourse(LectorCourse lectorCourse)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorCourse, BLectorCourse>());
            Mapper mapper = new Mapper(config);
            BLectorCourse tmpBLectorCourse = mapper.Map<BLectorCourse>(lectorCourse);
            return tmpBLectorCourse;
        }

        public List<BLectorCourse> LectorCoursesBLectorCourses(List<LectorCourse> lectorCourses)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorCourse, BLectorCourse>());
            Mapper mapper = new Mapper(config);
            List<BLectorCourse> tmpBLectorCourses = mapper.Map<List<BLectorCourse>>(lectorCourses);
            return tmpBLectorCourses;
        }

        public BLectorGroup LectorGroupToBLectorGroup(LectorGroup lectorGroup)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorGroup, BLectorGroup>());
            Mapper mapper = new Mapper(config);
            BLectorGroup tmpBLectorGroup = mapper.Map<BLectorGroup>(lectorGroup);
            return tmpBLectorGroup;
        }

        public List<BLectorGroup> LectorGroupsToBLectorGroups(List<LectorGroup> lectorGroups)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LectorGroup, BLectorGroup>());
            Mapper mapper = new Mapper(config);
            List<BLectorGroup> tmpBLectorGroups = mapper.Map<List<BLectorGroup>>(lectorGroups);
            return tmpBLectorGroups;
        }

        public BPayment PaymentToBPayment(Payment payment)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Payment, BPayment>());
            Mapper mapper = new Mapper(config);
            BPayment tmpBPayment = mapper.Map<BPayment>(payment);
            return tmpBPayment;
        }

        public List<BPayment> PaymentsToBPayments(List<Payment> payments)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Payment, BPayment>());
            Mapper mapper = new Mapper(config);
            List<BPayment> tmpBPayments = mapper.Map<List<BPayment>>(payments);
            return tmpBPayments;
        }

        public BStudent StudentToBStudent(Student student)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, BStudent>());
            Mapper mapper = new Mapper(config);
            BStudent tmpBStudent = mapper.Map<BStudent>(student);
            return tmpBStudent;
        }

        public List<BStudent> BStudentsToStudents(List<Student> students)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, BStudent>());
            Mapper mapper = new Mapper(config);
            List<BStudent> tmpBStudents = mapper.Map<List<BStudent>>(students);
            return tmpBStudents;
        }

        public BTeam TeamToBTeam(Team team)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Team, BTeam>());
            Mapper mapper = new Mapper(config);
            BTeam tmpBTeam = mapper.Map<BTeam>(team);
            return tmpBTeam;
        }

        public List<BTeam> TeamsToBTeams(List<Team> teams)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Team, BTeam>());
            Mapper mapper = new Mapper(config);
            List<BTeam> tmpBStudents = mapper.Map<List<BTeam>>(teams);
            return tmpBStudents;
        }

        public BTest TestToBTest(Test test)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Test, BTest>());
            Mapper mapper = new Mapper(config);
            BTest tmpBTest = mapper.Map<BTest>(test);
            return tmpBTest;
        }

        public List<BTest> TestsToBTests(List<Test> test)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Test, BTest>());
            Mapper mapper = new Mapper(config);
            List<BTest> tmpBTests = mapper.Map<List<BTest>>(test);
            return tmpBTests;
        }

        public BTestComplete TestCompleteToBTestComplete(TestComplete testComplete)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TestComplete, BTestComplete>());
            Mapper mapper = new Mapper(config);
            BTestComplete tmpBTestComplete = mapper.Map<BTestComplete>(testComplete);
            return tmpBTestComplete;
        }

        public List<BTestComplete> TestCompletesToBTestCompletes(List<TestComplete> testComplete)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TestComplete, BTestComplete>());
            Mapper mapper = new Mapper(config);
            List<BTestComplete> tmpBTestCompletes = mapper.Map<List<BTestComplete>>(testComplete);
            return tmpBTestCompletes;
        }

        public BTStudent TStudentToBTStudent(TStudent tStudent)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TStudent, BTStudent>());
            Mapper mapper = new Mapper(config);
            BTStudent tBStudent = mapper.Map<BTStudent>(tStudent);
            return tBStudent;
        }

        public List<BTStudent> TStudentsToBTStudents(List<TStudent> tStudents)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TStudent, BTStudent>());
            Mapper mapper = new Mapper(config);
            List<BTStudent> tBStudents = mapper.Map<List<BTStudent>>(tStudents);
            return tBStudents;
        }

        public BVisit VisitToBVisit(Visit visit)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Visit, BVisit>());
            Mapper mapper = new Mapper(config);
            BVisit tBVisit = mapper.Map<BVisit>(visit);
            return tBVisit;
        }

        public List<BVisit> VisitToBVisit(List<Visit> visits)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Visit, BVisit>());
            Mapper mapper = new Mapper(config);
            List<BVisit> tBVisits = mapper.Map<List<BVisit>>(visits);
            return tBVisits;
        }

        public City BCityToCity(BCity bCity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BCity, City>());
            Mapper mapper = new Mapper(config);
            City tmpCity = mapper.Map<City>(bCity);
            return tmpCity;
        }
}
}
