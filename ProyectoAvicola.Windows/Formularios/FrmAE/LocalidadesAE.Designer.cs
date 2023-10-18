namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class LocalidadesAE
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
            TextBoxLocalidad = new TextBox();
            label1 = new Label();
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            TexBoxCodigoPostal = new TextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxLocalidad
            // 
            TextBoxLocalidad.Location = new Point(114, 28);
            TextBoxLocalidad.Name = "TextBoxLocalidad";
            TextBoxLocalidad.PlaceholderText = "Ingrese Localidad";
            TextBoxLocalidad.Size = new Size(210, 23);
            TextBoxLocalidad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 5;
            label1.Text = "Localidad: ";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelar.Location = new Point(240, 125);
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
            ButtonAceptar.Location = new Point(25, 125);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 48);
            ButtonAceptar.TabIndex = 4;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // TexBoxCodigoPostal
            // 
            TexBoxCodigoPostal.Location = new Point(136, 76);
            TexBoxCodigoPostal.Name = "TexBoxCodigoPostal";
            TexBoxCodigoPostal.PlaceholderText = "Ingrese Codigo Postal";
            TexBoxCodigoPostal.Size = new Size(188, 23);
            TexBoxCodigoPostal.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 75);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 7;
            label2.Text = "Codigo Postal: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LocalidadesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 210);
            Controls.Add(TexBoxCodigoPostal);
            Controls.Add(label2);
            Controls.Add(TextBoxLocalidad);
            Controls.Add(label1);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            MaximumSize = new Size(388, 249);
            MinimumSize = new Size(388, 249);
            Name = "LocalidadesAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LocalidadesAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxLocalidad;
        private Label label1;
        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private TextBox TexBoxCodigoPostal;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}