﻿using Com.BatikSolo.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.BatikSolo.Service.Core.Lib.ViewModels
{
    public class GarmentComodityViewModel : BasicViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
