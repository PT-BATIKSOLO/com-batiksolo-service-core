﻿using System;
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

namespace Com.BatikSolo.Service.Core.WebApi.Controllers.v1.UploadControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/garment-buyer-brand-upload")]
    public class GarmentBuyerBrandUploadController : BasicUploadController<GarmentBuyerBrandService, GarmentBuyerBrand, GarmentBuyerBrandViewModel, GarmentBuyerBrandService.GarmentBuyerBrandMap, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";

        public GarmentBuyerBrandUploadController(GarmentBuyerBrandService service) : base(service, ApiVersion)
        {
        }
    }
}