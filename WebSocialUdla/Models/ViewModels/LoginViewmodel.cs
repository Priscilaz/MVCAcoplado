﻿using System.ComponentModel.DataAnnotations;

namespace WebSocialUdla.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Ingrese el Nombre de Usuario")] 
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Ingrese la Contraseña")]
        [MinLength(6, ErrorMessage = "Este campo debe contener al menos 6 caracteres, una letra Mayúscula y un caracter especial")]

        public string Contrasenia { get; set; }

        //public string? ReturnUrl { get; set; }

    }
}
