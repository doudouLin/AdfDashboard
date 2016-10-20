using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace USZDashboard.Models.DashboardViewModels
{
    public class UserGroup : EntityBase
    {
        public string GroupName { get; set; }


        //Foreign key for AdminRight
        public Guid AdminRightId { get; set; }
        [ForeignKey(nameof(AdminRightId))]
        public AdminRight AdminRight { get; set; }


        public List<User> Users { get; set; }
    }
}