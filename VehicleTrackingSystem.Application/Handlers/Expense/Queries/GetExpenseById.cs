using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.Expense.Queries
{
    public class GetExpenseById : IRequest<ExpenseVm>
    {
        public int Id { get; set; }
        public GetExpenseById(int id)
        {
            Id = id;
        }
    }
}
