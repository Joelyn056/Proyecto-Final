using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Entidades
{
    public class Clientes
    {

        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public string Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public string NumeroCelular { get; set; }


        public Clientes()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Sexo = string.Empty;
            Cedula = string.Empty;
            Fecha = DateTime.Now;
            Direccion = string.Empty;
            NumeroCelular = string.Empty;


        }

        public Clientes(int clienteId, string nombres, string sexo, string cedula, DateTime fecha, string direccion, string numeroCelular)
        {
            ClienteId = clienteId;
            Nombres = nombres;
            Sexo = sexo;
            Cedula = cedula;
            Fecha = fecha;
            Direccion = direccion;
            NumeroCelular = numeroCelular;

        }
    }
}
