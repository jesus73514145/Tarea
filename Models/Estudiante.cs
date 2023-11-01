using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tarea_12082023_jesus_soria.Models {
    [Serializable]
    public class Estudiante {
    
        [Required(ErrorMessage = "Debe escribir el nombre")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string Apellido_Paterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string Apellido_Materno { get; set; }

        [Display(Name = "Genero")]
        public Genero Genero { get; set; }

        [Display(Name = "Curso")]
        public Curso Curso { get; set; }

        public string Registrar() {
            double costoCredito = 250; // Costo de cada crédito
            double costoTotal = 0;

            if (!string.IsNullOrEmpty(Nombre)) {
                if (!string.IsNullOrEmpty(Apellido_Paterno)) {
                    if (!string.IsNullOrEmpty(Apellido_Materno)) {
                        switch (Curso) {
                            case Curso.MATEMATICA:
                                costoTotal = 3 * costoCredito;
                                break;
                            case Curso.LENGUAJE:
                                costoTotal = 1 * costoCredito;
                                break;
                            case Curso.FISICA:
                                costoTotal = 2 * costoCredito;
                                break;
                        }

                        return "Estudiante: " + Nombre + 
                            " " + Apellido_Paterno + 
                            " " + Apellido_Materno +
                            "\nGénero: " + Genero +
                            "\nCurso: " + Curso +
                            "\nCosto Total del Curso: " + costoTotal.ToString("C"); // Formato de moneda
                    } else {
                        throw new ArgumentException("No ingresó el apellido materno");
                    }
                } else {
                throw new ArgumentException("No ingresó el apellido paterno");     
                }
            } else {
                throw new ArgumentException("No ingresó el nombre");       
            }
        }
    }
}