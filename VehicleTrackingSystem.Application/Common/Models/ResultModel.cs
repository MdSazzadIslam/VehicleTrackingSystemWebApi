using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Common.Models
{
    public class ResultModel
    {
        public string Id { get; set; }
        public bool Result { get; set; }
        public object Data { get; set; }
        public IList<object> DataList { get; set; }
        public string Message { get; set; }

    }
}
