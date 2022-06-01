﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LaptopStore.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Name length must not exceed 30 characters.")]
        public string name { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Last Name length must not exceed 30 characters.")] 
        public string lastName { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Address length must not exceed 100 characters.")] 
        public string address { get; set; }
        
        [Phone]
        [Required]
        public string phoneNumber { get; set; }

        [StringLength(30)]
        [EmailAddress(ErrorMessage = "Email length must not exceed 30 characters.")]
        public string email { get; set; }
        
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public ICollection<OrderDetail> orderDetails { get; set; }
    }
}