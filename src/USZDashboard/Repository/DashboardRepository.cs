using System;
using USZDashboard.Data;
using USZDashboard.Models.DashboardViewModels;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace USZDashboard.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private ApplicationDbContext _dashboardDbContext;

        public DashboardRepository(ApplicationDbContext applicationDbContext)
        {
            _dashboardDbContext = applicationDbContext;
        }

        public Dashboard GetDashboard(Guid id)
        {
            using (_dashboardDbContext)
            {
                var dashboard = _dashboardDbContext.Dashboard.Include(ds => ds.Structure)
                    .Include(ds => ds.TableRows)
                    .ThenInclude(tr => tr.TableColumns)
                    .ThenInclude(tc => tc.Widgets)
                    .ThenInclude(wg => wg.WidgetConfigrations)
                    .ToList()
                    .Find(i => i.Id == id);
                foreach (var dashboardTableRow in dashboard.TableRows)
                {
                    dashboardTableRow.TableColumns.ForEach(x => x.Widgets = x.Widgets.OrderBy(y => y.Index).ToList());
                }
                return dashboard;
            }
        }

        public IEnumerable<Dashboard> GetAllDashboard()
        {
            using (_dashboardDbContext)
            {
                var rs = _dashboardDbContext.Dashboard
                    .Include(ds => ds.Structure)
                    .Include(ds => ds.TableRows)
                    .ThenInclude(tr => tr.TableColumns)
                    .ThenInclude(tc => tc.Widgets)
                    .ThenInclude(wg => wg.WidgetConfigrations)
                    .ToList();

                return rs;
            }
        }

        public bool SaveDashboard(Dashboard dashboard)
        {
            using (_dashboardDbContext)
            {
                var dashBoardEntity = _dashboardDbContext.Dashboard.Attach(dashboard);

                var changed = _dashboardDbContext.ChangeTracker.Entries().Where(e => e.State == EntityState.Added
                                                                                || e.State == EntityState.Modified
                                                                                || e.State == EntityState.Deleted);

                if (dashBoardEntity.Entity.TableRows != null)
                {
                    foreach (var entityTableRow in dashBoardEntity.Entity.TableRows)
                    {
                        _dashboardDbContext.Entry(entityTableRow).State =
                            entityTableRow.Id == default(Guid) ? EntityState.Added : EntityState.Modified;
                        var tableRowEntity = _dashboardDbContext.TableRow.Single(item => item.Id == entityTableRow.Id);
                        if(tableRowEntity == null)
                            _dashboardDbContext.Entry(entityTableRow).State = EntityState.Deleted;

                        if (entityTableRow.TableColumns != null)
                        {
                            foreach (var tableColumn in entityTableRow.TableColumns)
                            {
                                _dashboardDbContext.Entry(tableColumn).State =
                                    tableColumn.Id == default(Guid) ? EntityState.Added : EntityState.Modified;
                                if (tableColumn.Widgets != null)
                                {
                                    foreach (var tableColumnWidget in tableColumn.Widgets)
                                    {
                                        _dashboardDbContext.Entry(tableColumnWidget).State =
                                            tableColumnWidget.Id == default(Guid) ? EntityState.Added : EntityState.Modified;
                                        if (tableColumnWidget.WidgetConfigrations != null)
                                        {
                                            foreach (var widgetConfigration in tableColumnWidget.WidgetConfigrations)
                                            {
                                                _dashboardDbContext.Entry(widgetConfigration).State =
                                                    widgetConfigration.Id == default(Guid) ? EntityState.Added : EntityState.Modified;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                

                _dashboardDbContext.SaveChanges();

                return true;
            }
        }

        public void AddDashboard(Dashboard dashboard)
        {
            using (_dashboardDbContext)
            {
                if (_dashboardDbContext.Widget.Any(ds => ds.Id == dashboard.Id))
                {
                    _dashboardDbContext.Entry(dashboard).State = EntityState.Added;

                    _dashboardDbContext.SaveChanges();
                }
            }
        }

        public void SaveWidgets(List<Widget> widgets)
        {
            using (_dashboardDbContext)
            {
                foreach (var widget in widgets)
                {
                    _dashboardDbContext.Entry(widget).State = EntityState.Modified;

                    _dashboardDbContext.SaveChanges();
                }
            }
        }

        public void AddWidget(Widget widget)
        {
            using (_dashboardDbContext)
            {
                if (!_dashboardDbContext.Widget.Any(wg => wg.Id == widget.Id))
                {
                    _dashboardDbContext.Entry(widget).State = EntityState.Added;

                    _dashboardDbContext.SaveChanges();
                }

            }
        }

        public void DeleteWidget(Guid id)
        {
            using (_dashboardDbContext)
            {

                var wgToDel = _dashboardDbContext.Widget.Single(wg => wg.Id == id);
                if (wgToDel != null)
                {
                    _dashboardDbContext.Entry(wgToDel).State = EntityState.Deleted;

                    _dashboardDbContext.SaveChanges();
                }
            }
        }
    }
}
