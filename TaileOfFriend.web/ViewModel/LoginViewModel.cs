﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TaileOfFriend.web.ViewModel
{
    public class LoginViewModel
    {

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

       

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Рік народження")]
        public DateTime BirthDate { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
