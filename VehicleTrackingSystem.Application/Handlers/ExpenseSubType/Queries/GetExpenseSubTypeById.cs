using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Queries
{
    public class GetExpenseSubTypeById : IRequest<ExpenseSubTypeReturnVm>
    {
        public int Id { get; set; }
        public GetExpenseSubTypeById(int id)
        {
            Id = id;
        }
    }
}
