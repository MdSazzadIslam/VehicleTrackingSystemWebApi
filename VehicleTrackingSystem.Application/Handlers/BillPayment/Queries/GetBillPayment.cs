﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Queries
{
    public class GetBillPayment : IRequest<IList<Domain.Entities.BillPayment>>
    {
        public GetBillPayment()
        {

        }

    }
}