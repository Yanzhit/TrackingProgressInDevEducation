﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeTeams
    {

    }

    public class FacadeGetTeamById
    {
        public List<Teams> GetTeamById(int id)
        {
            GetTeamById getTeamById = new GetTeamById(id);
            return (List<Teams>)QuerySettings.QuerySet(getTeamById);
        }
    }

    public class FacadeRemoveTeamById
    {
        public List<Teams> RemoveTeamById(int id)
        {
            RemoveTeamById removeTeamById = new RemoveTeamById(id);
            return (List<Teams>) QuerySettings.QuerySet(removeTeamById);
        }
    }

    public class FacadeGetTeams
    {
        public List<Teams> GetTeams()
        {
            GetTeams getTeams = new GetTeams();
            return (List<Teams>) QuerySettings.QuerySet(getTeams);
        }
    }

    public class FacadeAddNewTeam
    {
        public List<Teams> AddNewTeam(string name)
        {
            AddNewTeam addNewTeam = new AddNewTeam(name);
            return (List<Teams>) QuerySettings.QuerySet(addNewTeam);
        }
    }
}