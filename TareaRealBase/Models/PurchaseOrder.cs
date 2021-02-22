﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TareaRealBase.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }

        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal Taxes { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string Notes { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? SubmittedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual PurchaseOrderStatus Status { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
