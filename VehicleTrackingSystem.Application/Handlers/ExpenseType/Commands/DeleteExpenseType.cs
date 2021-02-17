using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType.Commands
{
    public class DeleteExpenseType : IRequest<ResultModel>
    {
        [Required]
        public int Id { get; set; }
        public DeleteExpenseType(int id)
        {
            Id = id;
        }
    }
}
