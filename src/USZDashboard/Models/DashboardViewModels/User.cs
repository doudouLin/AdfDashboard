﻿using System.Collections.Generic;

namespace USZDashboard.Models.DashboardViewModels
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        //public List<UserGroup> UserGroup { get; set; }

        public List<UserDashboard> UserDashboard { get; set; }

    }
}