namespace ProyectoFinal.UI.Registros
{
    partial class RegistroProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productoIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProductos));
            this.ProductoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.GananciaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.PrecioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CantidaderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CostoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GeneralErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.InventarioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            productoIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GananciaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidaderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // productoIdLabel
            // 
            productoIdLabel.AutoSize = true;
            productoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productoIdLabel.Location = new System.Drawing.Point(33, 55);
            productoIdLabel.Name = "productoIdLabel";
            productoIdLabel.Size = new System.Drawing.Size(88, 18);
            productoIdLabel.TabIndex = 49;
            productoIdLabel.Text = "Producto Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(33, 96);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(91, 18);
            descripcionLabel.TabIndex = 50;
            descripcionLabel.Text = "Descripcion:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(191, 194);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(71, 18);
            cantidadLabel.TabIndex = 51;
            cantidadLabel.Text = "Ganancia";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoLabel.Location = new System.Drawing.Point(36, 198);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(53, 18);
            costoLabel.TabIndex = 52;
            costoLabel.Text = "Costo:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(34, 236);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(55, 18);
            precioLabel.TabIndex = 53;
            precioLabel.Text = "Precio:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaIngresoLabel.Location = new System.Drawing.Point(33, 140);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(106, 18);
            fechaIngresoLabel.TabIndex = 54;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // ProductoIdNumericUpDown
            // 
            this.ProductoIdNumericUpDown.Location = new System.Drawing.Point(140, 57);
            this.ProductoIdNumericUpDown.Name = "ProductoIdNumericUpDown";
            this.ProductoIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ProductoIdNumericUpDown.TabIndex = 55;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(140, 97);
            this.DescripcionTextBox.MaxLength = 250;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.DescripcionTextBox.TabIndex = 44;
            // 
            // GananciaNumericUpDown
            // 
            this.GananciaNumericUpDown.Location = new System.Drawing.Point(267, 194);
            this.GananciaNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.GananciaNumericUpDown.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.GananciaNumericUpDown.Name = "GananciaNumericUpDown";
            this.GananciaNumericUpDown.Size = new System.Drawing.Size(97, 20);
            this.GananciaNumericUpDown.TabIndex = 45;
            this.GananciaNumericUpDown.ValueChanged += new System.EventHandler(this.GananciaNumericUpDown_ValueChanged);
            // 
            // FechaIngresoDateTimePicker
            // 
            this.FechaIngresoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaIngresoDateTimePicker.Location = new System.Drawing.Point(140, 139);
            this.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker";
            this.FechaIngresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaIngresoDateTimePicker.TabIndex = 48;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::ProyectoFinal.Properties.Resources.new2;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(35, 295);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(85, 55);
            this.NuevoButton.TabIndex = 56;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources.Save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(169, 295);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 55);
            this.GuardarButton.TabIndex = 57;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources.Delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(286, 295);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(85, 54);
            this.EliminarButton.TabIndex = 58;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ProyectoFinal.Properties.Resources.find;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(278, 40);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 37);
            this.BuscarButton.TabIndex = 59;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // PrecioerrorProvider
            // 
            this.PrecioerrorProvider.ContainerControl = this;
            // 
            // CantidaderrorProvider
            // 
            this.CantidaderrorProvider.ContainerControl = this;
            // 
            // CostoNumericUpDown
            // 
            this.CostoNumericUpDown.Location = new System.Drawing.Point(95, 196);
            this.CostoNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.CostoNumericUpDown.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.CostoNumericUpDown.Name = "CostoNumericUpDown";
            this.CostoNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.CostoNumericUpDown.TabIndex = 60;
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(95, 238);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.PrecioNumericUpDown.TabIndex = 61;
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // GeneralErrorProvider1
            // 
            this.GeneralErrorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Inventario:";
            // 
            // InventarioNumericUpDown
            // 
            this.InventarioNumericUpDown.Location = new System.Drawing.Point(267, 238);
            this.InventarioNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.InventarioNumericUpDown.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.InventarioNumericUpDown.Name = "InventarioNumericUpDown";
            this.InventarioNumericUpDown.ReadOnly = true;
            this.InventarioNumericUpDown.Size = new System.Drawing.Size(97, 20);
            this.InventarioNumericUpDown.TabIndex = 63;
            // 
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 381);
            this.Controls.Add(this.InventarioNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.CostoNumericUpDown);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ProductoIdNumericUpDown);
            this.Controls.Add(productoIdLabel);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.GananciaNumericUpDown);
            this.Controls.Add(costoLabel);
            this.Controls.Add(precioLabel);
            this.Controls.Add(fechaIngresoLabel);
            this.Controls.Add(this.FechaIngresoDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroProductos";
            this.Text = "Registro De Productos";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GananciaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidaderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ProductoIdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown GananciaNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaIngresoDateTimePicker;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider PrecioerrorProvider;
        private System.Windows.Forms.ErrorProvider CantidaderrorProvider;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.NumericUpDown CostoNumericUpDown;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider1;
        private System.Windows.Forms.NumericUpDown InventarioNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}