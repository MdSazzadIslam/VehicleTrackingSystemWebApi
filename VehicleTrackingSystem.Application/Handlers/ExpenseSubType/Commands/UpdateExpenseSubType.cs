using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands
{
    public class UpdateExpenseSubType : IRequest<ResultModel>
    {
        public int ExpenseSubTypeId { get; set; }
        public string ExpenseSubTypeName { get; set; }
        public int ExpenseTypeId { get; set; }

        public UpdateExpenseSubType(int expenseSubTypeId, string expenseSubTypeName, int expenseTypeId)
        {
            ExpenseSubTypeId = expenseSubTypeId;
            ExpenseSubTypeName = expenseSubTypeName;
            ExpenseTypeId = expenseTypeId;
        }

    }
}
