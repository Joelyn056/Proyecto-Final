using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;
using DAL;
using System.Threading.Tasks;

namespace ProyectoFinal.UI
{
    public partial class FacturasForm : Form
    {
        public List<FacturaDetalle> facturaDetalle = new List<FacturaDetalle>();
        public FacturasForm()
        {
            InitializeComponent();
            LlenarComboBox();
            //facturas = new Facturas();
            
        }


        private void LlenaCampo(Facturas facturas)//
        {
            FacturaIdNumericUpDown.Value = facturas.FacturaId;
            ClienteComboBox.SelectedValue = facturas.ClienteId;
            FechaDateTimePicker.Value = facturas.Fecha;
            SuBTotalNumericUpDown.Value = Convert.ToInt32(facturas.SubTotal);
            ITBISNumericUpDown.Value = Convert.ToInt32(facturas.Itbis);
            TotalNumericUpDown.Value = Convert.ToInt32(facturas.Total);          


            DetalledataGridView.DataSource = facturas.Detalle.ToList();

            //DetalledataGridView.Columns["Id"].Visible = false;
            //DetalledataGridView.Columns["FacturaId"].Visible = false;

            int c = 0;
            foreach(var item in DetalledataGridView.Columns)
            {
                c++;
            }
            for(int i = 0; i < c; i++)
            {
                if (i > 8)
                {
                    DetalledataGridView.Columns[i].Visible = false;
                }
            }
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;
        }

        private Facturas LlernarClase()
        {
            Facturas facturas = new Facturas();

            facturas.FacturaId = Convert.ToInt32(FacturaIdNumericUpDown.Value);
            facturas.ClienteId = ((Clientes)ClienteComboBox.SelectedItem).ClienteId;  
            facturas.Fecha = FechaDateTimePicker.Value;
            facturas.SubTotal = Convert.ToInt32(SuBTotalNumericUpDown.Value);
            facturas.Itbis = Convert.ToInt32(ITBISNumericUpDown.Value);
            facturas.Total = Convert.ToInt32(TotalNumericUpDown.Value);
            facturas.Detalle = facturaDetalle;

            return facturas;
        }

        private void LlenarComboBox()
        {
            Repositorio<Clientes> clientes = new Repositorio<Clientes>(new Contexto());
            Repositorio<Productos> productos = new Repositorio<Productos>(new Contexto());
            Repositorio<Usuarios> usuarios = new Repositorio<Usuarios>(new Contexto());

            ClienteComboBox.DataSource = clientes.GetList(c => true);
            ClienteComboBox.DisplayMember = "Nombres";
            ClienteComboBox.ValueMember = "Nombres";

            ProductoComboBox.DataSource = productos.GetList(p => true);
            ProductoComboBox.DisplayMember = "Descripcion";
            ProductoComboBox.ValueMember = "Descripcion";

            //UsuariosComboBox.DataSource = usuarios.GetList(u => true);
            //UsuariosComboBox.ValueMember = "UsuarioId";
            //UsuariosComboBox.ValueMember = "Nombres";
            
        }

        //private void LlenarUsuario()
        //{
        //    UsuariosComboBox.DataBindings.Clear();
        //    var Usuario = UsuariosBLL.GetList(u => true);
        //    Binding doBinding = new Binding("Text", Usuario, "Nombres");
        //    UsuariosComboBox.DataBindings.Add(doBinding);
        //}


        private void BuscarFacturaIdButton_Click(object sender, EventArgs e)//Buscar FacturaId
        {
            GeneralErrorProvider.Clear();

            int id = Convert.ToInt32(FacturaIdNumericUpDown.Value);
            Facturas facturas = BLL.FacturasBLL.Buscar(id);

            if (facturas != null)
            {
                FacturaIdNumericUpDown.Value = facturas.FacturaId;
                SuBTotalNumericUpDown.Value = facturas.SubTotal;
                ITBISNumericUpDown.Value = facturas.Itbis;
                TotalNumericUpDown.Value = facturas.Total;
                DetalledataGridView.DataSource = facturas.Detalle.ToList();

            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private bool Validar()
        {
            bool Validar = false;
            if(DetalledataGridView.RowCount == 0)
            {
                GeneralErrorProvider.SetError(DetalledataGridView, "No hay datos para mostar");
                Validar = true;
            }

            return Validar;
        }

        private void CalcularImporte()
        {
            if (CantidadNumericUpDown.Value != 0)
            {
                ImporteNumericUpDown.Value = BLL.ProductosBLL.CalcularImporte(CantidadNumericUpDown.Value, PrecioNumericUpDown.Value);
            }
            else
                ImporteNumericUpDown.Value = 0;
        }


        private void NuevoButton_Click(object sender, EventArgs e)
        {
            FacturaIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            ClienteComboBox.SelectedIndex = 0;
            ProductoComboBox.SelectedIndex = 0;
            CantidadNumericUpDown.Value = 0;
            PrecioNumericUpDown.Value = 0;
            ImporteNumericUpDown.Value = 0;
            SuBTotalNumericUpDown.Value = 0;
            ITBISNumericUpDown.Value = 0;
            TotalNumericUpDown.Value = 0;
            DetalledataGridView.DataSource = null;
            GeneralErrorProvider.Clear();

        }

        private void AgregarButton_Click(object sender, EventArgs e)//AgregarButton
        {

            FacturaDetalle detalle = new FacturaDetalle(

                0,
                (int)FacturaIdNumericUpDown.Value,
                ((Productos)ProductoComboBox.SelectedItem).ProductoId,
                ((Productos)ProductoComboBox.SelectedItem).Descripcion,
                (int)CantidadNumericUpDown.Value,
                PrecioNumericUpDown.Value,              
                ImporteNumericUpDown.Value
            );
            facturaDetalle.Add(detalle);

            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = facturaDetalle.ToList(); 

            DetalledataGridView.Columns["id"].Visible = false;
            DetalledataGridView.Columns["facturaId"].Visible = false;
            DetalledataGridView.Columns["productoId"].Visible = false;

            Total();
        }

        private void Total()
        {
            List<FacturaDetalle> detalle = (List<FacturaDetalle>)DetalledataGridView.DataSource;

            decimal Total = 0;
            decimal Itb;
            Itb = 0.18M;

            foreach (var item in detalle)
            {
                Total += item.Importe;
            }
            TotalNumericUpDown.Text = Total.ToString();
            ITBISNumericUpDown.Value = TotalNumericUpDown.Value * Itb;
            SuBTotalNumericUpDown.Value = TotalNumericUpDown.Value - ITBISNumericUpDown.Value;
        }

        //private void AgregarDetalle(FacturaDetalle facturaDetalle)
        //{
        //    foreach (var item in facturas.Detalle)
        //    {
        //        if(item.FacturaId == facturaDetalle.FacturaId)
        //        {
        //            item.Cantidad += facturaDetalle.Cantidad;
        //            item.Importe = item.Precio * item.Cantidad;

        //            return;
        //        }
        //    }

        //    facturas.Detalle.Add(facturaDetalle);
        //}


        private void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Productos productos = (Productos)ProductoComboBox.SelectedItem;
            PrecioNumericUpDown.Value = Convert.ToDecimal(productos.Precio);
        }



        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalcularImporte();
            CalcularSubtotal();
            CalcularItbis();
            CalcularTotal();
        }

        private void CalcularSubtotal()
        {
            if(ImporteNumericUpDown.Value != 0)
            {
                SuBTotalNumericUpDown.Value = BLL.ProductosBLL.CalcularSubtotal(ImporteNumericUpDown.Value);
            }
        }

        private void CalcularItbis()
        {
            if (SuBTotalNumericUpDown.Value != 0)
            {
                ITBISNumericUpDown.Value = BLL.ProductosBLL.CalcularItbis(SuBTotalNumericUpDown.Value);
            }
        }

        private void CalcularTotal()
        {
            if(SuBTotalNumericUpDown.Value !=0 && ITBISNumericUpDown.Value !=0)
            {
                TotalNumericUpDown.Value = BLL.ProductosBLL.CalcularTotal(SuBTotalNumericUpDown.Value, ITBISNumericUpDown.Value);
            }
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if(DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                List<FacturaDetalle> Detalle = (List<FacturaDetalle>)DetalledataGridView.DataSource;///

                Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);

                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = Detalle;
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Facturas facturas;
            bool paso = true;

            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            facturas = LlernarClase();

            if (FacturaIdNumericUpDown.Value == 0)
            {
                facturas = LlernarClase();
                paso = BLL.FacturasBLL.Guardar(facturas);
               
            }
            else
            {
                facturas = LlernarClase();
                paso = BLL.FacturasBLL.Modificar(facturas);
            }
            if (paso)
            {
                NuevoButton.PerformClick();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo Guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GeneralErrorProvider.Clear();
        }


        private void EliminarButton_Click(object sender, EventArgs e)
        {
            GeneralErrorProvider.Clear();

            int id = Convert.ToInt32(FacturaIdNumericUpDown.Value);
            Facturas facturas = FacturasBLL.Buscar(id);

            if(facturas != null)
            {
                if(FacturasBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("no se pudo Eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("no existe!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GeneralErrorProvider.Clear();
        }
       
    }
}
