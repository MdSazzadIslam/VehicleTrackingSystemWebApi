using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Mappers;
using VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType
{
    public class ExpenseSubTypeVm : IMapFrom<CreateExpenseSubType>
    {
        public string ExpenseSubTypeName { get; set; }
        public int ExpenseTypeId { get; set; }

    }
}
