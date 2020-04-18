namespace SistemadeRecursosHumanosBancoAgricola
{
    partial class Work
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lblRend = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtEv = new System.Windows.Forms.TextBox();
            this.bAgriDataSet = new SistemadeRecursosHumanosBancoAgricola.BAgriDataSet();
            this.rendimientoEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rendimientoEmpleadosTableAdapter = new SistemadeRecursosHumanosBancoAgricola.BAgriDataSetTableAdapters.RendimientoEmpleadosTableAdapter();
            this.idRendimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAgriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendimientoEmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 164;
            this.label10.Text = "Evaluacion";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Red;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(363, 82);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 31);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(363, 117);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 31);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Red;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(363, 45);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 159;
            this.label1.Text = "Nombre";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(482, 89);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 16);
            this.Label5.TabIndex = 157;
            this.Label5.Text = "Buscar:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 140);
            this.panel1.TabIndex = 154;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "1 PUEDE MEJORAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = " 2 BUENO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "3 MUY BUENO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "4 EXCELENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Evaluación de Empleados";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(15, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(119, 16);
            this.Label3.TabIndex = 153;
            this.Label3.Text = "Selecciona Mes";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRendimientoDataGridViewTextBoxColumn,
            this.codEmpleadoDataGridViewTextBoxColumn,
            this.mesDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.evaluacionDataGridViewTextBoxColumn});
            this.dgvEmployee.DataSource = this.rendimientoEmpleadosBindingSource;
            this.dgvEmployee.Location = new System.Drawing.Point(17, 151);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(777, 177);
            this.dgvEmployee.TabIndex = 151;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(176, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(170, 20);
            this.txtID.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(15, 46);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(155, 16);
            this.Label2.TabIndex = 150;
            this.Label2.Text = "Codigo de Empleado";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.id);
            this.Panel2.Controls.Add(this.lblRend);
            this.Panel2.Location = new System.Drawing.Point(-1, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1052, 39);
            this.Panel2.TabIndex = 148;
            // 
            // lblRend
            // 
            this.lblRend.AutoSize = true;
            this.lblRend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRend.Location = new System.Drawing.Point(286, 4);
            this.lblRend.Name = "lblRend";
            this.lblRend.Size = new System.Drawing.Size(337, 29);
            this.lblRend.TabIndex = 8;
            this.lblRend.Text = "Rendimiento de Empleados";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(548, 89);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(168, 20);
            this.txtbuscar.TabIndex = 165;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(912, 8);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 16);
            this.id.TabIndex = 166;
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(176, 72);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(168, 20);
            this.txtmes.TabIndex = 2;
            // 
            // txtEv
            // 
            this.txtEv.Location = new System.Drawing.Point(176, 124);
            this.txtEv.Name = "txtEv";
            this.txtEv.Size = new System.Drawing.Size(168, 20);
            this.txtEv.TabIndex = 4;
            // 
            // bAgriDataSet
            // 
            this.bAgriDataSet.DataSetName = "BAgriDataSet";
            this.bAgriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rendimientoEmpleadosBindingSource
            // 
            this.rendimientoEmpleadosBindingSource.DataMember = "RendimientoEmpleados";
            this.rendimientoEmpleadosBindingSource.DataSource = this.bAgriDataSet;
            // 
            // rendimientoEmpleadosTableAdapter
            // 
            this.rendimientoEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // idRendimientoDataGridViewTextBoxColumn
            // 
            this.idRendimientoDataGridViewTextBoxColumn.DataPropertyName = "IdRendimiento";
            this.idRendimientoDataGridViewTextBoxColumn.HeaderText = "IdRendimiento";
            this.idRendimientoDataGridViewTextBoxColumn.Name = "idRendimientoDataGridViewTextBoxColumn";
            this.idRendimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRendimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codEmpleadoDataGridViewTextBoxColumn
            // 
            this.codEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Empleado";
            this.codEmpleadoDataGridViewTextBoxColumn.HeaderText = "Codigo Empleado";
            this.codEmpleadoDataGridViewTextBoxColumn.Name = "codEmpleadoDataGridViewTextBoxColumn";
            this.codEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            this.mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            this.mesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evaluacionDataGridViewTextBoxColumn
            // 
            this.evaluacionDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.HeaderText = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.Name = "evaluacionDataGridViewTextBoxColumn";
            this.evaluacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Red;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(732, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 31);
            this.btnBuscar.TabIndex = 166;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(962, 481);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEv);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Work";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Work_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAgriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendimientoEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DataGridView dgvEmployee;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label lblRend;
        internal System.Windows.Forms.TextBox txtbuscar;
        internal System.Windows.Forms.Label id;
        internal System.Windows.Forms.TextBox txtmes;
        internal System.Windows.Forms.TextBox txtEv;
        private BAgriDataSet bAgriDataSet;
        private System.Windows.Forms.BindingSource rendimientoEmpleadosBindingSource;
        private BAgriDataSetTableAdapters.RendimientoEmpleadosTableAdapter rendimientoEmpleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRendimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluacionDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button btnBuscar;
    }
}