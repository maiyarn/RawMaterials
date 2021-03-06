﻿using System;

namespace RawMaterials.Models.Entities
{
    public class PaymentInfo
    {
        public long Id { get; set; }

        public virtual User User { get; set; }

        public string UserId { get; set; }

        public string Paymnet_Type { get; set; }

        public string Description { get; set; }

        public DateTime Payment_Date { get; set; }

        public string Payment_Method { get; set; }

        public string Payment_Reason { get; set; }



    }
}
