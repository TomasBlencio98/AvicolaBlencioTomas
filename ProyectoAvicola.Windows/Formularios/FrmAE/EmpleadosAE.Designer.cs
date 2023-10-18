namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class EmpleadosAE
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
            components = new System.ComponentModel.Container();
            ComboBoxLocalidades = new ComboBox();
            label5 = new Label();
            TextBoxTelefono = new TextBox();
            label4 = new Label();
            TextBoxApellido = new TextBox();
            label2 = new Label();
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            ComboBoxGranjas = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            TexBoxsNombre = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ComboBoxLocalidades
            // 
            ComboBoxLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxLocalidades.FormattingEnabled = true;
            ComboBoxLocalidades.Location = new Point(105, 161);
            ComboBoxLocalidades.Name = "ComboBoxLocalidades";
            ComboBoxLocalidades.Size = new Size(265, 23);
            ComboBoxLocalidades.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 144);
            label5.Name = "label5";
            label5.Size = new Size(82, 40);
            label5.TabIndex = 23;
            label5.Text = "Localidad\r\nEmpleado ";
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(105, 110);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.PlaceholderText = "Ingrese un Telefono";
            TextBoxTelefono.Size = new Size(265, 23);
            TextBoxTelefono.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 109);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 19;
            label4.Text = "Telefono: ";
            // 
            // TextBoxApellido
            // 
            TextBoxApellido.Location = new Point(105, 62);
            TextBoxApellido.Name = "TextBoxApellido";
            TextBoxApellido.PlaceholderText = "Ingrese un Apellido";
            TextBoxApellido.Size = new Size(265, 23);
            TextBoxApellido.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 61);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 17;
            label2.Text = "Apellido: ";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelar.Location = new Point(285, 251);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(84, 48);
            ButtonCancelar.TabIndex = 15;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAceptar.Location = new Point(30, 251);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 48);
            ButtonAceptar.TabIndex = 16;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // ComboBoxGranjas
            // 
            ComboBoxGranjas.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxGranjas.FormattingEnabled = true;
            ComboBoxGranjas.Location = new Point(105, 207);
            ComboBoxGranjas.Name = "ComboBoxGranjas";
            ComboBoxGranjas.Size = new Size(265, 23);
            ComboBoxGranjas.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 190);
            label1.Name = "label1";
            label1.Size = new Size(64, 40);
            label1.TabIndex = 25;
            label1.Text = "Granja\r\nTrabaja:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 21);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 17;
            label6.Text = "Nombre: ";
            // 
            // TexBoxsNombre
            // 
            TexBoxsNombre.Location = new Point(105, 22);
            TexBoxsNombre.Name = "TexBoxsNombre";
            TexBoxsNombre.PlaceholderText = "Ingrese un Nombre";
            TexBoxsNombre.Size = new Size(265, 23);
            TexBoxsNombre.TabIndex = 18;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // EmpleadosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 316);
            Controls.Add(ComboBoxGranjas);
            Controls.Add(label1);
            Controls.Add(ComboBoxLocalidades);
            Controls.Add(label5);
            Controls.Add(TextBoxTelefono);
            Controls.Add(label4);
            Controls.Add(TexBoxsNombre);
            Controls.Add(TextBoxApellido);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Name = "EmpleadosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmpleadosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxLocalidades;
        private Label label5;
        private TextBox TextBoxTelefono;
        private Label label4;
        private TextBox TextBoxApellido;
        private Label label2;
        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private ComboBox ComboBoxGranjas;
        private Label label1;
        private Label label6;
        private TextBox TexBoxsNombre;
        private ErrorProvider errorProvider1;
    }
}