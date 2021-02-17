using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("L_EXPENSE_TYPE")]
    public class ExpenseType : AuditableEntity
    {
        [Column("EXPENSE_TYPE_ID")]
        public int ExpenseTypeId { get; set; }

        [Column("EXPENSE_TYPE_NAME")]
        public string ExpenseTypeName { get; set; }

        [Column("DELETED")]
        public bool Deleted { get; set; }

    }
}
