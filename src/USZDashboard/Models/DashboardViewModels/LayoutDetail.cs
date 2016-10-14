namespace USZDashboard.Models.DashboardViewModels
{
    public class LayoutDetail
    {

        public int LayoutDetailId { get; set; }

        public int LayoutId { get; set; }

        public int RowNumber { get; set; }

        public int Column { get; set; }

        public string ColumnStyle { get; set; }

        public Layout Layout { get; set; }
    }
}