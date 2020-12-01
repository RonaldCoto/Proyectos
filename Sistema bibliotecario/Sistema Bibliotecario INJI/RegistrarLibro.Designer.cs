namespace Sistema_Bibliotecario_INJI
{
    partial class RegistrarLibro
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
            this.btnguardarlibro = new System.Windows.Forms.Button();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudNumeroEjemplares = new System.Windows.Forms.NumericUpDown();
            this.txteditorial = new System.Windows.Forms.TextBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.cmbdistribucion = new System.Windows.Forms.ComboBox();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txtnombrelib = new System.Windows.Forms.TextBox();
            this.txtnomautor = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "INGRESAR NUEVO LIBRO";
            // 
            // btnguardarlibro
            // 
            this.btnguardarlibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnguardarlibro.FlatAppearance.BorderSize = 0;
            this.btnguardarlibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnguardarlibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarlibro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarlibro.ForeColor = System.Drawing.Color.White;
            this.btnguardarlibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardarlibro.Location = new System.Drawing.Point(336, 499);
            this.btnguardarlibro.Name = "btnguardarlibro";
            this.btnguardarlibro.Size = new System.Drawing.Size(178, 41);
            this.btnguardarlibro.TabIndex = 9;
            this.btnguardarlibro.Text = "Guardar";
            this.btnguardarlibro.UseVisualStyleBackColor = false;
            this.btnguardarlibro.Click += new System.EventHandler(this.btnguardarlibro_Click);
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
            this.lblcerrar.TabIndex = 27;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nudNumeroEjemplares
            // 
            this.nudNumeroEjemplares.Location = new System.Drawing.Point(432, 418);
            this.nudNumeroEjemplares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroEjemplares.Name = "nudNumeroEjemplares";
            this.nudNumeroEjemplares.Size = new System.Drawing.Size(120, 20);
            this.nudNumeroEjemplares.TabIndex = 35;
            this.nudNumeroEjemplares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txteditorial
            // 
            this.txteditorial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditorial.Location = new System.Drawing.Point(432, 372);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(179, 23);
            this.txteditorial.TabIndex = 34;
            this.txteditorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txteditorial_KeyPress_1);
            this.txteditorial.Validated += new System.EventHandler(this.txteditorial_Validated_1);
            // 
            // txtpais
            // 
            this.txtpais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpais.Location = new System.Drawing.Point(431, 328);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(179, 23);
            this.txtpais.TabIndex = 33;
            this.txtpais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpais_KeyPress_1);
            this.txtpais.Validated += new System.EventHandler(this.txtpais_Validated_1);
            // 
            // cmbdistribucion
            // 
            this.cmbdistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdistribucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdistribucion.FormattingEnabled = true;
            this.cmbdistribucion.Location = new System.Drawing.Point(432, 282);
            this.cmbdistribucion.Name = "cmbdistribucion";
            this.cmbdistribucion.Size = new System.Drawing.Size(146, 25);
            this.cmbdistribucion.TabIndex = 32;
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(432, 233);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(146, 25);
            this.cmbcategoria.TabIndex = 31;
            // 
            // txtnombrelib
            // 
            this.txtnombrelib.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrelib.Location = new System.Drawing.Point(432, 180);
            this.txtnombrelib.Name = "txtnombrelib";
            this.txtnombrelib.Size = new System.Drawing.Size(229, 23);
            this.txtnombrelib.TabIndex = 30;
            this.txtnombrelib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrelib_KeyPress_1);
            this.txtnombrelib.Validated += new System.EventHandler(this.txtnombrelib_Validated_1);
            // 
            // txtnomautor
            // 
            this.txtnomautor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomautor.Location = new System.Drawing.Point(432, 128);
            this.txtnomautor.Name = "txtnomautor";
            this.txtnomautor.Size = new System.Drawing.Size(230, 23);
            this.txtnomautor.TabIndex = 29;
            this.txtnomautor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomautor_KeyPress_1);
            this.txtnomautor.Validated += new System.EventHandler(this.txtnomautor_Validated);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(432, 76);
            this.txtcodigo.MaxLength = 6;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(179, 23);
            this.txtcodigo.TabIndex = 28;
            this.txtcodigo.Validated += new System.EventHandler(this.txtcodigo_Validated_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(215, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Número de Ejemplares";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Autor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Editorial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre del Libro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "País";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Distribución";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            // 
            // RegistrarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 563);
            this.Controls.Add(this.nudNumeroEjemplares);
            this.Controls.Add(this.txteditorial);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.cmbdistribucion);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.txtnombrelib);
            this.Controls.Add(this.txtnomautor);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.btnguardarlibro);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarLibro";
            this.Text = "RegistrarLibro";
            this.Load += new System.EventHandler(this.RegistrarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardarlibro;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nudNumeroEjemplares;
        private System.Windows.Forms.TextBox txteditorial;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.ComboBox cmbdistribucion;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TextBox txtnombrelib;
        private System.Windows.Forms.TextBox txtnomautor;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}