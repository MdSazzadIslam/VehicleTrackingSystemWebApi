using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType.queries
{
    public class GetExpenseType : IRequest<IList<ExpenseTypeReturnVm>>
    {
        public GetExpenseType()
        {

        }
    }
}
