using USZDashboard.Data;
using USZDashboard.Models.DashboardViewModels;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace USZDashboard.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private ApplicationDbContext _dashboardDbContext;

        public DashboardRepository(ApplicationDbContext applicationDbContext)
        {
            _dashboardDbContext = applicationDbContext;
        }

        public Dashboard GetDashboard(int Id)
        {
            using (_dashboardDbContext)
            {
                return _dashboardDbContext.Dashboard.Include(ds => ds.Layout)
                    .Include(ds => ds.Widgets)
                    .Include(ds => ds.UserDashboards)
                    .ToList()
                    .Find(i => i.DashboardId == Id);
            }
        }

        public IEnumerable<Dashboard> GetAllDashboard()
        {
            using (_dashboardDbContext)
            {
                var rs = _dashboardDbContext.Dashboard
                    .Include(ds => ds.Layout)
                    .Include(ds => ds.Widgets)
                    .Include(ds => ds.UserDashboards)
                    .ToList();

                return rs;
            }
        }
    }
}
