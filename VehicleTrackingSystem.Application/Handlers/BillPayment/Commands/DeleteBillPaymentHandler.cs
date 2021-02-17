using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Commands
{
    public class DeleteBillPaymentHandler : IRequestHandler<DeleteBillPayment, Result>
    {
        private readonly IBillPaymentService _billPaymentService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public DeleteBillPaymentHandler(IBillPaymentService billPaymentService, ICurrentUserService currentUserService, IDateTime dateTime)
        {

            _billPaymentService = billPaymentService ?? throw new ArgumentNullException(nameof(_billPaymentService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));

        }

        public async Task<Result> Handle(DeleteBillPayment request, CancellationToken cancellationToken)
        {
            var result = await _billPaymentService.DeleteBillPayment(request.Id);
            return result;
        }
    }
}
