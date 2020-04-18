namespace SistemadeRecursosHumanosBancoAgricola
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnArea = new System.Windows.Forms.PictureBox();
            this.btnEmpleado = new System.Windows.Forms.PictureBox();
            this.btnRendimiento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRendimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.Transparent;
            this.btnArea.Image = ((System.Drawing.Image)(resources.GetObject("btnArea.Image")));
            this.btnArea.Location = new System.Drawing.Point(8, 156);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(190, 91);
            this.btnArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnArea.TabIndex = 1;
            this.btnArea.TabStop = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.Location = new System.Drawing.Point(230, 156);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(190, 91);
            this.btnEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEmpleado.TabIndex = 2;
            this.btnEmpleado.TabStop = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnRendimiento
            // 
            this.btnRendimiento.BackColor = System.Drawing.Color.Transparent;
            this.btnRendimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnRendimiento.Image")));
            this.btnRendimiento.Location = new System.Drawing.Point(114, 253);
            this.btnRendimiento.Name = "btnRendimiento";
            this.btnRendimiento.Size = new System.Drawing.Size(190, 91);
            this.btnRendimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRendimiento.TabIndex = 3;
            this.btnRendimiento.TabStop = false;
            this.btnRendimiento.Click += new System.EventHandler(this.btnRendimiento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 456);
            this.Controls.Add(this.btnRendimiento);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Humanos Banco Agricola";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRendimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnArea;
        private System.Windows.Forms.PictureBox btnEmpleado;
        private System.Windows.Forms.PictureBox btnRendimiento;
    }
}

