﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class TestsCompletes : AFacade
    {
        private readonly QTestComplete _query = new();
        
        public IEnumerable<AResult> SetNewTC()
        {
            return (IEnumerable<AResult>)Manager.Setter.Single(_query.SetNewTC());
        }

        public IEnumerable<TestComplete> GetTestScore()
        {
            return (IEnumerable<TestComplete>)Manager.Getter.Single(_query.GetTestScore());
        }

        public IEnumerable<AResult> NullifyTCs()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyTCs());
        }
        
    }
}