namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class GranjasAE
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
            TextBoxDireGranja = new TextBox();
            label3 = new Label();
            TextBoxNameGranja = new TextBox();
            label4 = new Label();
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ComboBoxLocalidades
            // 
            ComboBoxLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxLocalidades.FormattingEnabled = true;
            ComboBoxLocalidades.Location = new Point(100, 134);
            ComboBoxLocalidades.Name = "ComboBoxLocalidades";
            ComboBoxLocalidades.Size = new Size(265, 23);
            ComboBoxLocalidades.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 134);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 33;
            label5.Text = "Localidad: ";
            // 
            // TextBoxDireGranja
            // 
            TextBoxDireGranja.Location = new Point(100, 79);
            TextBoxDireGranja.Name = "TextBoxDireGranja";
            TextBoxDireGranja.PlaceholderText = "Ingrese una direccion";
            TextBoxDireGranja.Size = new Size(265, 23);
            TextBoxDireGranja.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 78);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 31;
            label3.Text = "Direccion: ";
            // 
            // TextBoxNameGranja
            // 
            TextBoxNameGranja.Location = new Point(100, 37);
            TextBoxNameGranja.Name = "TextBoxNameGranja";
            TextBoxNameGranja.PlaceholderText = "Ingrese nombre de la granja";
            TextBoxNameGranja.Size = new Size(265, 23);
            TextBoxNameGranja.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 36);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 29;
            label4.Text = "Granja: ";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelar.Location = new Point(281, 170);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(84, 48);
            ButtonCancelar.TabIndex = 27;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAceptar.Location = new Point(26, 170);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 48);
            ButtonAceptar.TabIndex = 28;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // GranjasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 267);
            Controls.Add(ComboBoxLocalidades);
            Controls.Add(label5);
            Controls.Add(TextBoxDireGranja);
            Controls.Add(label3);
            Controls.Add(TextBoxNameGranja);
            Controls.Add(label4);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            MaximumSize = new Size(431, 306);
            MinimumSize = new Size(431, 306);
            Name = "GranjasAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GranjasAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxLocalidades;
        private Label label5;
        private TextBox TextBoxDireGranja;
        private Label label3;
        private TextBox TextBoxNameGranja;
        private Label label4;
        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private ErrorProvider errorProvider1;
    }
}