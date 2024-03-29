﻿using Com.BatikSolo.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.BatikSolo.Service.Core.Lib.ViewModels
{
    public class GarmentCategoryViewModel : BasicViewModel
	{
        public string code { get; set; }
        public string name { get; set; }
        public string codeRequirement { get; set; }
        public UomViewModel uom { get; set; }
    }
}
