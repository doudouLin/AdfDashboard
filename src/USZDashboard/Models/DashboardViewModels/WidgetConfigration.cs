using System;

namespace USZDashboard.Models.DashboardViewModels
{
    public class WidgetConfigration : EntityBase
    {
        public string Key { get; set; }
        public string Value { get; set; }


        //Foreign key for TableRow
        public Guid WidgetId { get; set; }
        //[ForeignKey(nameof(WidgetId))]
        //public Widget Widget { get; set; }
    }
}