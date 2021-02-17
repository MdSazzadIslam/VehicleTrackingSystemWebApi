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
    public class DeleteExpenseTypeHandler : IRequestHandler<DeleteExpenseType, ResultModel>
    {

        private readonly IExpenseTypeService _expenseTypeService;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;


        public DeleteExpenseTypeHandler(IExpenseTypeService expenseTypeService, ICurrentUserService currentUserService, IDateTime dateTime, IMapper mapper)
        {

            _expenseTypeService = expenseTypeService ?? throw new ArgumentNullException(nameof(_expenseTypeService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));

        }

        public async Task<ResultModel> Handle(DeleteExpenseType request, CancellationToken cancellationToken)
        {
            var result = await _expenseTypeService.DeleteExpenseType(request.Id);
            return result;
        }
    }
}
