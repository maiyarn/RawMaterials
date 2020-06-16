﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawMaterials.Models.Entities
{
    public class Notification
    {
        public long Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public string Type { get; set; }

        public string notification_text { get; set; }

        public DateTime Read_at { get; set; }

        
    }
}