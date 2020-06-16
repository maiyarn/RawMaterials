﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawMaterials.Models.Entities
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Province> Provinces { get; set; }
    }
}