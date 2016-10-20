using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace USZDashboard.Models.DashboardViewModels
{
    public class UserDashboard : EntityBase
    {
        public string Ext { get; set; }

        //Foreign Key for Dashboard
        public Guid DashboardId { get; set; }
        [ForeignKey(nameof(DashboardId))]
        public Dashboard Dashboard { get; set; }

        //Foreign Key for User
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        //Foreign Key for UserGroup
        public Guid UserGroupId { get; set; }
        [ForeignKey(nameof(UserGroupId))]
        public UserGroup UserGroup { get; set; }
    }
}