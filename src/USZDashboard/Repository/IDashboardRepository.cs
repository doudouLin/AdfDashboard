using System;
using USZDashboard.Models.DashboardViewModels;
using System.Collections.Generic;

namespace USZDashboard.Repository
{
    public interface IDashboardRepository
    {
        Dashboard GetDashboard(Guid id);

        IEnumerable<Dashboard> GetAllDashboard();

        bool SaveDashboard(Dashboard dashboard);

        void AddDashboard(Dashboard dashboard);

        void SaveWidgets(List<Widget> widgets);

        void AddWidget(Widget widget);

        void DeleteWidget(Guid id);
    }
}
