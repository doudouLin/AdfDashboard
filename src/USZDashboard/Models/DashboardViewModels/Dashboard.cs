using System.Collections.Generic;

namespace USZDashboard.Models.DashboardViewModels
{
    public class Dashboard
    {
        public int DashboardId { get; set; }

        public string DashboardName { get; set; }
        public string Title { get; set; }
        public bool editable { get; set; }
        public bool maximizable { get; set; }
        public bool collapsible { get; set; }
        public bool categories { get; set; }
        public string Structure { get; set; }


        //Foreign key for Layout
        public int LayoutId { get; set; }

        public Layout Layout { get; set; }

        public List<Widget> Widgets { get; set; }

        public List<UserDashboard> UserDashboards { get; set; }

    }
}