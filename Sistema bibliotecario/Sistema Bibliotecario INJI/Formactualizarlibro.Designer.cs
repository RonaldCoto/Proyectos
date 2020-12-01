namespace Sistema_Bibliotecario_INJI
{
    partial class Formactualizarlibro
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
            this.lblcerrar = new System.Windows.Forms.Label();
            this.btnactualizarlibro = new System.Windows.Forms.Button();
            this.txteditorialact = new System.Windows.Forms.TextBox();
            this.txtpaisact = new System.Windows.Forms.TextBox();
            this.cmbdistribucion = new System.Windows.Forms.ComboBox();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txtnombrelibact = new System.Windows.Forms.TextBox();
            this.txtautoract = new System.Windows.Forms.TextBox();
            this.txtcodigoact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nmpNumeroEjemplares = new System.Windows.Forms.NumericUpDown();
            this.lblAutorViejo = new System.Windows.Forms.Label();
            this.lbldistribución = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmpNumeroEjemplares)).BeginInit();
            this.SuspendLayout();
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
            this.lblcerrar.TabIndex = 44;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // btnactualizarlibro
            // 
            this.btnactualizarlibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnactualizarlibro.FlatAppearance.BorderSize = 0;
            this.btnactualizarlibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnactualizarlibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizarlibro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarlibro.ForeColor = System.Drawing.Color.White;
            this.btnactualizarlibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizarlibro.Location = new System.Drawing.Point(333, 523);
            this.btnactualizarlibro.Name = "btnactualizarlibro";
            this.btnactualizarlibro.Size = new System.Drawing.Size(178, 41);
            this.btnactualizarlibro.TabIndex = 8;
            this.btnactualizarlibro.Text = "Actualizar";
            this.btnactualizarlibro.UseVisualStyleBackColor = false;
            this.btnactualizarlibro.Click += new System.EventHandler(this.btnactualizarlibro_Click);
            // 
            // txteditorialact
            // 
            this.txteditorialact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditorialact.Location = new System.Drawing.Point(429, 410);
            this.txteditorialact.Name = "txteditorialact";
            this.txteditorialact.Size = new System.Drawing.Size(179, 23);
            this.txteditorialact.TabIndex = 6;
            this.txteditorialact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txteditorialact_KeyPress);
            this.txteditorialact.Validated += new System.EventHandler(this.txteditorialact_Validated);
            // 
            // txtpaisact
            // 
            this.txtpaisact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaisact.Location = new System.Drawing.Point(429, 363);
            this.txtpaisact.Name = "txtpaisact";
            this.txtpaisact.Size = new System.Drawing.Size(179, 23);
            this.txtpaisact.TabIndex = 5;
            this.txtpaisact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpaisact_KeyPress);
            this.txtpaisact.Validated += new System.EventHandler(this.txtpaisact_Validated);
            // 
            // cmbdistribucion
            // 
            this.cmbdistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdistribucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdistribucion.FormattingEnabled = true;
            this.cmbdistribucion.Items.AddRange(new object[] {
            "dist 1"});
            this.cmbdistribucion.Location = new System.Drawing.Point(429, 310);
            this.cmbdistribucion.Name = "cmbdistribucion";
            this.cmbdistribucion.Size = new System.Drawing.Size(179, 25);
            this.cmbdistribucion.TabIndex = 4;
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(429, 257);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(179, 25);
            this.cmbcategoria.TabIndex = 3;
            // 
            // txtnombrelibact
            // 
            this.txtnombrelibact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrelibact.Location = new System.Drawing.Point(429, 202);
            this.txtnombrelibact.Name = "txtnombrelibact";
            this.txtnombrelibact.Size = new System.Drawing.Size(179, 23);
            this.txtnombrelibact.TabIndex = 2;
            this.txtnombrelibact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrelibact_KeyPress);
            this.txtnombrelibact.Validated += new System.EventHandler(this.txtnombrelibact_Validated);
            // 
            // txtautoract
            // 
            this.txtautoract.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautoract.Location = new System.Drawing.Point(429, 147);
            this.txtautoract.Name = "txtautoract";
            this.txtautoract.Size = new System.Drawing.Size(179, 23);
            this.txtautoract.TabIndex = 1;
            this.txtautoract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtautoract_KeyPress);
            this.txtautoract.Validated += new System.EventHandler(this.txtautoract_Validated);
            // 
            // txtcodigoact
            // 
            this.txtcodigoact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoact.Location = new System.Drawing.Point(429, 86);
            this.txtcodigoact.MaxLength = 6;
            this.txtcodigoact.Name = "txtcodigoact";
            this.txtcodigoact.ReadOnly = true;
            this.txtcodigoact.Size = new System.Drawing.Size(179, 23);
            this.txtcodigoact.TabIndex = 0;
            this.txtcodigoact.Validated += new System.EventHandler(this.txtcodigoact_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(212, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Número de Ejemplares";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Autor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(212, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Editorial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Nombre del Libro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "País";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Distribución";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "ACTUALIZAR LIBRO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nmpNumeroEjemplares
            // 
            this.nmpNumeroEjemplares.Location = new System.Drawing.Point(429, 471);
            this.nmpNumeroEjemplares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmpNumeroEjemplares.Name = "nmpNumeroEjemplares";
            this.nmpNumeroEjemplares.Size = new System.Drawing.Size(120, 20);
            this.nmpNumeroEjemplares.TabIndex = 7;
            this.nmpNumeroEjemplares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAutorViejo
            // 
            this.lblAutorViejo.AutoSize = true;
            this.lblAutorViejo.Location = new System.Drawing.Point(78, 86);
            this.lblAutorViejo.Name = "lblAutorViejo";
            this.lblAutorViejo.Size = new System.Drawing.Size(32, 13);
            this.lblAutorViejo.TabIndex = 54;
            this.lblAutorViejo.Text = "Autor";
            this.lblAutorViejo.Visible = false;
            // 
            // lbldistribución
            // 
            this.lbldistribución.AutoSize = true;
            this.lbldistribución.Location = new System.Drawing.Point(78, 147);
            this.lbldistribución.Name = "lbldistribución";
            this.lbldistribución.Size = new System.Drawing.Size(62, 13);
            this.lbldistribución.TabIndex = 55;
            this.lbldistribución.Text = "Distribución";
            this.lbldistribución.Visible = false;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(78, 122);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(52, 13);
            this.lblcategoria.TabIndex = 56;
            this.lblcategoria.Text = "Categoria";
            this.lblcategoria.Visible = false;
            // 
            // Formactualizarlibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lbldistribución);
            this.Controls.Add(this.lblAutorViejo);
            this.Controls.Add(this.nmpNumeroEjemplares);
            this.Controls.Add(this.btnactualizarlibro);
            this.Controls.Add(this.txteditorialact);
            this.Controls.Add(this.txtpaisact);
            this.Controls.Add(this.cmbdistribucion);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.txtnombrelibact);
            this.Controls.Add(this.txtautoract);
            this.Controls.Add(this.txtcodigoact);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 50);
            this.Name = "Formactualizarlibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formactualizarlibro";
            this.Load += new System.EventHandler(this.Formactualizarlibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmpNumeroEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Button btnactualizarlibro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txteditorialact;
        public System.Windows.Forms.TextBox txtpaisact;
        public System.Windows.Forms.ComboBox cmbdistribucion;
        public System.Windows.Forms.ComboBox cmbcategoria;
        public System.Windows.Forms.TextBox txtnombrelibact;
        public System.Windows.Forms.TextBox txtautoract;
        public System.Windows.Forms.TextBox txtcodigoact;
        public System.Windows.Forms.NumericUpDown nmpNumeroEjemplares;
        public System.Windows.Forms.Label lblAutorViejo;
        public System.Windows.Forms.Label lblcategoria;
        public System.Windows.Forms.Label lbldistribución;
    }
}