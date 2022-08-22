using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.BatikSolo.Service.Core.Lib;
using Com.BatikSolo.Service.Core.Lib.Models;
using Com.BatikSolo.Service.Core.Lib.Services;
using Com.BatikSolo.Service.Core.Lib.ViewModels;
using Com.BatikSolo.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Com.BatikSolo.Service.Core.WebApi.Controllers.v1.BasicControllers
{
	[Produces("application/json")]
	[ApiVersion("1.0")]
	[Route("v{version:apiVersion}/master/garment-units")]
	public class GarmentUnitController : BasicController<GarmentUnitService, Unit, UnitViewModel, CoreDbContext>
	{
		private new static readonly string ApiVersion = "1.0";

		public GarmentUnitController(GarmentUnitService service) : base(service, ApiVersion)
		{
		}
	}
}