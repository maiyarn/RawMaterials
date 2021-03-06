﻿namespace RawMaterials.Models.Entities
{
    public class FeedBack
    {
        public long Id { get; set; }

        public virtual Suplier Suplier { get; set; }

        public string SuplierId { get; set; }

        public virtual Importer Importer { get; set; }

        public string ImporterId { get; set; }

        public int Rate { get; set; }

        public string Notes { get; set; }

    }
}
