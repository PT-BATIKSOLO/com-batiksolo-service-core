﻿using Com.BatikSolo.Service.Core.Lib.Helpers;
using System;

namespace Com.BatikSolo.Service.Core.Lib.ViewModels
{
    public class GarmentCurrencyViewModel : BasicViewModel
    {

        public string code { get; set; }

        public DateTime date { get; set; }

        /* Double */
        public dynamic rate { get; set; }
    }
}
