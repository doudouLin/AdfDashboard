using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using USZDashboard.Repository;
using USZDashboard.Models.DashboardViewModels;
using USZDashboard.Data;

namespace USZDashboard.Controllers.DashboardAdmin
{
    [Produces("application/json")]
    [Route("DashboardAdmin/USZDashboard")]
    public class USZDashboardController : Controller
    {
        private readonly IDashboardRepository _dashboardRepository;

        public USZDashboardController(ApplicationDbContext applicationDbContext)
        {
            _dashboardRepository = new DashboardRepository(applicationDbContext);
        }
        

        // GET: api/USZDashboard
        [HttpGet]
        public IEnumerable<Dashboard> GetDashboard()
        {
            return _dashboardRepository.GetAllDashboard();
        }

        // GET: api/USZDashboard/5
        [HttpGet("{id}", Name = "Get")]
        public Dashboard GetDashboard(Guid id)
        {
            return _dashboardRepository.GetDashboard(id);
        }

        // POST: DashboardAdmin/USZDashboard
        [HttpPost]
        public void Post([FromBody]Dashboard dashboard)
        {
            _dashboardRepository.SaveDashboard(dashboard);
        }
        [Route("SaveWidgets")]
        [HttpPost]
        public void SaveWidgets([FromBody]List<Widget> widgets)
        {
            _dashboardRepository.SaveWidgets(widgets);
        }

        // PUT: api/USZDashboard/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]Dashboard dashboard)
        //{
        //    _dashboardRepository.AddDashboard(dashboard);
        //}
        [Route("AddWidget")]
        [HttpPut]
        public void AddWidget([FromBody]Widget widget)
        {
            _dashboardRepository.AddWidget(widget);
        }

        [Route("DeleteWidget")]
        [HttpDelete("{id}", Name = "Delete")]
        public void DeleteWidget(Guid id)
        {
            _dashboardRepository.DeleteWidget(id);
        }
    }
}
