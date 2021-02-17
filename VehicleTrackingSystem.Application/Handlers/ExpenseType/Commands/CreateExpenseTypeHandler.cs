using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType.Commands
{
    public class CreateExpenseTypeHandler : IRequestHandler<CreateExpenseType, ResultModel>
    {
        private readonly IExpenseTypeService _expenseTypeService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        private readonly IMapper _mapper;

        public CreateExpenseTypeHandler(IExpenseTypeService expenseService, ICurrentUserService currentUserService, IDateTime dateTime, IMapper mapper)
        {

            _expenseTypeService = expenseService ?? throw new ArgumentNullException(nameof(_expenseTypeService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ResultModel> Handle(CreateExpenseType request, CancellationToken cancellationToken)
        {
             
            var data = _mapper.Map<ExpenseTypeVm>(request);
            var result = await _expenseTypeService.CreateExpenseType(data);
            return result;
        }
    }
}
