using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableHomeworks
{
    public class CreateNewHomeworks : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public CreateNewHomeworks(string name)
        {
            Type = typeof(Homeworks);
            Name = GetType().Name;
            Params = $"{name}";
        }
    }
}
