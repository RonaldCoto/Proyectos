namespace Sistema_Bibliotecario_INJI
{
    partial class categoria
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
            this.txtcodcateg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdesccat = new System.Windows.Forms.TextBox();
            this.btncategoria = new System.Windows.Forms.Button();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "CREAR CATEGORÍA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nombre";
            // 
            // txtcodcateg
            // 
            this.txtcodcateg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodcateg.Location = new System.Drawing.Point(319, 125);
            this.txtcodcateg.Name = "txtcodcateg";
            this.txtcodcateg.Size = new System.Drawing.Size(179, 23);
            this.txtcodcateg.TabIndex = 0;
            this.txtcodcateg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodcateg_KeyPress);
            this.txtcodcateg.Validated += new System.EventHandler(this.txtcodcateg_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Descripción";
            // 
            // txtdesccat
            // 
            this.txtdesccat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesccat.Location = new System.Drawing.Point(319, 190);
            this.txtdesccat.Multiline = true;
            this.txtdesccat.Name = "txtdesccat";
            this.txtdesccat.Size = new System.Drawing.Size(364, 132);
            this.txtdesccat.TabIndex = 1;
            this.txtdesccat.Validated += new System.EventHandler(this.txtdesccat_Validated);
            // 
            // btncategoria
            // 
            this.btncategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btncategoria.FlatAppearance.BorderSize = 0;
            this.btncategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategoria.ForeColor = System.Drawing.Color.White;
            this.btncategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategoria.Location = new System.Drawing.Point(344, 388);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Size = new System.Drawing.Size(178, 41);
            this.btncategoria.TabIndex = 2;
            this.btncategoria.Text = "Guardar";
            this.btncategoria.UseVisualStyleBackColor = false;
            this.btncategoria.Click += new System.EventHandler(this.btncategoria_Click);
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
            this.lblcerrar.TabIndex = 64;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.btncategoria);
            this.Controls.Add(this.txtdesccat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodcateg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoria";
            this.Text = "categoria";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodcateg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdesccat;
        private System.Windows.Forms.Button btncategoria;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}