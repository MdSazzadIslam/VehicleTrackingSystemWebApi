using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.Expense.Queries
{
    public class GetExpenseByIdHandler : IRequestHandler<GetExpenseById, ExpenseVm>
    {
        private readonly IExpenseService _expenseService;
        private readonly IMapper _mapper;

        public GetExpenseByIdHandler(IExpenseService expenseService, IMapper mapper)
        {

            _expenseService = expenseService ?? throw new ArgumentNullException(nameof(_expenseService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));

        }

        public async Task<ExpenseVm> Handle(GetExpenseById request, CancellationToken cancellationToken)
        {
            var expense = await _expenseService.GetExpenseSubById(request.Id);
            return expense;
        }
    }
}
