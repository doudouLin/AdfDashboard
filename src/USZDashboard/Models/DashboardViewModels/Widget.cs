using System;
using System.Collections.Generic;

namespace USZDashboard.Models.DashboardViewModels
{
    public class Widget : EntityBase
    {
        public string Title { get; set; }
        public string WidgetName { get; set; }
        public string ModalSize { get; set; }
        public string Type { get; set; }
        public bool FullScreen { get; set; }
        public int Index { get; set; }

        //Foreign key for TableRow
        public Guid TableColumnId { get; set; }

        //[ForeignKey(nameof(TableColumnId))]
        //public TableColumn TableColumn { get; set; }

        public List<WidgetConfigration> WidgetConfigrations { get; set; }
    }
}