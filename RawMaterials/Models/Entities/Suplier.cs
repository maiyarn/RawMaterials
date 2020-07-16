﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RawMaterials.Models.Entities
{
    public class Suplier : User
    {

        public bool PremiumAccount { get; set; }

        public float Rank { get; set; }

        [Required]
        public string CommericialRecord { get; set; }

        public virtual List<SuplierCategory> SuplierCategories { get; set; }

        public virtual List<FeedBack> FeedBacks { get; set; }

        public virtual List<SuplierMaterial> SuplierMaterials { get; set; }





    }
}
