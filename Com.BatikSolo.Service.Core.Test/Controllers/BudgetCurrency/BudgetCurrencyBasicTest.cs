﻿using Com.BatikSolo.Service.Core.Lib;
using Com.BatikSolo.Service.Core.Lib.Models;
using Com.BatikSolo.Service.Core.Lib.Services;
using Com.BatikSolo.Service.Core.Lib.ViewModels;
using Com.BatikSolo.Service.Core.Test.Helpers;
using System.Collections.Generic;
using Models = Com.BatikSolo.Service.Core.Lib.Models;
using Xunit;
using Com.BatikSolo.Service.Core.Test.DataUtils;
using System.Threading.Tasks;
using System.Net;

namespace Com.BatikSolo.Service.Core.Test.Controllers.BudgetCurrencyTest
{
	[Collection("TestFixture Collection")]
	public class BudgetCurrencyBasicTest : BasicControllerTest<CoreDbContext, BudgetCurrencyService, Models.BudgetCurrency, BudgetCurrencyViewModel, BudgetCurrencyDataUtil>
	{
		private const string URI = "v1/master/budget-currencies";
		private static List<string> CreateValidationAttributes = new List<string> { };
		private static List<string> UpdateValidationAttributes = new List<string> { };

		public BudgetCurrencyBasicTest(TestServerFixture fixture) : base(fixture, URI, CreateValidationAttributes, UpdateValidationAttributes)
		{
		}

        [Fact]
        public async Task GetById()
        {
            var response = await this.Client.GetAsync(string.Concat(URI, "/byId"));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetByCode()
        {
            var response = await this.Client.GetAsync(string.Concat(URI, "/by-code"));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}