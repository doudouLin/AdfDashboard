using USZDashboard.Models.DashboardViewModels;
using System.Collections.Generic;

namespace USZDashboard.Repository
{
    public interface IDashboardRepository
    {
        Dashboard GetDashboard(int Id);
        IEnumerable<Dashboard> GetAllDashboard();
    }
}
