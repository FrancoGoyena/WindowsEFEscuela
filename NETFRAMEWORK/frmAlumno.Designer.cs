namespace NETFRAMEWORK
{
    partial class frmAlumno
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
            this.gridalumno = new System.Windows.Forms.DataGridView();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lbapellido = new System.Windows.Forms.Label();
            this.txtfdn = new System.Windows.Forms.TextBox();
            this.lbfdn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridalumno)).BeginInit();
            this.SuspendLayout();
            // 
            // gridalumno
            // 
            this.gridalumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridalumno.Location = new System.Drawing.Point(131, 45);
            this.gridalumno.Name = "gridalumno";
            this.gridalumno.Size = new System.Drawing.Size(528, 192);
            this.gridalumno.TabIndex = 17;
            this.gridalumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridalumno_CellContentClick);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(491, 387);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(124, 23);
            this.buttonbuscar.TabIndex = 16;
            this.buttonbuscar.Text = "Buscar por ID";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(491, 352);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(75, 23);
            this.buttoneliminar.TabIndex = 15;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.Location = new System.Drawing.Point(491, 315);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(75, 23);
            this.buttonmodificar.TabIndex = 14;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.UseVisualStyleBackColor = true;
            this.buttonmodificar.Click += new System.EventHandler(this.buttonmodificar_Click);
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(491, 278);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(75, 23);
            this.buttoninsertar.TabIndex = 13;
            this.buttoninsertar.Text = "Insertar";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(331, 315);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 12;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(331, 278);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 11;
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(262, 315);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(44, 13);
            this.lbnombre.TabIndex = 10;
            this.lbnombre.Text = "Nombre";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(290, 278);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(16, 13);
            this.lbid.TabIndex = 9;
            this.lbid.Text = "Id";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(331, 352);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 19;
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Location = new System.Drawing.Point(262, 352);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(44, 13);
            this.lbapellido.TabIndex = 18;
            this.lbapellido.Text = "Apellido";
            // 
            // txtfdn
            // 
            this.txtfdn.Location = new System.Drawing.Point(331, 387);
            this.txtfdn.Name = "txtfdn";
            this.txtfdn.Size = new System.Drawing.Size(100, 20);
            this.txtfdn.TabIndex = 21;
            // 
            // lbfdn
            // 
            this.lbfdn.AutoSize = true;
            this.lbfdn.Location = new System.Drawing.Point(200, 387);
            this.lbfdn.Name = "lbfdn";
            this.lbfdn.Size = new System.Drawing.Size(106, 13);
            this.lbfdn.TabIndex = 20;
            this.lbfdn.Text = "Fecha de nacimiento";
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtfdn);
            this.Controls.Add(this.lbfdn);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.lbapellido);
            this.Controls.Add(this.gridalumno);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonmodificar);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbid);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridalumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridalumno;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonmodificar;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lbapellido;
        private System.Windows.Forms.TextBox txtfdn;
        private System.Windows.Forms.Label lbfdn;
    }
}