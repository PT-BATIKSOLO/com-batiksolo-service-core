﻿using Com.BatikSolo.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.BatikSolo.Service.Core.Lib.ViewModels
{
    public class CardTypeViewModel : BasicViewModelOld
    {
        public string code { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }
}
