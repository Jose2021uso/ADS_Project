using ADS_Project.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADS_Project.Models
{
    public class GrupoViewModel
    {
        [Display(Name = "ID")]
        public int idGrupo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "La longitud del campo no debe ser mayor a 5 caracteres ni menor a 1 caracteres.")]
        [Display(Name = "CARRERA")]
        public string idCarrera { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "La longitud del campo no debe ser mayor a 5 caracteres ni menor a 1 caracteres.")]
        [Display(Name = "MATERIA")]
        public string idMateria { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "La longitud del campo no debe ser mayor a 5 caracteres ni menor a 1 caracteres.")]
        [Display(Name = "PROFESOR")]
        public string idProfesor { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "La longitud del campo no debe ser mayor a 5 caracteres ni menor a 1 caracteres.")]
        [Display(Name = "CICLO")]
        public string Ciclo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "La longitud del campo no debe ser de 4 caracteres.")]
        [Display(Name = "AÑO")]
        public string Anio { get; set; }
    }
}
