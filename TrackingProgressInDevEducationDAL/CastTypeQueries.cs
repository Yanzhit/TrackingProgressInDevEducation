using System;

namespace TrackingProgressInDevEducationDAL
{
    public class CastTypeQueries
    {
        public void CastType(EnumCastTypeQueries castType)
        {
            switch (castType)
            {
                case EnumCastTypeQueries.Comments:
                    break;
                case EnumCastTypeQueries.CommentType:
                    break;
                case EnumCastTypeQueries.Courses:
                    break;
                case EnumCastTypeQueries.Groups:
                    break;
                case EnumCastTypeQueries.Homework_Group:
                    break;
                case EnumCastTypeQueries.HomeworkComplete:
                    break;
                case EnumCastTypeQueries.Homeworks:
                    break;
                case EnumCastTypeQueries.Lections:
                    break;
                case EnumCastTypeQueries.Lector_Group:
                    break;
                case EnumCastTypeQueries.Lectors:
                    break;
                case EnumCastTypeQueries.Payments:
                    break;
                case EnumCastTypeQueries.Students:
                    break;
                case EnumCastTypeQueries.Team_Student:
                    break;
                case EnumCastTypeQueries.Teams:
                    break;
                case EnumCastTypeQueries.Visits:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}