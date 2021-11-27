using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Forecast
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<double> ForecastsQuality { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    }
}
