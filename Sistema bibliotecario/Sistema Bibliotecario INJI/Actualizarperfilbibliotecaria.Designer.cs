namespace Sistema_Bibliotecario_INJI
{
    partial class Actualizarperfilbibliotecaria
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombiblio2 = new System.Windows.Forms.TextBox();
            this.txtnombiblio1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcontraanti = new System.Windows.Forms.TextBox();
            this.txtcontranueva = new System.Windows.Forms.TextBox();
            this.txtconfirmcont = new System.Windows.Forms.TextBox();
            this.btnactualibiblio = new System.Windows.Forms.Button();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.txtusernamebiact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtapellbiblio2 = new System.Windows.Forms.TextBox();
            this.txtapellbiblio1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "ACTUALIZAR MI CUENTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nombre 2";
            // 
            // txtnombiblio2
            // 
            this.txtnombiblio2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombiblio2.Location = new System.Drawing.Point(416, 164);
            this.txtnombiblio2.Name = "txtnombiblio2";
            this.txtnombiblio2.Size = new System.Drawing.Size(216, 23);
            this.txtnombiblio2.TabIndex = 1;
            this.txtnombiblio2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellbiblio_KeyPress);
            this.txtnombiblio2.Validated += new System.EventHandler(this.txtapellbiblio_Validated);
            // 
            // txtnombiblio1
            // 
            this.txtnombiblio1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombiblio1.Location = new System.Drawing.Point(416, 110);
            this.txtnombiblio1.Name = "txtnombiblio1";
            this.txtnombiblio1.Size = new System.Drawing.Size(216, 23);
            this.txtnombiblio1.TabIndex = 0;
            this.txtnombiblio1.TextChanged += new System.EventHandler(this.txtnombiblio1_TextChanged);
            this.txtnombiblio1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombiblio_KeyPress);
            this.txtnombiblio1.Validated += new System.EventHandler(this.txtnombiblio_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Contraseña Antigua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Contraseña Nueva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Confirmar Contraseña";
            // 
            // txtcontraanti
            // 
            this.txtcontraanti.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraanti.Location = new System.Drawing.Point(416, 379);
            this.txtcontraanti.Name = "txtcontraanti";
            this.txtcontraanti.PasswordChar = '*';
            this.txtcontraanti.Size = new System.Drawing.Size(216, 23);
            this.txtcontraanti.TabIndex = 5;
            this.txtcontraanti.Validated += new System.EventHandler(this.txtcontraanti_Validated);
            // 
            // txtcontranueva
            // 
            this.txtcontranueva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontranueva.Location = new System.Drawing.Point(416, 439);
            this.txtcontranueva.Name = "txtcontranueva";
            this.txtcontranueva.PasswordChar = '*';
            this.txtcontranueva.Size = new System.Drawing.Size(216, 23);
            this.txtcontranueva.TabIndex = 6;
            this.txtcontranueva.TextChanged += new System.EventHandler(this.txtcontranueva_TextChanged);
            this.txtcontranueva.Validated += new System.EventHandler(this.txtcontranueva_Validated);
            // 
            // txtconfirmcont
            // 
            this.txtconfirmcont.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmcont.Location = new System.Drawing.Point(416, 496);
            this.txtconfirmcont.Name = "txtconfirmcont";
            this.txtconfirmcont.PasswordChar = '*';
            this.txtconfirmcont.Size = new System.Drawing.Size(216, 23);
            this.txtconfirmcont.TabIndex = 7;
            this.txtconfirmcont.TextChanged += new System.EventHandler(this.txtconfirmcont_TextChanged);
            this.txtconfirmcont.Validated += new System.EventHandler(this.txtconfirmcont_Validated);
            // 
            // btnactualibiblio
            // 
            this.btnactualibiblio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnactualibiblio.FlatAppearance.BorderSize = 0;
            this.btnactualibiblio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnactualibiblio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualibiblio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualibiblio.ForeColor = System.Drawing.Color.White;
            this.btnactualibiblio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualibiblio.Location = new System.Drawing.Point(367, 539);
            this.btnactualibiblio.Name = "btnactualibiblio";
            this.btnactualibiblio.Size = new System.Drawing.Size(134, 37);
            this.btnactualibiblio.TabIndex = 8;
            this.btnactualibiblio.Text = "Actualizar";
            this.btnactualibiblio.UseVisualStyleBackColor = false;
            this.btnactualibiblio.Click += new System.EventHandler(this.btnactualibiblio_Click);
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
            this.lblcerrar.TabIndex = 41;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // txtusernamebiact
            // 
            this.txtusernamebiact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusernamebiact.Location = new System.Drawing.Point(417, 319);
            this.txtusernamebiact.Name = "txtusernamebiact";
            this.txtusernamebiact.Size = new System.Drawing.Size(216, 23);
            this.txtusernamebiact.TabIndex = 4;
            this.txtusernamebiact.Validated += new System.EventHandler(this.txtusernamebiact_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Apellido 2";
            // 
            // txtapellbiblio2
            // 
            this.txtapellbiblio2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellbiblio2.Location = new System.Drawing.Point(416, 267);
            this.txtapellbiblio2.Name = "txtapellbiblio2";
            this.txtapellbiblio2.Size = new System.Drawing.Size(216, 23);
            this.txtapellbiblio2.TabIndex = 3;
            this.txtapellbiblio2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellbiblio2_KeyPress);
            this.txtapellbiblio2.Validated += new System.EventHandler(this.txtapellbiblio2_Validated);
            // 
            // txtapellbiblio1
            // 
            this.txtapellbiblio1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellbiblio1.Location = new System.Drawing.Point(416, 213);
            this.txtapellbiblio1.Name = "txtapellbiblio1";
            this.txtapellbiblio1.Size = new System.Drawing.Size(216, 23);
            this.txtapellbiblio1.TabIndex = 2;
            this.txtapellbiblio1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellbiblio1_KeyPress);
            this.txtapellbiblio1.Validated += new System.EventHandler(this.txtapellbiblio1_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(215, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Apellido 1";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(12, 9);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 61;
            this.lblusuario.Text = "Usuario";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(59, 9);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseña.TabIndex = 62;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // Actualizarperfilbibliotecaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtapellbiblio2);
            this.Controls.Add(this.txtapellbiblio1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtusernamebiact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.btnactualibiblio);
            this.Controls.Add(this.txtconfirmcont);
            this.Controls.Add(this.txtcontranueva);
            this.Controls.Add(this.txtcontraanti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombiblio2);
            this.Controls.Add(this.txtnombiblio1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Actualizarperfilbibliotecaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizarperfilbibliotecaria";
            this.Load += new System.EventHandler(this.Actualizarperfilbibliotecaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombiblio2;
        private System.Windows.Forms.TextBox txtnombiblio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcontraanti;
        private System.Windows.Forms.TextBox txtcontranueva;
        private System.Windows.Forms.TextBox txtconfirmcont;
        private System.Windows.Forms.Button btnactualibiblio;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.TextBox txtusernamebiact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtapellbiblio2;
		private System.Windows.Forms.TextBox txtapellbiblio1;
		private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblcontraseña;
        public System.Windows.Forms.Label lblusuario;
    }
}