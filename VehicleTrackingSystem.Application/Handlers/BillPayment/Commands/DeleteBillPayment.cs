using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Commands
{
    public class DeleteBillPayment : IRequest<Result>
    {
        public int Id { get; set; }
        public DeleteBillPayment(int id)
        {
            Id = id;
        }

    }
}
