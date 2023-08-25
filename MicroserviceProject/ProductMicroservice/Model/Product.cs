﻿using System;
namespace ProductMicroservice.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }
    }

}