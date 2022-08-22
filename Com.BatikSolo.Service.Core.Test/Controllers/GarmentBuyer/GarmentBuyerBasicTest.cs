using Com.BatikSolo.Service.Core.Lib;
using Models = Com.BatikSolo.Service.Core.Lib.Models;
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

namespace Com.BatikSolo.Service.Core.Test.Controllers.GarmentBuyer
{
    [Collection("TestFixture Collection")]
    public class GarmentBuyerBasicTest : BasicControllerTest<CoreDbContext, GarmentBuyerService, Models.GarmentBuyer, GarmentBuyerViewModel, GarmentBuyerDataUtil>
    {
        private static string URI = "v1/master/garment-buyers";
        private static List<string> CreateValidationAttributes = new List<string> { };
        private static List<string> UpdateValidationAttributes = new List<string> { };

        public GarmentBuyerBasicTest(TestServerFixture fixture) : base(fixture, URI, CreateValidationAttributes, UpdateValidationAttributes)
        {
        }
    }
}
