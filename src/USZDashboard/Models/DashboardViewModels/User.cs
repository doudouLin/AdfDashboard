using System.Collections.Generic;

namespace USZDashboard.Models.DashboardViewModels
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Photo { get; set; }

        public string Password { get; set; }

        public List<UserDashboard> UserDashboards { get; set; }

    }
}