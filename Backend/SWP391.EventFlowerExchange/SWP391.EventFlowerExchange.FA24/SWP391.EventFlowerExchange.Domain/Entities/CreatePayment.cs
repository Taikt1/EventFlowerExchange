﻿using SWP391.EventFlowerExchange.Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.EventFlowerExchange.Domain.Entities
{
    public class CreatePayment
    {
        public string? PaymentCode { get; set; }

        public string? UserId { get; set; }

        public int? RequestId { get; set; }

        public string? ResponseCode { get; set; }

        public int? PaymentType { get; set; }

        public string? PaymentContent { get; set; }

        public decimal? Amount { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreatedAt { get; set; }

    }
}
