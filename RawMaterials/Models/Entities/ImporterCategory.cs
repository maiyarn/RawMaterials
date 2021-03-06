﻿namespace RawMaterials.Models.Entities
{
    public class ImporterCategory
    {
        public long Id { get; set; }

        public virtual Category Category { get; set; }

        public long CategoryId { get; set; }

        public virtual Importer Importer { get; set; }

        public string ImporterId { get; set; }



    }
}
