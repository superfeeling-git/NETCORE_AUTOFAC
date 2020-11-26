using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IRepository;
using Entity;

namespace NETCORE_AUTOFAC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IAdminService<AdminModel> adminService;
        public WeatherForecastController(IAdminService<AdminModel> _adminService)
        {
            adminService = _adminService;
        }

        public IAdminService<AdminModel> admin { get; set; }

        [HttpGet]
        public IActionResult Get()
        {
            admin.Create(new AdminModel { AdminID = 1, UserName = "张三", Password = Guid.NewGuid().ToString() });
            admin.Create(new AdminModel { AdminID = 2, UserName = "李四", Password = Guid.NewGuid().ToString() });
            admin.Create(new AdminModel { AdminID = 3, UserName = "王五", Password = Guid.NewGuid().ToString() });
            admin.Create(new AdminModel { AdminID = 4, UserName = "赵六", Password = Guid.NewGuid().ToString() });
            return new JsonResult(admin.GetAll());
        }
    }
}
