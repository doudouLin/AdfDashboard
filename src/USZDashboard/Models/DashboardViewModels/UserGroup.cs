using System.Collections.Generic;

namespace USZDashboard.Models.DashboardViewModels
{
    public class UserGroup
    {
        public int UserGroupId { get; set; }
        public string Name { get; set; }

        //Foreign key for User
        public int UserId { get; set; }

        public List<User> User { get; set; }

        //Foreign key for AdminRight
        public int AdminRightId { get; set; }

        public AdminRight AdminRight { get; set; }
    }
}