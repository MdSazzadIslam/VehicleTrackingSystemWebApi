using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType.queries
{
    public class GetExpenseTypeHandler : IRequestHandler<GetExpenseType, IList<ExpenseTypeReturnVm>>
    {
        private readonly IExpenseTypeService _expenseTypeService;
        private readonly IMapper _mapper;

        public GetExpenseTypeHandler(IExpenseTypeService expenseService, IMapper mapper)
        {
            _expenseTypeService = expenseService ?? throw new ArgumentNullException(nameof(_expenseTypeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }


        public async Task<IList<ExpenseTypeReturnVm>> Handle(GetExpenseType request, CancellationToken cancellationToken)
        {
            var expenses = await _expenseTypeService.GetExpenseType();
            return _mapper.Map<IList<ExpenseTypeReturnVm>>(expenses);
        }
    }
}
