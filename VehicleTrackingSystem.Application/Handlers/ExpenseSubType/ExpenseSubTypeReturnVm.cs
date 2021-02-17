using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType
{
    public class ExpenseSubTypeReturnVm : IMapFrom<Domain.Entities.ExpenseSubType>
    {
        public int ExpenseSubTypeId { get; set; }
        public string ExpenseTypeName { get; set; }
        public int ExpenseTypeId { get; set; }

    }
}
