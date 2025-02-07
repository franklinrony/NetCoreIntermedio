﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace RealTimeApplication.API.Infrastructure.Data.Entities
{
    public partial class Product
    {
        public Product()
        {
            TrackingProducts = new HashSet<TrackingProduct>();
        }

        public int ProductId { get; set; }
        public string Description { get; set; }
        public string Feature01 { get; set; }
        public string Feature02 { get; set; }
        public decimal Price { get; set; }
        public string FileImage { get; set; }

        public virtual ICollection<TrackingProduct> TrackingProducts { get; set; }
    }
}