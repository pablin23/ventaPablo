using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ventas2.Models
{
    public class usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public List<Models.tipoUsuario> cargo{get;set;}
    }
}