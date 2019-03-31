using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HTML_HELPERS.Models
{
    public class FormularioContext:DbContext
    {   
        public FormularioContext()
            : base("FormularioDB")
        { 
        }

        public DbSet<Formulario> formulario { get; set; }
    }
}