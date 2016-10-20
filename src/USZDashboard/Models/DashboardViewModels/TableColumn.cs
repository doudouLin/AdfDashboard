using System;
using System.Collections.Generic;

namespace USZDashboard.Models.DashboardViewModels
{
    public class TableColumn : EntityBase
    {
        public TableColumn()
        {
            Widgets = new List<Widget>();
        }

        public int ColumnNumber { get; set; }

        public string ColumnStyle { get; set; }

        //Foreign key for TableRow
        public Guid TableRowId { get; set; }

        //public virtual TableRow TableRow { get; set; }

        public virtual ICollection<Widget> Widgets { get; set; }
    }
}