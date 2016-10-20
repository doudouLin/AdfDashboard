using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace USZDashboard.Models.DashboardViewModels
{
    public abstract class EntityBase : INotifyPropertyChanged
    {
        protected EntityBase()
        {
            CreateDate = DateTime.Now;
            ChangeDate = CreateDate;
            CreateUser = "Lin";
            ChangeUser = CreateUser;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string CreateUser { get; set; }
        public string ChangeUser { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void EntityBase_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Id == new Guid()) return;
            ChangeDate = DateTime.Now;
            ChangeUser = "Lin";
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;

            handler?.Invoke(this, e);
        }
    }
}
