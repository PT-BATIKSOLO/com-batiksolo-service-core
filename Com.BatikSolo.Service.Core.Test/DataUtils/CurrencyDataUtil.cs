﻿using Com.BatikSolo.Service.Core.Lib;
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
    public class CurrencyDataUtil : BasicDataUtil<CoreDbContext, CurrencyService, Currency>, IEmptyData<CurrencyViewModel>
    {
        public CurrencyDataUtil(CoreDbContext dbContext, CurrencyService service) : base(dbContext, service)
        {
        }

        public CurrencyViewModel GetEmptyData()
        {
            return new CurrencyViewModel();
        }

        public override Currency GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            return new Currency
            {
                Code = string.Format("CurrencyCode {0}", guid),
                Symbol = "^_^",
                Rate = 1,
                Description = string.Format("CurrencyDescription {0}", guid),
            };
        }

        public override async Task<Currency> GetTestDataAsync()
        {
            var data = GetNewData();
            await Service.CreateModel(data);
            return data;
        }
    }
}
