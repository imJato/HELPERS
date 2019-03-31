using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HTML_HELPERS.Models
{
    public class Formulario
    {

        public int ID { get; set; }

        [Required (ErrorMessage ="Debe llenar este campo")]
        public String cedula { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        public String apellido { get; set; }

        [Range(5,100,ErrorMessage ="La edad debe estar entre los 5 y 100 años")]
        [Required(ErrorMessage = "Debe llenar este campo")]
        public int edad { get; set; }

        [MinLength(10)]
        public String telefono { get; set; }

        [EmailAddress(ErrorMessage ="Correo no detectado, verifique...")]
        [RegularExpression("^[_A-Za-z'`+-.]+([_A-Za-z0-9'+-.]+)*@([A-Za-z0-9-])+(\\.[A-Za-z0-9]+)*(\\.([A-Za-z]*){3,})$", ErrorMessage = "Formato incorrecto")]
        [Required(ErrorMessage ="El correo es requerido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Formato Incorrecto")]
        public String Correo { get; set; }

        public String genero { get; set; }

        public String estado { get; set; }

        public bool hobbies { get; set; }

        public generos GenerosPersonas { get; set; }

    }
    public enum generos
    {
        Masculino,
        Femenino,
        Otro
    }
}