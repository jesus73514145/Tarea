using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace tarea_12082023_jesus_soria.Models {
    public enum Curso {

        [Display(Name = "Matemática")]
        MATEMATICA, 
        
        [Display(Name = "Lenguaje")]
        LENGUAJE, 
        
        [Display(Name = "Física")]
        FISICA
    }
}