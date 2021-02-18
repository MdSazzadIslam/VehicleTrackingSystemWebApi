using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;
using VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType
{
    public class UpdateExpenseSubTypeVm : IMapFrom<UpdateExpenseSubType>
    {
        public int ExpenseSubTypeId { get; set; }
        public string ExpenseSubTypeName { get; set; }
        public int ExpenseTypeId { get; set; }

  
    }
}
