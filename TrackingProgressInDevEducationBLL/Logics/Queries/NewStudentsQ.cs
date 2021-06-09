using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class NewStudentsQ : AQuery
    {
        public AbstractModel SetNewStudent(SetNewStudentQ query)
        {
            WriteTypes(new NewStudents().SetNewStudent());
            return GetModelBaseSingle(query);
        }

        public AbstractModel GetCities(EmptyQ query)
        {
            WriteTypes(new NewStudents().GetCities());
            return GetModelBaseSingle(query);
        }
        
        public AbstractModel GetGroups(EmptyQ query)
        {
            WriteTypes(new NewStudents().GetGroups());
            return GetModelBaseSingle(query);
        }
    }
}