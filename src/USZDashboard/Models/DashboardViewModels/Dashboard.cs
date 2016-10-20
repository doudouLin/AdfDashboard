using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace USZDashboard.Models.DashboardViewModels
{
    public class Dashboard : EntityBase
    {
        public string DashboardName { get; set; }
        public string Title { get; set; }
        public bool Editable { get; set; }
        public bool Maximizable { get; set; }
        public bool Collapsible { get; set; }
        public bool Categories { get; set; }


        //Foreign Key for Structure
        public Guid StructureId { get; set; }

        [ForeignKey(nameof(StructureId))]
        public Structure Structure { get; set; }

        public List<TableRow> TableRows { get; set; }

    }
}