﻿using Com.BatikSolo.Service.Core.Lib;
using Com.BatikSolo.Service.Core.Lib.Models;
using Com.BatikSolo.Service.Core.Lib.Services;
using Com.BatikSolo.Service.Core.Lib.ViewModels;
using Com.BatikSolo.Service.Core.Test.DataUtils;
using Com.BatikSolo.Service.Core.Test.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Com.BatikSolo.Service.Core.Test.Controllers.GarmentUnitControllerTests
{

    [Collection("TestFixture Collection")]
    public class BasicTests : BasicControllerTest<CoreDbContext, GarmentUnitService, Unit, UnitViewModel, GarmentUnitDataUtil>
    {
        private const string URI = "v1/master/garment-units";

        private static List<string> CreateValidationAttributes = new List<string> { "Name", "Code" };
        private static List<string> UpdateValidationAttributes = new List<string> { "Name", "Code" };

        public BasicTests(TestServerFixture fixture) : base(fixture, URI, CreateValidationAttributes, UpdateValidationAttributes)
        {
        }
    }
}
