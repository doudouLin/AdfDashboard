using System.Collections.Generic;

namespace USZDashboard.Models.DashboardViewModels
{
    public class UserDashboard
    {
        public int UserDashboardId { get; set; }

        //Foreign Key for Dashboard
        public int DashboardId { get; set; }
        public Dashboard Dashboard { get; set; }

        //Foreign Key for User
        public int UserId { get; set; }
        public User User { get; set; }

        //Foreign Key for UserGroup
        public int UserGroupId { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}