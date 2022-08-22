using Com.BatikSolo.Service.Core.Lib.Helpers;
using System;

namespace Com.BatikSolo.Service.Core.Lib.ViewModels
{
    public class ArticleCategoryViewModel : BasicViewModelOld
    {
        public string code { get; set; }

        public string name { get; set; }

        public string Description { get; set; }

        public DateTimeOffset Date { get; set; }
    }
}
