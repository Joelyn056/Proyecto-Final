namespace ProyectoFinal.UI
{
    partial class FacturasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FacturaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.ImporteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BuscarFacturaIdButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ITBISNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SuBTotalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITBISNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuBTotalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clientes";
            // 
            // FacturaIdNumericUpDown
            // 
            this.FacturaIdNumericUpDown.Location = new System.Drawing.Point(85, 38);
            this.FacturaIdNumericUpDown.Name = "FacturaIdNumericUpDown";
            this.FacturaIdNumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.FacturaIdNumericUpDown.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoverButton);
            this.groupBox1.Controls.Add(this.ProductoComboBox);
            this.groupBox1.Controls.Add(this.ImporteNumericUpDown);
            this.groupBox1.Controls.Add(this.AgregarButton);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.DetalledataGridView);
            this.groupBox1.Controls.Add(this.CantidadNumericUpDown);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PrecioNumericUpDown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 348);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(848, 18);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(75, 33);
            this.RemoverButton.TabIndex = 19;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // ProductoComboBox
            // 
            this.ProductoComboBox.FormattingEnabled = true;
            this.ProductoComboBox.Location = new System.Drawing.Point(72, 22);
            this.ProductoComboBox.Name = "ProductoComboBox";
            this.ProductoComboBox.Size = new System.Drawing.Size(180, 24);
            this.ProductoComboBox.TabIndex = 20;
            this.ProductoComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductoComboBox_SelectedIndexChanged);
            // 
            // ImporteNumericUpDown
            // 
            this.ImporteNumericUpDown.Enabled = false;
            this.ImporteNumericUpDown.Location = new System.Drawing.Point(657, 22);
            this.ImporteNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ImporteNumericUpDown.Name = "ImporteNumericUpDown";
            this.ImporteNumericUpDown.ReadOnly = true;
            this.ImporteNumericUpDown.Size = new System.Drawing.Size(79, 22);
            this.ImporteNumericUpDown.TabIndex = 18;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = global::ProyectoFinal.Properties.Resources.Add_25px;
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(746, 17);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(89, 34);
            this.AgregarButton.TabIndex = 10;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(605, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Importe";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(9, 67);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(914, 292);
            this.DetalledataGridView.TabIndex = 9;
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(345, 22);
            this.CantidadNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(86, 22);
            this.CantidadNumericUpDown.TabIndex = 8;
            this.CantidadNumericUpDown.ValueChanged += new System.EventHandler(this.CantidadNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(274, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad:";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Enabled = false;
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(494, 22);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.ReadOnly = true;
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(89, 22);
            this.PrecioNumericUpDown.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(451, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Productos";
            // 
            // BuscarFacturaIdButton
            // 
            this.BuscarFacturaIdButton.Image = global::ProyectoFinal.Properties.Resources.Search_25px1;
            this.BuscarFacturaIdButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarFacturaIdButton.Location = new System.Drawing.Point(170, 31);
            this.BuscarFacturaIdButton.Name = "BuscarFacturaIdButton";
            this.BuscarFacturaIdButton.Size = new System.Drawing.Size(81, 34);
            this.BuscarFacturaIdButton.TabIndex = 7;
            this.BuscarFacturaIdButton.Text = "Buscar";
            this.BuscarFacturaIdButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarFacturaIdButton.UseVisualStyleBackColor = true;
            this.BuscarFacturaIdButton.Click += new System.EventHandler(this.BuscarFacturaIdButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::ProyectoFinal.Properties.Resources.new2;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(30, 480);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(81, 60);
            this.NuevoButton.TabIndex = 11;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources.Save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(139, 480);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 60);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources.Delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(247, 480);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(78, 60);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(831, 12);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(104, 20);
            this.FechaDateTimePicker.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalNumericUpDown);
            this.groupBox2.Controls.Add(this.ITBISNumericUpDown);
            this.groupBox2.Controls.Add(this.SuBTotalNumericUpDown);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(415, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 119);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculos";
            // 
            // TotalNumericUpDown
            // 
            this.TotalNumericUpDown.Location = new System.Drawing.Point(165, 78);
            this.TotalNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.TotalNumericUpDown.Name = "TotalNumericUpDown";
            this.TotalNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.TotalNumericUpDown.TabIndex = 5;
            // 
            // ITBISNumericUpDown
            // 
            this.ITBISNumericUpDown.Location = new System.Drawing.Point(304, 30);
            this.ITBISNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ITBISNumericUpDown.Name = "ITBISNumericUpDown";
            this.ITBISNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.ITBISNumericUpDown.TabIndex = 4;
            // 
            // SuBTotalNumericUpDown
            // 
            this.SuBTotalNumericUpDown.Location = new System.Drawing.Point(96, 30);
            this.SuBTotalNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.SuBTotalNumericUpDown.Name = "SuBTotalNumericUpDown";
            this.SuBTotalNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.SuBTotalNumericUpDown.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(229, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "ITBIS 18%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sub-Total";
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(324, 41);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(193, 21);
            this.ClienteComboBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(779, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha";
            // 
            // FacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 585);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuscarFacturaIdButton);
            this.Controls.Add(this.FacturaIdNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturasForm";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITBISNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuBTotalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown FacturaIdNumericUpDown;
        private System.Windows.Forms.Button BuscarFacturaIdButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown TotalNumericUpDown;
        private System.Windows.Forms.NumericUpDown ITBISNumericUpDown;
        private System.Windows.Forms.NumericUpDown SuBTotalNumericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown ImporteNumericUpDown;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.ComboBox ProductoComboBox;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.Label label4;
    }
}