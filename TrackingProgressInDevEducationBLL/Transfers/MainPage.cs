using System;
using TrackingProgressInDevEducationBLL.Models.MainPage;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationBLL.Transfers

{
    public class MainPage : ATransfer
    {
        public MainPage GetGroupsByLectorJ()
        {
            Query = typeof(GetGroupsByLectorQ);
            Base = typeof(GetGroupByLectorJ);
            Answer = typeof(GetGroupsByLectorA);
            return this;
        }

        public MainPage GetAllTeamsByLectorJ()
        {
            Query = typeof(GetAllTeamsByLectorJQ);
            //Base = typeof();
            Answer = typeof(GetAllTeamsByLectorJA);
            return this;
        }

        internal ATransfer GetGroupByLectorJ()
        {
            throw new NotImplementedException();
        }
    }
}