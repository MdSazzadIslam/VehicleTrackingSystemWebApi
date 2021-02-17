using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands
{
    public class DeleteExpenseSubType : IRequest<ResultModel>
    {
        public int Id { get; set; }
        public DeleteExpenseSubType(int id)
        {
            Id = id;
        }
    }
}
