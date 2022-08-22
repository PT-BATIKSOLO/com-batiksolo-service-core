using Microsoft.AspNetCore.Mvc;
using Com.BatikSolo.Service.Core.Lib.Services;
using Com.BatikSolo.Service.Core.Lib.Models;
using Com.BatikSolo.Service.Core.WebApi.Helpers;
using Com.BatikSolo.Service.Core.Lib.ViewModels;
using Com.BatikSolo.Service.Core.Lib;

namespace Com.BatikSolo.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/holidays")]
    public class HolidaysController : BasicController<HolidayService, Holiday, HolidayViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";

        public HolidaysController(HolidayService service) : base(service, ApiVersion)
        {
        }
    }
}
