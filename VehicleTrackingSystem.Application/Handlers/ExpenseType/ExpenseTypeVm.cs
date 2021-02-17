using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;
using VehicleTrackingSystem.Application.Handlers.ExpenseType.Commands;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType
{
    public class ExpenseTypeVm : IMapFrom<CreateExpenseType>
    {
        public int ExpenseTypeId { get; set; }
        public string ExpenseTypeName { get; set; }

    }
}
