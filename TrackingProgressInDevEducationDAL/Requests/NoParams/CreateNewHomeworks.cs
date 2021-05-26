using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class CreateNewHomeworks:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public CreateNewHomeworks()
        {
            Type = typeof(Homeworks);
            Name = "CreateNewHomeworks";
            Command = "";
        }
    }
}
