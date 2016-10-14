using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        private ApplicationDbContext _dashboardDbContext;

        private readonly IDashboardRepository _dashboardRepository;

        public USZDashboardController(ApplicationDbContext applicationDbContext)
        {
            _dashboardDbContext = applicationDbContext;
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
        public Dashboard GetDashboard(int id)
        {
            return _dashboardRepository.GetDashboard(id);
        }
        
        //// POST: api/USZDashboard
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}
        
        //// PUT: api/USZDashboard/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        
        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
