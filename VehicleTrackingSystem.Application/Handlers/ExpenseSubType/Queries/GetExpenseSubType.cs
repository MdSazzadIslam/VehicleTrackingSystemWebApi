using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Queries
{
    public class GetExpenseSubType : IRequest<IList<ExpenseSubTypeReturnVm>>
    {
        public GetExpenseSubType()
        {


        }
    }
}
