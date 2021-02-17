using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType.queries
{
    public class GetExpenseTypeById : IRequest<ExpenseTypeReturnVm>
    {
        public int Id { get; set; }
        public GetExpenseTypeById(int id)
        {
            Id = id;

        }

    }
}
