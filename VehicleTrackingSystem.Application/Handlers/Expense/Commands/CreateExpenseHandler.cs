using AutoMapper;
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
    public class CreateExpenseHandler : IRequestHandler<CreateExpense, ResultModel>
    {
        private readonly IExpenseService _expenseService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        private readonly IMapper _mapper;

        public CreateExpenseHandler(IExpenseService expenseService, ICurrentUserService currentUserService, IDateTime dateTime, IMapper mapper)
        {
            _expenseService = expenseService ?? throw new ArgumentNullException(nameof(_expenseService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        public async Task<ResultModel> Handle(CreateExpense request, CancellationToken cancellationToken)
        {
 
            var data = _mapper.Map<ExpenseVm>(request);
            var result = await _expenseService.CreateExpense(data);
            return result;
        }
    }
}
