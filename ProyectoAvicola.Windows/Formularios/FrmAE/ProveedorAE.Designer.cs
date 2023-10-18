namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class ProveedorAE
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
            TextBoxNombreProveedor = new TextBox();
            label1 = new Label();
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            TextBoxApellidoProveedor = new TextBox();
            label2 = new Label();
            TextBoxEmail = new TextBox();
            label3 = new Label();
            TextBoxTelefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ComboBoxLocalidades = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxNombreProveedor
            // 
            TextBoxNombreProveedor.Location = new Point(111, 29);
            TextBoxNombreProveedor.Name = "TextBoxNombreProveedor";
            TextBoxNombreProveedor.PlaceholderText = "Ingrese un Nombre";
            TextBoxNombreProveedor.Size = new Size(265, 23);
            TextBoxNombreProveedor.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre: ";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelar.Location = new Point(292, 275);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(84, 48);
            ButtonCancelar.TabIndex = 3;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAceptar.Location = new Point(37, 275);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 48);
            ButtonAceptar.TabIndex = 4;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // TextBoxApellidoProveedor
            // 
            TextBoxApellidoProveedor.Location = new Point(111, 71);
            TextBoxApellidoProveedor.Name = "TextBoxApellidoProveedor";
            TextBoxApellidoProveedor.PlaceholderText = "Ingrese un Apellido";
            TextBoxApellidoProveedor.Size = new Size(265, 23);
            TextBoxApellidoProveedor.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 70);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Apellido: ";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(111, 161);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.PlaceholderText = "Ingrese un Email";
            TextBoxEmail.Size = new Size(265, 23);
            TextBoxEmail.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 160);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 11;
            label3.Text = "Email: ";
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(111, 119);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.PlaceholderText = "Ingrese un Telefono";
            TextBoxTelefono.Size = new Size(265, 23);
            TextBoxTelefono.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 118);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "Telefono: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 216);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 13;
            label5.Text = "Localidad: ";
            // 
            // ComboBoxLocalidades
            // 
            ComboBoxLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxLocalidades.FormattingEnabled = true;
            ComboBoxLocalidades.Location = new Point(111, 216);
            ComboBoxLocalidades.Name = "ComboBoxLocalidades";
            ComboBoxLocalidades.Size = new Size(265, 23);
            ComboBoxLocalidades.TabIndex = 14;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ProveedorAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 357);
            Controls.Add(ComboBoxLocalidades);
            Controls.Add(label5);
            Controls.Add(TextBoxEmail);
            Controls.Add(label3);
            Controls.Add(TextBoxTelefono);
            Controls.Add(label4);
            Controls.Add(TextBoxApellidoProveedor);
            Controls.Add(label2);
            Controls.Add(TextBoxNombreProveedor);
            Controls.Add(label1);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            MaximumSize = new Size(429, 396);
            MinimumSize = new Size(429, 396);
            Name = "ProveedorAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProveedorAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxNombreProveedor;
        private Label label1;
        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private TextBox TextBoxApellidoProveedor;
        private Label label2;
        private TextBox TextBoxEmail;
        private Label label3;
        private TextBox TextBoxTelefono;
        private Label label4;
        private Label label5;
        private ComboBox ComboBoxLocalidades;
        private ErrorProvider errorProvider1;
    }
}