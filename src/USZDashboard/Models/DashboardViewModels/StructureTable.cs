namespace USZDashboard.Models.DashboardViewModels
{
    public class StructureTable
    {

        public int StructureTableId { get; set; }

        public int RowNumber { get; set; }

        public int Column { get; set; }

        public string ColumnStyle { get; set; }


        public int LayoutId { get; set; }
        public Layout Layout { get; set; }

        public int WidgetId { get; set; }
        public Widget Widget { get; set; }


    }
}