﻿namespace EasyPTC.Web.Areas.Administration.ViewModels.Base
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public abstract class AdministrationViewModel
    {
        [Display(Name = "Добавено на")]
        [HiddenInput(DisplayValue = false)]
        public DateTime CreatedOn {
            get
            {
                return DateTime.Now;
            }
            set
            {
                value = DateTime.Now;
            }
        }  

        [Display(Name = "Променено на")]
        [HiddenInput(DisplayValue = false)]
        public DateTime? ModifiedOn { get; set; }
    }
}