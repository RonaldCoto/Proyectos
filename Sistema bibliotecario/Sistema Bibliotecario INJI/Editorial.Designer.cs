namespace Sistema_Bibliotecario_INJI
{
    partial class Editorial
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnguardareditorial = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.lblcerrar.TabIndex = 22;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "CREAR NUEVA DISTRIBUCIÓN";
            // 
            // btnguardareditorial
            // 
            this.btnguardareditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnguardareditorial.FlatAppearance.BorderSize = 0;
            this.btnguardareditorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnguardareditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardareditorial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardareditorial.ForeColor = System.Drawing.Color.White;
            this.btnguardareditorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardareditorial.Location = new System.Drawing.Point(343, 270);
            this.btnguardareditorial.Name = "btnguardareditorial";
            this.btnguardareditorial.Size = new System.Drawing.Size(178, 41);
            this.btnguardareditorial.TabIndex = 31;
            this.btnguardareditorial.Text = "Guardar";
            this.btnguardareditorial.UseVisualStyleBackColor = false;
            this.btnguardareditorial.Click += new System.EventHandler(this.btnguardareditorial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "País";
            // 
            // txtpais
            // 
            this.txtpais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpais.Location = new System.Drawing.Point(367, 190);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(216, 23);
            this.txtpais.TabIndex = 27;
            this.txtpais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpais_KeyPress);
            this.txtpais.Validated += new System.EventHandler(this.txtpais_Validated);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(367, 146);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(216, 23);
            this.txtnombre.TabIndex = 26;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            this.txtnombre.Validated += new System.EventHandler(this.txtnombre_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Editorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.btnguardareditorial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editorial";
            this.Text = "Editorial";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardareditorial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}