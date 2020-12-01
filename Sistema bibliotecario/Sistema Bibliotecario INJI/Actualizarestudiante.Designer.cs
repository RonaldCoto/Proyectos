namespace Sistema_Bibliotecario_INJI
{
    partial class Actualizarestudiante
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
            this.btnactualizaralum = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnieactu = new System.Windows.Forms.TextBox();
            this.txtnomact2 = new System.Windows.Forms.TextBox();
            this.txtnomact1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbgradoactu = new System.Windows.Forms.ComboBox();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtapellactu2 = new System.Windows.Forms.TextBox();
            this.txtapellactu1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblgrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "ACTUALIZAR PERFIL DE ESTUDIANTE";
            // 
            // btnactualizaralum
            // 
            this.btnactualizaralum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnactualizaralum.FlatAppearance.BorderSize = 0;
            this.btnactualizaralum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnactualizaralum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizaralum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizaralum.ForeColor = System.Drawing.Color.White;
            this.btnactualizaralum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizaralum.Location = new System.Drawing.Point(339, 451);
            this.btnactualizaralum.Name = "btnactualizaralum";
            this.btnactualizaralum.Size = new System.Drawing.Size(178, 41);
            this.btnactualizaralum.TabIndex = 7;
            this.btnactualizaralum.Text = "Actualizar";
            this.btnactualizaralum.UseVisualStyleBackColor = false;
            this.btnactualizaralum.Click += new System.EventHandler(this.btnactualizaralum_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre 2";
            // 
            // txtnieactu
            // 
            this.txtnieactu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnieactu.Location = new System.Drawing.Point(362, 395);
            this.txtnieactu.MaxLength = 8;
            this.txtnieactu.Name = "txtnieactu";
            this.txtnieactu.ReadOnly = true;
            this.txtnieactu.Size = new System.Drawing.Size(198, 23);
            this.txtnieactu.TabIndex = 6;
            this.txtnieactu.TextChanged += new System.EventHandler(this.txtnieactu_TextChanged);
            this.txtnieactu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnieactu_KeyPress);
            this.txtnieactu.Validated += new System.EventHandler(this.txtnieactu_Validated);
            // 
            // txtnomact2
            // 
            this.txtnomact2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomact2.Location = new System.Drawing.Point(362, 179);
            this.txtnomact2.Name = "txtnomact2";
            this.txtnomact2.Size = new System.Drawing.Size(216, 23);
            this.txtnomact2.TabIndex = 1;
            this.txtnomact2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellactu_KeyPress);
            this.txtnomact2.Validated += new System.EventHandler(this.txtapellactu_Validated);
            // 
            // txtnomact1
            // 
            this.txtnomact1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomact1.Location = new System.Drawing.Point(362, 125);
            this.txtnomact1.Name = "txtnomact1";
            this.txtnomact1.Size = new System.Drawing.Size(216, 23);
            this.txtnomact1.TabIndex = 0;
            this.txtnomact1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomact_KeyPress);
            this.txtnomact1.Validated += new System.EventHandler(this.txtnomact_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "NIE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Grado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre 1";
            // 
            // cmbgradoactu
            // 
            this.cmbgradoactu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgradoactu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgradoactu.FormattingEnabled = true;
            this.cmbgradoactu.Items.AddRange(new object[] {
            "1er Año",
            "2do Año",
            "3er Año"});
            this.cmbgradoactu.Location = new System.Drawing.Point(362, 333);
            this.cmbgradoactu.Name = "cmbgradoactu";
            this.cmbgradoactu.Size = new System.Drawing.Size(121, 25);
            this.cmbgradoactu.TabIndex = 4;
            // 
            // lblcerrar
            // 
            this.lblcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblcerrar.Location = new System.Drawing.Point(818, 9);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(20, 19);
            this.lblcerrar.TabIndex = 32;
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
            this.label7.Location = new System.Drawing.Point(243, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Apellido 2";
            // 
            // txtapellactu2
            // 
            this.txtapellactu2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellactu2.Location = new System.Drawing.Point(362, 282);
            this.txtapellactu2.Name = "txtapellactu2";
            this.txtapellactu2.Size = new System.Drawing.Size(216, 23);
            this.txtapellactu2.TabIndex = 3;
            this.txtapellactu2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellactu2_KeyPress);
            this.txtapellactu2.Validated += new System.EventHandler(this.txtapellactu2_Validated);
            // 
            // txtapellactu1
            // 
            this.txtapellactu1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellactu1.Location = new System.Drawing.Point(362, 228);
            this.txtapellactu1.Name = "txtapellactu1";
            this.txtapellactu1.Size = new System.Drawing.Size(216, 23);
            this.txtapellactu1.TabIndex = 2;
            this.txtapellactu1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellactu1_KeyPress);
            this.txtapellactu1.Validated += new System.EventHandler(this.txtapellactu1_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Apellido 1";
            // 
            // lblgrado
            // 
            this.lblgrado.AutoSize = true;
            this.lblgrado.Location = new System.Drawing.Point(61, 60);
            this.lblgrado.Name = "lblgrado";
            this.lblgrado.Size = new System.Drawing.Size(36, 13);
            this.lblgrado.TabIndex = 37;
            this.lblgrado.Text = "Grado";
            this.lblgrado.Visible = false;
            this.lblgrado.Click += new System.EventHandler(this.lblgrado_Click);
            // 
            // Actualizarestudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.lblgrado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtapellactu2);
            this.Controls.Add(this.txtapellactu1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.btnactualizaralum);
            this.Controls.Add(this.cmbgradoactu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnieactu);
            this.Controls.Add(this.txtnomact2);
            this.Controls.Add(this.txtnomact1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Actualizarestudiante";
            this.Text = "Actualizarestudiante";
            this.Load += new System.EventHandler(this.Actualizarestudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnactualizaralum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txtnieactu;
        public System.Windows.Forms.TextBox txtnomact2;
        public System.Windows.Forms.TextBox txtnomact1;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox txtapellactu2;
		public System.Windows.Forms.TextBox txtapellactu1;
		private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmbgradoactu;
        public System.Windows.Forms.Label lblgrado;
    }
}