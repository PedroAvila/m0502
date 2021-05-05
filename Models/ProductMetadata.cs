using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M0502.Models
{
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
        class ProductMetadata
        {
            [HiddenInput(DisplayValue = false)]
            public int ProductID { get; set; }

            [Display(Name = "Nombre del producto:")]
            [DataType(DataType.MultilineText)]
            public object ProductName { get; set; }

            [Display(Name = "Precio Unitario")]
            [DisplayFormat(DataFormatString = "{0:C}")]
            public object UnitPrice { get; set; }

            [Display(Name = "Producto discontinuado")]
            public bool Discontinued { get; set; }
        }
    }
    
}