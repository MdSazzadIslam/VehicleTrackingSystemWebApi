using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Queries
{
    public class GetExpenseSubTypeHandler : IRequestHandler<GetExpenseSubType, IList<ExpenseSubTypeReturnVm>>
    {
        private readonly IExpenseSubTypeService _expenseSubTypeService;
        private readonly IMapper _mapper;

        public GetExpenseSubTypeHandler(IExpenseSubTypeService expenseSubTypeService, IMapper mapper)
        {

            _expenseSubTypeService = expenseSubTypeService ?? throw new ArgumentNullException(nameof(_expenseSubTypeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));

        }

        public async Task<IList<ExpenseSubTypeReturnVm>> Handle(GetExpenseSubType request, CancellationToken cancellationToken)
        {
            var expenses = await _expenseSubTypeService.GetExpenseSubType();
            return _mapper.Map<IList<ExpenseSubTypeReturnVm>>(expenses);
        }
    }
}
