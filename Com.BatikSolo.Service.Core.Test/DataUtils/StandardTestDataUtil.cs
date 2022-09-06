using Com.BatikSolo.Service.Core.Lib;
using Com.BatikSolo.Service.Core.Lib.Models;
using Com.BatikSolo.Service.Core.Lib.Services;
using Com.BatikSolo.Service.Core.Lib.ViewModels;
using Com.BatikSolo.Service.Core.Test.Helpers;
using Com.BatikSolo.Service.Core.Test.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.BatikSolo.Service.Core.Test.DataUtils
{
    public class StandardTestDataUtil : BasicDataUtil<CoreDbContext, StandardTestsService, StandardTests>, IEmptyData<StandardTestsViewModel>
    {
        public StandardTestDataUtil(CoreDbContext dbContext, StandardTestsService service) : base(dbContext, service)
        {
        }
        public StandardTestsViewModel GetEmptyData()
        {
            StandardTestsViewModel Data = new StandardTestsViewModel();

            Data.Name = "";
            Data.Code = "";
            Data.Remark = "";
            return Data;
        }

        public override StandardTests GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            StandardTests TestData = new StandardTests
            {
                Name = "TEST",
                Remark = "test",
            };

            return TestData;
        }

        public override async Task<StandardTests> GetTestDataAsync()
        {
            StandardTests Data = GetNewData();
            await this.Service.CreateModel(Data);
            return Data;
        }
    }
}
