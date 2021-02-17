using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.Expense.Queries
{
    public class GetExpenseHandler : IRequestHandler<GetExpense, IList<ExpenseVm>>
    {
        private readonly IExpenseService _expenseService;
        private readonly IMapper _mapper;

        public GetExpenseHandler(IExpenseService expenseService, IMapper mapper)
        {

            _expenseService = expenseService ?? throw new ArgumentNullException(nameof(_expenseService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));

        }

        public async Task<IList<ExpenseVm>> Handle(GetExpense request, CancellationToken cancellationToken)
        {
            var expense = await _expenseService.GetExpense();
            return _mapper.Map<IList<ExpenseVm>>(expense);
        }
    }
}
