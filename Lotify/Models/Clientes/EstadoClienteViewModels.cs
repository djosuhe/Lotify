﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lotify.Models.Clientes
{
    public class EstadoClienteViewModels
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Se requiere el nombre del estado.")]
        [Display(Name = "Nombre del Estado")]
        public string NombreEstado { get; set; }
    }
}