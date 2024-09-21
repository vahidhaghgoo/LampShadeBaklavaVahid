﻿using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace ShopManagement.Application.Contracts.Slide2;

public class CreateSlide2
{
    public IFormFile Picture { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string PictureAlt { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]


    public string PictureTitle { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]


    public string Title { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]


    public string Text { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]


    public string BtnText { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]

    public string Link { get; set; }
}