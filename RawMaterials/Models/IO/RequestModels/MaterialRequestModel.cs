﻿namespace RawMaterials.Models.IO.RequestModels
{
    public class MaterialRequestModel
    {
        public long Id { get; set; }

        public long CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
