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
	[Route("v{version:apiVersion}/master/garment-suppliers")]
	public class GarmentSuppliersController : BasicController<GarmentSupplierService, GarmentSupplier, GarmentSupplierViewModel, CoreDbContext>
	{
		private new static readonly string ApiVersion = "1.0";

		public GarmentSuppliersController(GarmentSupplierService service) : base(service, ApiVersion)
		{
		}
	}
}