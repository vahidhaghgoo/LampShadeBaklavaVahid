﻿using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ShopManagement.Application.Contracts.ProductPicture
{
    public class CreateProductPicture
    {
        [Range(1,100000, ErrorMessage = ValidationMessages.IsRequired )]
        public long ProductId { get;  set; }
        [MaxFileSize(1 * 1024 *1024 ,ErrorMessage = ValidationMessages.MaxFilesize)]
       public IFormFile Picture { get;  set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]

        public string PictureAlt { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]

        public string PictureTitle { get;  set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
