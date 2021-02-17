using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType
{
    public class ExpenseTypeReturnVm : IMapFrom<Domain.Entities.ExpenseType>
    {
        public int ExpenseTypeId { get; set; }
        public string ExpenseTypeName { get; set; }

    }
}
