namespace SistemadeRecursosHumanosBancoAgricola
{
    partial class Departamento
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvDeptt = new System.Windows.Forms.DataGridView();
            this.idDepTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAgriDataSet = new SistemadeRecursosHumanosBancoAgricola.BAgriDataSet();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEncar = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.depTrabajoTableAdapter = new SistemadeRecursosHumanosBancoAgricola.BAgriDataSetTableAdapters.DepTrabajoTableAdapter();
            this.buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAgriDataSet)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(169, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 20);
            this.txtID.TabIndex = 94;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(25, 61);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(142, 16);
            this.Label5.TabIndex = 112;
            this.Label5.Text = "Cód. Departamento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(380, 162);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 31);
            this.btnBuscar.TabIndex = 104;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Green;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(380, 88);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 31);
            this.btnEditar.TabIndex = 100;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvDeptt
            // 
            this.dgvDeptt.AllowUserToAddRows = false;
            this.dgvDeptt.AllowUserToDeleteRows = false;
            this.dgvDeptt.AutoGenerateColumns = false;
            this.dgvDeptt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDeptt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepTrabajoDataGridViewTextBoxColumn,
            this.coddepartamentoDataGridViewTextBoxColumn,
            this.departamentoDataGridViewTextBoxColumn,
            this.encargadoDataGridViewTextBoxColumn});
            this.dgvDeptt.DataSource = this.depTrabajoBindingSource;
            this.dgvDeptt.Location = new System.Drawing.Point(28, 220);
            this.dgvDeptt.MultiSelect = false;
            this.dgvDeptt.Name = "dgvDeptt";
            this.dgvDeptt.ReadOnly = true;
            this.dgvDeptt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeptt.Size = new System.Drawing.Size(443, 150);
            this.dgvDeptt.TabIndex = 105;
            // 
            // idDepTrabajoDataGridViewTextBoxColumn
            // 
            this.idDepTrabajoDataGridViewTextBoxColumn.DataPropertyName = "IdDepTrabajo";
            this.idDepTrabajoDataGridViewTextBoxColumn.HeaderText = "IdDepTrabajo";
            this.idDepTrabajoDataGridViewTextBoxColumn.Name = "idDepTrabajoDataGridViewTextBoxColumn";
            this.idDepTrabajoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDepTrabajoDataGridViewTextBoxColumn.Visible = false;
            // 
            // coddepartamentoDataGridViewTextBoxColumn
            // 
            this.coddepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Cod_departamento";
            this.coddepartamentoDataGridViewTextBoxColumn.HeaderText = "Codigo Departamento";
            this.coddepartamentoDataGridViewTextBoxColumn.Name = "coddepartamentoDataGridViewTextBoxColumn";
            this.coddepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            this.departamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // encargadoDataGridViewTextBoxColumn
            // 
            this.encargadoDataGridViewTextBoxColumn.DataPropertyName = "Encargado";
            this.encargadoDataGridViewTextBoxColumn.HeaderText = "Encargado";
            this.encargadoDataGridViewTextBoxColumn.Name = "encargadoDataGridViewTextBoxColumn";
            this.encargadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depTrabajoBindingSource
            // 
            this.depTrabajoBindingSource.DataMember = "DepTrabajo";
            this.depTrabajoBindingSource.DataSource = this.bAgriDataSet;
            // 
            // bAgriDataSet
            // 
            this.bAgriDataSet.DataSetName = "BAgriDataSet";
            this.bAgriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Green;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(380, 125);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 31);
            this.btnEliminar.TabIndex = 101;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDep
            // 
            this.txtDep.ForeColor = System.Drawing.Color.Black;
            this.txtDep.Location = new System.Drawing.Point(169, 86);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(154, 20);
            this.txtDep.TabIndex = 95;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(380, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 99;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEncar
            // 
            this.txtEncar.ForeColor = System.Drawing.Color.Black;
            this.txtEncar.Location = new System.Drawing.Point(169, 112);
            this.txtEncar.Name = "txtEncar";
            this.txtEncar.Size = new System.Drawing.Size(154, 20);
            this.txtEncar.TabIndex = 97;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(29, 87);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(106, 16);
            this.Label3.TabIndex = 108;
            this.Label3.Text = "Departamento";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(29, 112);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(84, 16);
            this.Label4.TabIndex = 109;
            this.Label4.Text = "Encargado";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Lime;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.id);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(650, 39);
            this.Panel2.TabIndex = 106;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(449, 14);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 16);
            this.id.TabIndex = 114;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label1.Location = new System.Drawing.Point(128, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(215, 29);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Áreas de Trabajo";
            // 
            // depTrabajoTableAdapter
            // 
            this.depTrabajoTableAdapter.ClearBeforeFill = true;
            // 
            // buscar
            // 
            this.buscar.ForeColor = System.Drawing.Color.Black;
            this.buscar.Location = new System.Drawing.Point(169, 168);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(154, 20);
            this.buscar.TabIndex = 113;
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(494, 390);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvDeptt);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEncar);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Departamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área de Trabajo";
            this.Load += new System.EventHandler(this.Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAgriDataSet)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.DataGridView dgvDeptt;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.TextBox txtDep;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.TextBox txtEncar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        private BAgriDataSet bAgriDataSet;
        private System.Windows.Forms.BindingSource depTrabajoBindingSource;
        private BAgriDataSetTableAdapters.DepTrabajoTableAdapter depTrabajoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargadoDataGridViewTextBoxColumn;
        internal System.Windows.Forms.TextBox buscar;
        internal System.Windows.Forms.Label id;
    }
}