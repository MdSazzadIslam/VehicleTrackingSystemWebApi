using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("L_EXPENSE_SUB_TYPE")]
    public class ExpenseSubType : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EXPENSE_SUB_TYPE_ID")]
        public int ExpenseSubTypeId { get; set; }

        [Column("EXPENSE_SUB_TYPE_NAME")]
        public string ExpenseSubTypeName { get; set; }

        [Column("EXPENSE_TYPE_ID")]
        [ForeignKey("EXPENSE_TYPE_ID")]
        public int ExpenseTypeId { get; set; }

        [Column("DELETED")]
        public bool Deleted { get; set; }
    }
}
