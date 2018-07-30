using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BLL
{
    public class FacturasBLL
    {
        public static bool Guardar(Facturas facturas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {

                contexto.Facturas.Add(facturas);

                //if (contexto.Facturas.Add(facturas) != null)
                //{
                //    foreach (var item in facturas.Detalle)//
                //    {

                //        contexto.Productos.Find(item.ProductoId).Inventario -= item.Cantidad;
                //        //var producto = contexto.Productos.Find(item.ProductoId);
                //        //producto.Inventario -= item.Cantidad;

                //        //var cliente = contexto.Clientes.Find(item.ClienteId);
                //        //cliente.NombreUsuario += Convert.ToDecimal(item.Importe);
                //    }

                    /*contexto.Clientes.Find(facturas.ClienteId).NumeroCelular += facturas.Total;*///ojo

                    contexto.SaveChanges();
                    paso = true;
                //}
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Modificar(Facturas facturas)
        {
            bool paso = true;
            Contexto contexto = new Contexto();
            try
            {
                int sum = 0;
                int sumTotal = 0;
                foreach(var item in facturas.Detalle)
                {
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;

                    sum += item.Cantidad;
                    sumTotal += Convert.ToInt32(item.Importe);
                    contexto.Productos.Find(item.ProductoId).Inventario -= sum;
                    //contexto.Clientes.Find(item.ClienteId).
                }

                contexto.Entry(facturas).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Facturas facturas = contexto.Facturas.Find(id);

                foreach(var item in facturas.Detalle)//
                {
                    var producto = contexto.Productos.Find(item.ProductoId);
                    producto.Inventario += item.Cantidad;

                    //var facturas = contexto.Facturas.Find(item.FacturaId);
                    //facturas.
                }

                contexto.Facturas.Remove(facturas);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }

            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Facturas Buscar(int id)
        {
            Facturas facturas = null;
            Contexto contexto = new Contexto();
            try
            {
                facturas = contexto.Facturas.Find(id);

                //if(facturas != null)
                //{
                   //facturas.Detalle.Count();

                    //foreach (var item in facturas.Detalle)//
                    //{
                    //    string s = item.Productos.Descripcion;
                    //    //string ss = item.Facturas.FacturaId.ToString();
                    //}

                //}
                //facturas.Detalle.Count();

                //foreach (var item in facturas.Detalle)//
                //{
                //    string s = item.Clientes.Nombres;
                //    string f = item
                //}

                //contexto.Dispose();
            }

            catch (Exception)
            {
                throw;
            }

            return facturas;
        }

        public static List<Facturas> GetList(Expression<Func<Facturas, bool>> expression)
        {

            List<Facturas> facturas = new List<Facturas>();
            Contexto contexto = new Contexto();

            try
            {
                facturas = contexto.Facturas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return facturas;
        }
    }
}
