﻿using System.ComponentModel.DataAnnotations;

namespace LaptopStore.Data.Enum
{
    public enum Role
    {
        [Display(Name = "user")]
        User = 0,
        [Display(Name = "Moderator")]
        Moderator = 1,
        [Display(Name = "Admin")]
        Admin = 2,
    }
}