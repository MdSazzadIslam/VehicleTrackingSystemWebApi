using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Queries
{
    public class GetExpenseSubTypeByIdHandler : IRequestHandler<GetExpenseSubTypeById, ExpenseSubTypeReturnVm>
    {
        private readonly IExpenseSubTypeService _expenseSubTypeService;
        private readonly IMapper _mapper;

        public GetExpenseSubTypeByIdHandler(IExpenseSubTypeService expenseSubTypeService, IMapper mapper)
        {

            _expenseSubTypeService = expenseSubTypeService ?? throw new ArgumentNullException(nameof(_expenseSubTypeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
           
        }

        public async Task<ExpenseSubTypeReturnVm> Handle(GetExpenseSubTypeById request, CancellationToken cancellationToken)
        {
            var expenses = await _expenseSubTypeService.GetExpenseSubTypeById(request.Id);
            return _mapper.Map<ExpenseSubTypeReturnVm>(expenses);
        }
    }
}
