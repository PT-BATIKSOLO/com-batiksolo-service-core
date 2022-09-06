﻿using Microsoft.AspNetCore.Mvc;
using Com.BatikSolo.Service.Core.Lib;
using Com.BatikSolo.Service.Core.Lib.Services;
using Com.BatikSolo.Service.Core.WebApi.Helpers;
using Com.BatikSolo.Service.Core.Lib.Models;
using Com.BatikSolo.Service.Core.Lib.ViewModels;

namespace Com.BatikSolo.Service.Core.WebApi.Controllers.v1.UploadControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/upload-garment-buyers")]
    public class GarmentBuyersUploadController : BasicUploadController<GarmentBuyerService, GarmentBuyer, GarmentBuyerViewModel, GarmentBuyerService.GarmentBuyerMap, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";
       
        public GarmentBuyersUploadController(GarmentBuyerService service) : base(service, ApiVersion)
        {
        }
    }
}