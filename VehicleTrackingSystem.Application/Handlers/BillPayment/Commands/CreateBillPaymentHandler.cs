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
    public class CreateBillPaymentHandler : IRequestHandler<CreateBillPayment, Result>
    {
        private readonly IBillPaymentService _billPaymentService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public CreateBillPaymentHandler(IBillPaymentService billPaymentService, ICurrentUserService currentUserService, IDateTime dateTime)
        {
            _billPaymentService = billPaymentService ?? throw new ArgumentNullException(nameof(_billPaymentService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));
        }
        public async Task<Result> Handle(CreateBillPayment request, CancellationToken cancellationToken)
        {
            var bills = new Domain.Entities.BillPayment
            {

                BillPaymentId = request.BillPaymentId,
                BillNo = request.BillNo,
                PaymentDate = request.PaymentDate,
                BillingAmount = request.PaymentAmount,
                DiscountAmount = request.DiscountAmount,
                DueAmount = request.DueAmount,
                PaymentAmount = request.PaymentAmount,

                UpdateBy = _currentUserService.UserId,
                UpdateDate = _dateTime.Now,
                CreatedBy = _currentUserService.UserId,
                CreateDate = _dateTime.Now,

            };

            var result = await _billPaymentService.CreateBillPayment(bills);
            return result;
        }
    }
}
