using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType.queries
{
    public class GetExpenseTypeByIdHandler : IRequestHandler<GetExpenseTypeById, ExpenseTypeReturnVm>
    {
        private readonly IExpenseTypeService _expenseTypeService;
        private readonly IMapper _mapper;

        public GetExpenseTypeByIdHandler(IExpenseTypeService expenseService, IMapper mapper)
        {
            _expenseTypeService = expenseService ?? throw new ArgumentNullException(nameof(_expenseTypeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }

        public async Task<ExpenseTypeReturnVm> Handle(GetExpenseTypeById request, CancellationToken cancellationToken)
        {
            var expenses = await _expenseTypeService.GetExpenseTypeById(request.Id);
            return _mapper.Map<ExpenseTypeReturnVm>(expenses);
        }
    }
}
