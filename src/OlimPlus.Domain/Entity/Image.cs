﻿using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Image : BaseEntity
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; } = String.Empty;
        public Product Product { get; set; }
    }
}