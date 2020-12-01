namespace Sistema_Bibliotecario_INJI
{
    partial class CrearPerfilAlumno
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombrealum1 = new System.Windows.Forms.TextBox();
            this.txtnombrealum2 = new System.Windows.Forms.TextBox();
            this.txtnie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbgrado = new System.Windows.Forms.ComboBox();
            this.btnguardaralumno = new System.Windows.Forms.Button();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "CREAR PERFIL DEL ALUMNO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "NIE";
            // 
            // txtnombrealum1
            // 
            this.txtnombrealum1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrealum1.Location = new System.Drawing.Point(355, 106);
            this.txtnombrealum1.Name = "txtnombrealum1";
            this.txtnombrealum1.Size = new System.Drawing.Size(216, 23);
            this.txtnombrealum1.TabIndex = 0;
            this.txtnombrealum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrealum_KeyPress);
            this.txtnombrealum1.Validated += new System.EventHandler(this.txtnombrealum_Validated);
            // 
            // txtnombrealum2
            // 
            this.txtnombrealum2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrealum2.Location = new System.Drawing.Point(355, 150);
            this.txtnombrealum2.Name = "txtnombrealum2";
            this.txtnombrealum2.Size = new System.Drawing.Size(216, 23);
            this.txtnombrealum2.TabIndex = 1;
            this.txtnombrealum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            this.txtnombrealum2.Validated += new System.EventHandler(this.txtapellido_Validated);
            // 
            // txtnie
            // 
            this.txtnie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnie.Location = new System.Drawing.Point(355, 341);
            this.txtnie.MaxLength = 8;
            this.txtnie.Name = "txtnie";
            this.txtnie.Size = new System.Drawing.Size(198, 23);
            this.txtnie.TabIndex = 5;
            this.txtnie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnie_KeyPress);
            this.txtnie.Validated += new System.EventHandler(this.txtnie_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre 2";
            // 
            // cmbgrado
            // 
            this.cmbgrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgrado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgrado.FormattingEnabled = true;
            this.cmbgrado.Location = new System.Drawing.Point(355, 288);
            this.cmbgrado.Name = "cmbgrado";
            this.cmbgrado.Size = new System.Drawing.Size(124, 25);
            this.cmbgrado.TabIndex = 4;
            this.cmbgrado.SelectedIndexChanged += new System.EventHandler(this.cmbgrado_SelectedIndexChanged);
            // 
            // btnguardaralumno
            // 
            this.btnguardaralumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnguardaralumno.FlatAppearance.BorderSize = 0;
            this.btnguardaralumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnguardaralumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardaralumno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardaralumno.ForeColor = System.Drawing.Color.White;
            this.btnguardaralumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardaralumno.Location = new System.Drawing.Point(338, 433);
            this.btnguardaralumno.Name = "btnguardaralumno";
            this.btnguardaralumno.Size = new System.Drawing.Size(178, 41);
            this.btnguardaralumno.TabIndex = 6;
            this.btnguardaralumno.Text = "Guardar";
            this.btnguardaralumno.UseVisualStyleBackColor = false;
            this.btnguardaralumno.Click += new System.EventHandler(this.btnguardaralumno_Click);
            // 
            // lblcerrar
            // 
            this.lblcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblcerrar.Location = new System.Drawing.Point(818, 9);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(20, 19);
            this.lblcerrar.TabIndex = 21;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(236, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Apellido 2";
            // 
            // txtapellido2
            // 
            this.txtapellido2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido2.Location = new System.Drawing.Point(355, 244);
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(216, 23);
            this.txtapellido2.TabIndex = 3;
            this.txtapellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido2_KeyPress);
            this.txtapellido2.Validated += new System.EventHandler(this.txtapellido2_Validated);
            // 
            // txtapellido1
            // 
            this.txtapellido1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido1.Location = new System.Drawing.Point(355, 196);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(216, 23);
            this.txtapellido1.TabIndex = 2;
            this.txtapellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido1_KeyPress);
            this.txtapellido1.Validated += new System.EventHandler(this.txtapellido1_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Apellido 1";
            // 
            // CrearPerfilAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtapellido2);
            this.Controls.Add(this.txtapellido1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.btnguardaralumno);
            this.Controls.Add(this.cmbgrado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnie);
            this.Controls.Add(this.txtnombrealum2);
            this.Controls.Add(this.txtnombrealum1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearPerfilAlumno";
            this.Text = "CrearPerfilAlumno";
            this.Load += new System.EventHandler(this.CrearPerfilAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombrealum1;
        private System.Windows.Forms.TextBox txtnombrealum2;
        private System.Windows.Forms.TextBox txtnie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbgrado;
        private System.Windows.Forms.Button btnguardaralumno;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtapellido2;
		private System.Windows.Forms.TextBox txtapellido1;
		private System.Windows.Forms.Label label8;
    }
}