using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Expense.Commands
{
    public class DeleteExpense : IRequest<ResultModel>
    {
        public int Id { get; set; }
        public DeleteExpense( int id)
        {
            Id = id;
        }

    }
}
