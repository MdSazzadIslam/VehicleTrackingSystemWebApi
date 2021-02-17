using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands
{
    public class DeleteExpenseSubTypeHandler : IRequestHandler<DeleteExpenseSubType, ResultModel>
    {
        private readonly IExpenseSubTypeService _expenseSubTypeService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public DeleteExpenseSubTypeHandler(IExpenseSubTypeService expenseSubTypeService, ICurrentUserService currentUserService, IDateTime dateTime)
        {

            _expenseSubTypeService = expenseSubTypeService ?? throw new ArgumentNullException(nameof(_expenseSubTypeService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));

        }

        public async Task<ResultModel> Handle(DeleteExpenseSubType request, CancellationToken cancellationToken)
        {
            var result = await _expenseSubTypeService.DeleteExpenseSubType(request.Id);
            return result;
        }
    }
}
