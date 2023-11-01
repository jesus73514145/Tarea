using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace tarea_12082023_jesus_soria.Models {
    public enum Genero {
        [Display(Name = "Masculino")]
        Masculino, 
        
        [Display(Name = "Femenino")]
        Femenino
    }
}