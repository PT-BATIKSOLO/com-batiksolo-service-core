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
    public class UnitDataUtil : BasicDataUtil<CoreDbContext, UnitService, Unit>, IEmptyData<UnitViewModel>
    {
        public UnitDataUtil(CoreDbContext dbContext, UnitService service) : base(dbContext, service)
        {
        }

        public UnitViewModel GetEmptyData()
        {
            return new UnitViewModel();
        }

        public override Unit GetNewData()
        {
            string guid = Guid.NewGuid().ToString();

            return new Unit()
            {
                Name = string.Format("Unit {0}", guid),
                Code = string.Format("Unit {0}", guid),
                DivisionCode= string.Format("Unit {0}", guid),
                DivisionName= string.Format("Unit {0}", guid),
                DivisionId=1
            };
        }

        public override async Task<Unit> GetTestDataAsync()
        {
            var data = GetNewData();
            await this.Service.CreateModel(data);
            return data;
        }
    }
}
