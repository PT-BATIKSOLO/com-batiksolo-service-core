using Com.BatikSolo.Service.Core.Lib;
using Com.BatikSolo.Service.Core.Lib.Services;
using Com.BatikSolo.Service.Core.Lib.ViewModels;
using Com.BatikSolo.Service.Core.Test.Helpers;
using Models = Com.BatikSolo.Service.Core.Lib.Models;
using Xunit;
using Com.BatikSolo.Service.Core.Test.DataUtils;
using System.Collections.Generic;

namespace Com.BatikSolo.Service.Core.Test.Controllers.GarmentSupplierControllerTests
{
    [Collection("TestFixture Collection")]
    public class BasicTests : BasicControllerTest<CoreDbContext, GarmentSupplierService, Models.GarmentSupplier, GarmentSupplierViewModel, GarmentSupplierDataUtil>
	{
		private const string URI = "v1/master/garment-suppliers";
		
		private static List<string> CreateValidationAttributes = new List<string> { };
		private static List<string> UpdateValidationAttributes = new List<string> { };

		public BasicTests(TestServerFixture fixture) : base(fixture, URI, CreateValidationAttributes, UpdateValidationAttributes)
		{
		}

	}
}

