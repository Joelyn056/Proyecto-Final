using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Cargo { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            NombreUsuario = string.Empty;
            Clave = string.Empty;
            Cargo = string.Empty;
        }

        public Usuarios(int usuarioId, string nombres, string nombreUsuario, string clave, string cargo)
        {
            UsuarioId = usuarioId;
            Nombres = nombres;
            NombreUsuario = nombreUsuario;
            Clave = clave;
            Cargo = cargo;
        }
    }
}
