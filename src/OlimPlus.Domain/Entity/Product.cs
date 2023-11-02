﻿using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int ManufacturerId { get; set; }
        public int CategoryId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Category Category { get; set; }
    }
}