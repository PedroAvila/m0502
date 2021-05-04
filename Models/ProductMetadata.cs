﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace M0502.Models
{
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
        class ProductMetadata
        {
            [Display(Name = "Nombre del producto:")]
            public object ProductName { get; set; }

            [Display(Name = "Precio Unitario")]
            [DisplayFormat(DataFormatString = "{0:C}")]
            public object UnitPrice { get; set; }
        }
    }
    
}