namespace ProyectoFinal.UI.Registros
{
    partial class RegistroClientes
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
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label fechaInscripcionLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label numeroCelularLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroClientes));
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClienteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.NumeroCelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            clienteIdLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            fechaInscripcionLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            numeroCelularLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteIdLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            clienteIdLabel.Location = new System.Drawing.Point(38, 51);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(66, 16);
            clienteIdLabel.TabIndex = 57;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombresLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            nombresLabel.Location = new System.Drawing.Point(38, 79);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(67, 16);
            nombresLabel.TabIndex = 58;
            nombresLabel.Text = "Nombres:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            sexoLabel.Location = new System.Drawing.Point(38, 110);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(42, 16);
            sexoLabel.TabIndex = 59;
            sexoLabel.Text = "Sexo:";
            // 
            // fechaInscripcionLabel
            // 
            fechaInscripcionLabel.AutoSize = true;
            fechaInscripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaInscripcionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            fechaInscripcionLabel.Location = new System.Drawing.Point(37, 178);
            fechaInscripcionLabel.Name = "fechaInscripcionLabel";
            fechaInscripcionLabel.Size = new System.Drawing.Size(49, 16);
            fechaInscripcionLabel.TabIndex = 60;
            fechaInscripcionLabel.Text = "Fecha:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            direccionLabel.Location = new System.Drawing.Point(37, 211);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(68, 16);
            direccionLabel.TabIndex = 61;
            direccionLabel.Text = "Direccion:";
            // 
            // numeroCelularLabel
            // 
            numeroCelularLabel.AutoSize = true;
            numeroCelularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroCelularLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            numeroCelularLabel.Location = new System.Drawing.Point(34, 245);
            numeroCelularLabel.Name = "numeroCelularLabel";
            numeroCelularLabel.Size = new System.Drawing.Size(104, 16);
            numeroCelularLabel.TabIndex = 62;
            numeroCelularLabel.Text = "Numero Celular:";
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(138, 142);
            this.CedulaMaskedTextBox.Mask = "000-0000000-0";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.CedulaMaskedTextBox.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Cedula:";
            // 
            // ClienteIdNumericUpDown
            // 
            this.ClienteIdNumericUpDown.Location = new System.Drawing.Point(139, 44);
            this.ClienteIdNumericUpDown.Name = "ClienteIdNumericUpDown";
            this.ClienteIdNumericUpDown.Size = new System.Drawing.Size(119, 20);
            this.ClienteIdNumericUpDown.TabIndex = 64;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(139, 76);
            this.NombresTextBox.MaxLength = 80;
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.NombresTextBox.TabIndex = 51;
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.SexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Femenino"});
            this.SexoComboBox.Location = new System.Drawing.Point(139, 107);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(200, 21);
            this.SexoComboBox.TabIndex = 52;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(138, 176);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaDateTimePicker.TabIndex = 53;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(138, 208);
            this.DireccionTextBox.MaxLength = 255;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.DireccionTextBox.TabIndex = 54;
            this.DireccionTextBox.TextChanged += new System.EventHandler(this.DireccionTextBox_TextChanged);
            // 
            // NumeroCelularMaskedTextBox
            // 
            this.NumeroCelularMaskedTextBox.Location = new System.Drawing.Point(139, 242);
            this.NumeroCelularMaskedTextBox.Mask = "000-000-0000";
            this.NumeroCelularMaskedTextBox.Name = "NumeroCelularMaskedTextBox";
            this.NumeroCelularMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.NumeroCelularMaskedTextBox.TabIndex = 55;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ProyectoFinal.Properties.Resources.find;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(280, 27);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(92, 40);
            this.BuscarButton.TabIndex = 70;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources.Delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(280, 300);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(88, 59);
            this.EliminarButton.TabIndex = 69;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources.Save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(157, 300);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(81, 59);
            this.GuardarButton.TabIndex = 68;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::ProyectoFinal.Properties.Resources.new2;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(37, 300);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(87, 59);
            this.NuevoButton.TabIndex = 67;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 385);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClienteIdNumericUpDown);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(fechaInscripcionLabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(numeroCelularLabel);
            this.Controls.Add(this.NumeroCelularMaskedTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroClientes";
            this.Text = "Registro  De Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ClienteIdNumericUpDown;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.ComboBox SexoComboBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.MaskedTextBox NumeroCelularMaskedTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
    }
}