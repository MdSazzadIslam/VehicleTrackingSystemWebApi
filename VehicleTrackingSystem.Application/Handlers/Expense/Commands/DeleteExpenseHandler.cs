using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Expense.Commands
{
    public class DeleteExpenseHandler : IRequestHandler<DeleteExpense, ResultModel>
    {
        private readonly IExpenseService _expenseService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public DeleteExpenseHandler(IExpenseService expenseService, ICurrentUserService currentUserService, IDateTime dateTime)
        {
            _expenseService = expenseService ?? throw new ArgumentNullException(nameof(_expenseService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));
        }


        public async Task<ResultModel> Handle(DeleteExpense request, CancellationToken cancellationToken)
        {
            var result = await _expenseService.DeleteExpense(request.Id);
            return result;
        }
    }
}
