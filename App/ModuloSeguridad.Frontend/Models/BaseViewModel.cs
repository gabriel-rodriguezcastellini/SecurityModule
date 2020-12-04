using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Models
{
    public class BaseViewModel
    {
        public string ErrorMessage { get; set; }

        public string InfoMessage { get; set; }        
    }
}
