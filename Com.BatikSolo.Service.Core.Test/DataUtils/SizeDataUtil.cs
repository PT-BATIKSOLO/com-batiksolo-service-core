﻿using Com.BatikSolo.Service.Core.Lib;
using Com.BatikSolo.Service.Core.Lib.Models;
using Com.BatikSolo.Service.Core.Lib.Services;
using Com.BatikSolo.Service.Core.Lib.ViewModels;
using Com.BatikSolo.Service.Core.Test.Helpers;
using Com.BatikSolo.Service.Core.Test.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Com.BatikSolo.Service.Core.Test.DataUtils
{
    public class SizeDataUtil : BasicDataUtil<CoreDbContext, SizeService, SizeModel>, IEmptyData<SizeViewModel>
    {
        public SizeDataUtil(CoreDbContext dbContext, SizeService service) : base(dbContext, service)
        {
        }

        public SizeViewModel GetEmptyData()
        {
            return new SizeViewModel();
        }

        public override SizeModel GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            SizeModel TestData = new SizeModel
            {
                Size = string.Format("TEST {0}", guid),
                UId = guid
            };

            return TestData;
        }

        public override async Task<SizeModel> GetTestDataAsync()
        {
            SizeModel Data = GetNewData();
            await this.Service.CreateModel(Data);
            return Data;
        }
    }
}