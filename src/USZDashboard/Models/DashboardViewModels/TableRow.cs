using System.Collections.Generic;

namespace USZDashboard.Models.DashboardViewModels
{
    public class TableRow : EntityBase
    {
        public int RowNumber { get; set; }
        
        public List<TableColumn> TableColumns { get; set; }
    }
}