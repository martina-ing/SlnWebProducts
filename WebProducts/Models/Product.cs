using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProducts.Models
{
    public class Product
    {
        [Key()]
        public int Id { get; set; }



        [StringLength(150)]
        public string Category { get; set; }



        [DisplayName("Name")]
        [StringLength(150)]
        public string ProductName { get; set; }


        [StringLength(150)]
        public string Description { get; set; }


        [DisplayName("Available Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime AvailableDate { get; set; }


    }
}