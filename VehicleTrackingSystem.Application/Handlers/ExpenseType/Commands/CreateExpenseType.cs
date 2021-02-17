using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType.Commands
{
    public class CreateExpenseType : IRequest<ResultModel>
    {
        public int ExpenseTypeId { get; set; }
        public string ExpenseTypeName { get; set; }

        public CreateExpenseType(int expenseTypeId, string expenseTypeName)
        {

            ExpenseTypeId = expenseTypeId;
            ExpenseTypeName = expenseTypeName;

        }
    }
}
