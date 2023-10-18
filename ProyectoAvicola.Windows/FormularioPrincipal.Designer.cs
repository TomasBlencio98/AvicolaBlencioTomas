namespace ProyectoAvicola.Windows
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            DropDownButtonGranja = new ToolStripDropDownButton();
            listarToolStripMenuItem6 = new ToolStripMenuItem();
            nuevoToolStripMenuItem7 = new ToolStripMenuItem();
            editarToolStripMenuItem7 = new ToolStripMenuItem();
            borrarToolStripMenuItem7 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            DropDownButtonGalpones = new ToolStripDropDownButton();
            listarToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem1 = new ToolStripMenuItem();
            borrarToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            DropDownButtonEmpleados = new ToolStripDropDownButton();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            nuevoToolStripMenuItem2 = new ToolStripMenuItem();
            editarToolStripMenuItem2 = new ToolStripMenuItem();
            borrarToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            DropDownButtonProveedores = new ToolStripDropDownButton();
            listarToolStripMenuItem2 = new ToolStripMenuItem();
            nuevoToolStripMenuItem3 = new ToolStripMenuItem();
            editarToolStripMenuItem3 = new ToolStripMenuItem();
            borrarToolStripMenuItem3 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            DropDownButtonTransacciones = new ToolStripDropDownButton();
            listarToolStripMenuItem3 = new ToolStripMenuItem();
            nuevoToolStripMenuItem4 = new ToolStripMenuItem();
            editarToolStripMenuItem4 = new ToolStripMenuItem();
            borrarToolStripMenuItem4 = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            DropDownButtonAlimento = new ToolStripDropDownButton();
            listadoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            borrarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            DropDownButtonMedicamento = new ToolStripDropDownButton();
            listarToolStripMenuItem4 = new ToolStripMenuItem();
            nuevoToolStripMenuItem5 = new ToolStripMenuItem();
            editarToolStripMenuItem5 = new ToolStripMenuItem();
            borrarToolStripMenuItem5 = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            DropDownButtonLocalidades = new ToolStripDropDownButton();
            listarToolStripMenuItem5 = new ToolStripMenuItem();
            nuevoToolStripMenuItem6 = new ToolStripMenuItem();
            editarToolStripMenuItem6 = new ToolStripMenuItem();
            borrarToolStripMenuItem6 = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            ButtonRefrescar = new ToolStripButton();
            panel1 = new Panel();
            DgvDatos = new DataGridView();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { DropDownButtonGranja, toolStripSeparator1, DropDownButtonGalpones, toolStripSeparator2, DropDownButtonEmpleados, toolStripSeparator3, DropDownButtonProveedores, toolStripSeparator4, DropDownButtonTransacciones, toolStripSeparator5, DropDownButtonAlimento, toolStripSeparator6, DropDownButtonMedicamento, toolStripSeparator7, DropDownButtonLocalidades, toolStripSeparator8, ButtonRefrescar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(881, 40);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // DropDownButtonGranja
            // 
            DropDownButtonGranja.DropDownItems.AddRange(new ToolStripItem[] { listarToolStripMenuItem6, nuevoToolStripMenuItem7, editarToolStripMenuItem7, borrarToolStripMenuItem7 });
            DropDownButtonGranja.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DropDownButtonGranja.Image = (Image)resources.GetObject("DropDownButtonGranja.Image");
            DropDownButtonGranja.ImageScaling = ToolStripItemImageScaling.None;
            DropDownButtonGranja.ImageTransparentColor = Color.Magenta;
            DropDownButtonGranja.Name = "DropDownButtonGranja";
            DropDownButtonGranja.Size = new Size(61, 37);
            DropDownButtonGranja.Text = "Granja";
            DropDownButtonGranja.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // listarToolStripMenuItem6
            // 
            listarToolStripMenuItem6.Name = "listarToolStripMenuItem6";
            listarToolStripMenuItem6.Size = new Size(180, 22);
            listarToolStripMenuItem6.Text = "Listar";
            listarToolStripMenuItem6.Click += listarToolStripMenuItem6_Click;
            // 
            // nuevoToolStripMenuItem7
            // 
            nuevoToolStripMenuItem7.Name = "nuevoToolStripMenuItem7";
            nuevoToolStripMenuItem7.Size = new Size(180, 22);
            nuevoToolStripMenuItem7.Text = "Nuevo";
            nuevoToolStripMenuItem7.Click += nuevoToolStripMenuItem7_Click;
            // 
            // editarToolStripMenuItem7
            // 
            editarToolStripMenuItem7.Name = "editarToolStripMenuItem7";
            editarToolStripMenuItem7.Size = new Size(180, 22);
            editarToolStripMenuItem7.Text = "Editar";
            editarToolStripMenuItem7.Click += editarToolStripMenuItem7_Click;
            // 
            // borrarToolStripMenuItem7
            // 
            borrarToolStripMenuItem7.Name = "borrarToolStripMenuItem7";
            borrarToolStripMenuItem7.Size = new Size(180, 22);
            borrarToolStripMenuItem7.Text = "Borrar";
            borrarToolStripMenuItem7.Click += borrarToolStripMenuItem7_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 40);
            // 
            // DropDownButtonGalpones
            // 
            DropDownButtonGalpones.DropDownItems.AddRange(new ToolStripItem[] { listarToolStripMenuItem, nuevoToolStripMenuItem1, editarToolStripMenuItem1, borrarToolStripMenuItem1 });
            DropDownButtonGalpones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DropDownButtonGalpones.Image = (Image)resources.GetObject("DropDownButtonGalpones.Image");
            DropDownButtonGalpones.ImageScaling = ToolStripItemImageScaling.None;
            DropDownButtonGalpones.ImageTransparentColor = Color.Magenta;
            DropDownButtonGalpones.Name = "DropDownButtonGalpones";
            DropDownButtonGalpones.Size = new Size(78, 37);
            DropDownButtonGalpones.Text = "Galpones";
            DropDownButtonGalpones.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(116, 22);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // nuevoToolStripMenuItem1
            // 
            nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            nuevoToolStripMenuItem1.Size = new Size(116, 22);
            nuevoToolStripMenuItem1.Text = "Nuevo";
            // 
            // editarToolStripMenuItem1
            // 
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            editarToolStripMenuItem1.Size = new Size(116, 22);
            editarToolStripMenuItem1.Text = "Editar";
            // 
            // borrarToolStripMenuItem1
            // 
            borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            borrarToolStripMenuItem1.Size = new Size(116, 22);
            borrarToolStripMenuItem1.Text = "Borrar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 40);
            // 
            // DropDownButtonEmpleados
            // 
            DropDownButtonEmpleados.DropDownItems.AddRange(new ToolStripItem[] { listarToolStripMenuItem1, nuevoToolStripMenuItem2, editarToolStripMenuItem2, borrarToolStripMenuItem2 });
            DropDownButtonEmpleados.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DropDownButtonEmpleados.Image = (Image)resources.GetObject("DropDownButtonEmpleados.Image");
            DropDownButtonEmpleados.ImageScaling = ToolStripItemImageScaling.None;
            DropDownButtonEmpleados.ImageTransparentColor = Color.Magenta;
            DropDownButtonEmpleados.Name = "DropDownButtonEmpleados";
            DropDownButtonEmpleados.Size = new Size(88, 37);
            DropDownButtonEmpleados.Text = "Empleados";
            DropDownButtonEmpleados.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(116, 22);
            listarToolStripMenuItem1.Text = "Listar";
            listarToolStripMenuItem1.Click += listarToolStripMenuItem1_Click;
            // 
            // nuevoToolStripMenuItem2
            // 
            nuevoToolStripMenuItem2.Name = "nuevoToolStripMenuItem2";
            nuevoToolStripMenuItem2.Size = new Size(116, 22);
            nuevoToolStripMenuItem2.Text = "Nuevo";
            nuevoToolStripMenuItem2.Click += nuevoToolStripMenuItem2_Click;
            // 
            // editarToolStripMenuItem2
            // 
            editarToolStripMenuItem2.Name = "editarToolStripMenuItem2";
            editarToolStripMenuItem2.Size = new Size(116, 22);
            editarToolStripMenuItem2.Text = "Editar";
            editarToolStripMenuItem2.Click += editarToolStripMenuItem2_Click;
            // 
            // borrarToolStripMenuItem2
            // 
            borrarToolStripMenuItem2.Name = "borrarToolStripMenuItem2";
            borrarToolStripMenuItem2.Size = new Size(116, 22);
            borrarToolStripMenuItem2.Text = "Borrar";
            borrarToolStripMenuItem2.Click += borrarToolStripMenuItem2_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 40);
            // 
            // DropDownButtonProveedores
            // 
            DropDownButtonProveedores.DropDownItems.AddRange(new ToolStripItem[] { listarToolStripMenuItem2, nuevoToolStripMenuItem3, editarToolStripMenuItem3, borrarToolStripMenuItem3 });
            DropDownButtonProveedores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DropDownButtonProveedores.Image = (Image)resources.GetObject("DropDownButtonProveedores.Image");
            DropDownButtonProveedores.ImageScaling = ToolStripItemImageScaling.None;
            DropDownButtonProveedores.ImageTransparentColor = Color.Magenta;
            DropDownButtonProveedores.Name = "DropDownButtonProveedores";
            DropDownButtonProveedores.Size = new Size(97, 37);
            DropDownButtonProveedores.Text = "Proveedores";
            DropDownButtonProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // listarToolStripMenuItem2
            // 
            listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            listarToolStripMenuItem2.Size = new Size(116, 22);
            listarToolStripMenuItem2.Text = "Listar";
            listarToolStripMenuItem2.Click += listarToolStripMenuItem2_Click;
            // 
            // nuevoToolStripMenuItem3
            // 
            nuevoToolStripMenuItem3.Name = "nuevoToolStripMenuItem3";
            nuevoToolStripMenuItem3.Size = new Size(116, 22);
            nuevoToolStripMenuItem3.Text = "Nuevo";
            nuevoToolStripMenuItem3.Click += nuevoToolStripMenuItem3_Click;
            // 
            // editarToolStripMenuItem3
            // 
            editarToolStripMenuItem3.Name = "editarToolStripMenuItem3";
            editarToolStripMenuItem3.Size = new Size(116, 22);
            editarToolStripMenuItem3.Text = "Editar";
            editarToolStripMenuItem3.Click += editarToolStripMenuItem3_Click;
            // 
            // borrarToolStripMenuItem3
            // 
            borrarToolStripMenuItem3.Name = "borrarToolStripMenuItem3";
            borrarToolStripMenuItem3.Size = new Size(116, 22);
            borrarToolStripMenuItem3.Text = "Borrar";
            borrarToolStripMenuItem3.Click += borrarToolStripMenuItem3_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 40);
            // 
            // DropDownButtonTransacciones
            // 
            DropDownButtonTransacciones.DropDownItems.AddRange(new ToolStripItem[] { listarToolStripMenuItem3, nuevoToolStripMenuItem4, editarToolStripMenuItem4, borrarToolStripMenuItem4 });
            DropDownButtonTransacciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DropDownButtonTransacciones.Image = (Image)resources.GetObject("DropDownButtonTransacciones.Image");
            DropDownButtonTransacciones.ImageTransparentColor = Color.Magenta;
            DropDownButtonTransacciones.Name = "DropDownButtonTransacciones";
            DropDownButtonTransacciones.Size = new Size(106, 37);
            DropDownButtonTransacciones.Text = "Transacciones";
            DropDownButtonTransacciones.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // listarToolStripMenuItem3
            // 
            listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            listarToolStripMenuItem3.Size = new Size(116, 22);
            listarToolStripMenuItem3.Text = "Listar";
            // 
            // nuevoToolStripMenuItem4
            // 
            nuevoToolStripMenuItem4.Name = "nuevoToolStripMenuItem4";
            nuevoToolStripMenuItem4.Size = new Size(116, 22);
            nuevoToolStripMenuItem4.Text = "Nuevo";
            // 
            // editarToolStripMenuItem4
            // 
            editarToolStripMenuItem4.Name = "editarToolStripMenuItem4";
            editarToolStripMenuItem4.Size = new Size(116, 22);
            editarToolStripMenuItem4.Text = "Editar";
            // 
            // borrarToolStripMenuItem4
            // 
            borrarToolStripMenuItem4.Name = "borrarToolStripMenuItem4";
            borrarToolStripMenuItem4.Size = new Size(116, 22);
            borrarToolStripMenuItem4.Text = "Borrar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 40);
            // 
            // DropDownButtonAlimento
            // 
            DropDownButtonAlimento.DropDownItems.AddRange(new ToolStripItem[] { listadoToolStripMenuItem, nuevoToolStripMenuItem, editarToolStripMenuItem, borrarToolStripMenuItem });
            DropDownButtonAlimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DropDownButtonAlimento.Image = (Image)resources.GetObject("DropDownButtonAlimento.Image");
            DropDownButtonAlimento.ImageScaling = ToolStripItemImageScaling.None;
            DropDownButtonAlimento.ImageTransparentColor = Color.Magenta;
            DropDownButtonAlimento.Name = "DropDownButtonAlimento";
            DropDownButtonAlimento.Size = new Size(78, 37);
            DropDownButtonAlimento.Text = "Alimento";
            DropDownButtonAlimento.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // listadoToolStripMenuItem
            // 
            listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            listadoToolStripMenuItem.Size = new Size(121, 22);
            listadoToolStripMenuItem.Text = "Listado";
            listadoToolStripMenuItem.Click += listadoToolStripMenuItem_Click;
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(121, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(121, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(121, 22);
            borrarToolStripMenuItem.Text = "Borrar";
            borrarToolStripMenuItem.Click += borrarToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 40);
            // 
            // DropDownButtonMedicamento
            // 
            DropDownButtonMedicamento.DropDownItems.AddRange(new ToolStripItem[] { listarToolStripMenuItem4, nuevoToolStripMenuItem5, editarToolStripMenuItem5, borrarToolStripMenuItem5 });
            DropDownButtonMedicamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DropDownButtonMedicamento.Image = (Image)resources.GetObject("DropDownButtonMedicamento.Image");
            DropDownButtonMedicamento.ImageTransparentColor = Color.Magenta;
            DropDownButtonMedicamento.Name = "DropDownButtonMedicamento";
            DropDownButtonMedicamento.Size = new Size(105, 37);
            DropDownButtonMedicamento.Text = "Medicamento";
            DropDownButtonMedicamento.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // listarToolStripMenuItem4
            // 
            listarToolStripMenuItem4.Name = "listarToolStripMenuItem4";
            listarToolStripMenuItem4.Size = new Size(116, 22);
            listarToolStripMenuItem4.Text = "Listar";
            listarToolStripMenuItem4.Click += listarToolStripMenuItem4_Click;
            // 
            // nuevoToolStripMenuItem5
            // 
            nuevoToolStripMenuItem5.Name = "nuevoToolStripMenuItem5";
            nuevoToolStripMenuItem5.Size = new Size(116, 22);
            nuevoToolStripMenuItem5.Text = "Nuevo";
            nuevoToolStripMenuItem5.Click += nuevoToolStripMenuItem5_Click;
            // 
            // editarToolStripMenuItem5
            // 
            editarToolStripMenuItem5.Name = "editarToolStripMenuItem5";
            editarToolStripMenuItem5.Size = new Size(116, 22);
            editarToolStripMenuItem5.Text = "Editar";
            editarToolStripMenuItem5.Click += editarToolStripMenuItem5_Click;
            // 
            // borrarToolStripMenuItem5
            // 
            borrarToolStripMenuItem5.Name = "borrarToolStripMenuItem5";
            borrarToolStripMenuItem5.Size = new Size(116, 22);
            borrarToolStripMenuItem5.Text = "Borrar";
            borrarToolStripMenuItem5.Click += borrarToolStripMenuItem5_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 40);
            // 
            // DropDownButtonLocalidades
            // 
            DropDownButtonLocalidades.DropDownItems.AddRange(new ToolStripItem[] { listarToolStripMenuItem5, nuevoToolStripMenuItem6, editarToolStripMenuItem6, borrarToolStripMenuItem6 });
            DropDownButtonLocalidades.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DropDownButtonLocalidades.Image = (Image)resources.GetObject("DropDownButtonLocalidades.Image");
            DropDownButtonLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            DropDownButtonLocalidades.ImageTransparentColor = Color.Magenta;
            DropDownButtonLocalidades.Name = "DropDownButtonLocalidades";
            DropDownButtonLocalidades.Size = new Size(93, 37);
            DropDownButtonLocalidades.Text = "Localidades";
            DropDownButtonLocalidades.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // listarToolStripMenuItem5
            // 
            listarToolStripMenuItem5.Name = "listarToolStripMenuItem5";
            listarToolStripMenuItem5.Size = new Size(116, 22);
            listarToolStripMenuItem5.Text = "Listar";
            listarToolStripMenuItem5.Click += listarToolStripMenuItem5_Click;
            // 
            // nuevoToolStripMenuItem6
            // 
            nuevoToolStripMenuItem6.Name = "nuevoToolStripMenuItem6";
            nuevoToolStripMenuItem6.Size = new Size(116, 22);
            nuevoToolStripMenuItem6.Text = "Nuevo";
            nuevoToolStripMenuItem6.Click += nuevoToolStripMenuItem6_Click;
            // 
            // editarToolStripMenuItem6
            // 
            editarToolStripMenuItem6.Name = "editarToolStripMenuItem6";
            editarToolStripMenuItem6.Size = new Size(116, 22);
            editarToolStripMenuItem6.Text = "Editar";
            editarToolStripMenuItem6.Click += editarToolStripMenuItem6_Click;
            // 
            // borrarToolStripMenuItem6
            // 
            borrarToolStripMenuItem6.Name = "borrarToolStripMenuItem6";
            borrarToolStripMenuItem6.Size = new Size(116, 22);
            borrarToolStripMenuItem6.Text = "Borrar";
            borrarToolStripMenuItem6.Click += borrarToolStripMenuItem6_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 40);
            // 
            // ButtonRefrescar
            // 
            ButtonRefrescar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonRefrescar.Image = (Image)resources.GetObject("ButtonRefrescar.Image");
            ButtonRefrescar.ImageTransparentColor = Color.Magenta;
            ButtonRefrescar.Name = "ButtonRefrescar";
            ButtonRefrescar.Size = new Size(68, 37);
            ButtonRefrescar.Text = "Refrescar";
            ButtonRefrescar.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonRefrescar.Click += ButtonRefrescar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(DgvDatos);
            panel1.Location = new Point(2, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 319);
            panel1.TabIndex = 3;
            // 
            // DgvDatos
            // 
            DgvDatos.AllowUserToAddRows = false;
            DgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Dock = DockStyle.Fill;
            DgvDatos.Location = new Point(0, 0);
            DgvDatos.Name = "DgvDatos";
            DgvDatos.ReadOnly = true;
            DgvDatos.RowTemplate.Height = 25;
            DgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDatos.Size = new Size(879, 319);
            DgvDatos.TabIndex = 0;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 473);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "FormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton DropDownButtonGranja;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton DropDownButtonAlimento;
        private Panel panel1;
        private DataGridView DgvDatos;
        private ToolStripMenuItem listadoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripDropDownButton DropDownButtonGalpones;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem borrarToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton DropDownButtonEmpleados;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem nuevoToolStripMenuItem2;
        private ToolStripMenuItem editarToolStripMenuItem2;
        private ToolStripMenuItem borrarToolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton DropDownButtonProveedores;
        private ToolStripMenuItem listarToolStripMenuItem2;
        private ToolStripMenuItem nuevoToolStripMenuItem3;
        private ToolStripMenuItem editarToolStripMenuItem3;
        private ToolStripMenuItem borrarToolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripDropDownButton DropDownButtonTransacciones;
        private ToolStripMenuItem listarToolStripMenuItem3;
        private ToolStripMenuItem nuevoToolStripMenuItem4;
        private ToolStripMenuItem editarToolStripMenuItem4;
        private ToolStripMenuItem borrarToolStripMenuItem4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripDropDownButton DropDownButtonMedicamento;
        private ToolStripMenuItem listarToolStripMenuItem4;
        private ToolStripMenuItem nuevoToolStripMenuItem5;
        private ToolStripMenuItem editarToolStripMenuItem5;
        private ToolStripMenuItem borrarToolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton ButtonRefrescar;
        private ToolStripDropDownButton DropDownButtonLocalidades;
        private ToolStripMenuItem listarToolStripMenuItem5;
        private ToolStripMenuItem nuevoToolStripMenuItem6;
        private ToolStripMenuItem editarToolStripMenuItem6;
        private ToolStripMenuItem borrarToolStripMenuItem6;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem listarToolStripMenuItem6;
        private ToolStripMenuItem nuevoToolStripMenuItem7;
        private ToolStripMenuItem editarToolStripMenuItem7;
        private ToolStripMenuItem borrarToolStripMenuItem7;
    }
}