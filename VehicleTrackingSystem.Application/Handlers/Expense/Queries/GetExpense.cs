using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.Expense.Queries
{
    public class GetExpense : IRequest<IList<ExpenseVm>>
    {
        public GetExpense()
        {


        }
    }
}
