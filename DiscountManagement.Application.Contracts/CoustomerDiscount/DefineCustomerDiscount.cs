﻿using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Application.Contracts.CoustomerDiscount
{
    public class DefineCustomerDiscount
    {
        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]

        public long ProductId { get;  set; }
        [Range(1, 99, ErrorMessage = ValidationMessages.IsRequired)]

        public int DiscountRate { get;  set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]

        public string StartDate { get;set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]


        public string EndDate { get;set; }
        public string Reason { get;  set; }
        public List<ProductViewModel> Products { get; set; }
       
    }
}
