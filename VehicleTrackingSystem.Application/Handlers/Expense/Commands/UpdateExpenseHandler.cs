using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Expense.Commands
{
    public class UpdateExpenseHandler : IRequestHandler<UpdateExpense, ResultModel>
    {
        private readonly IExpenseService _expenseService;
        private readonly IMapper _mapper;

        public UpdateExpenseHandler(IExpenseService expenseService, IMapper mapper)
        {
            _expenseService = expenseService ?? throw new ArgumentNullException(nameof(_expenseService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        public async Task<ResultModel> Handle(UpdateExpense request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<UpdateExpenseVm>(request);
            var result = await _expenseService.UpdateExpense(data);
            return result;
        }
    }
}
