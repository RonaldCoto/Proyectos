namespace Sistema_Bibliotecario_INJI
{
    partial class Buscarlibro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_buscarpor = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnprestamo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvbusquedalibro = new System.Windows.Forms.DataGridView();
            this.cmbeditorial = new System.Windows.Forms.ComboBox();
            this.cmbcatego = new System.Windows.Forms.ComboBox();
            this.lblusuariobl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedalibro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(113, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por";
            // 
            // cmb_buscarpor
            // 
            this.cmb_buscarpor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_buscarpor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_buscarpor.FormattingEnabled = true;
            this.cmb_buscarpor.Items.AddRange(new object[] {
            "Categoría",
            "Nombre",
            "Autor",
            "Distribución"});
            this.cmb_buscarpor.Location = new System.Drawing.Point(117, 141);
            this.cmb_buscarpor.Name = "cmb_buscarpor";
            this.cmb_buscarpor.Size = new System.Drawing.Size(139, 25);
            this.cmb_buscarpor.TabIndex = 1;
            this.cmb_buscarpor.SelectedIndexChanged += new System.EventHandler(this.cmb_buscarpor_SelectedIndexChanged);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(117, 229);
            this.txtbusqueda.Multiline = true;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(443, 37);
            this.txtbusqueda.TabIndex = 2;
            this.txtbusqueda.Visible = false;
            this.txtbusqueda.Validated += new System.EventHandler(this.txtbusqueda_Validated);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(604, 229);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(134, 37);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar ";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            this.lblcerrar.TabIndex = 6;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "BUSCAR LIBRO";
            // 
            // btnprestamo
            // 
            this.btnprestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnprestamo.FlatAppearance.BorderSize = 0;
            this.btnprestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnprestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprestamo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprestamo.ForeColor = System.Drawing.Color.White;
            this.btnprestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprestamo.Location = new System.Drawing.Point(346, 533);
            this.btnprestamo.Name = "btnprestamo";
            this.btnprestamo.Size = new System.Drawing.Size(151, 37);
            this.btnprestamo.TabIndex = 8;
            this.btnprestamo.Text = "Realizar Prestamo";
            this.btnprestamo.UseVisualStyleBackColor = false;
            this.btnprestamo.Click += new System.EventHandler(this.btnprestamo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvbusquedalibro
            // 
            this.dgvbusquedalibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvbusquedalibro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvbusquedalibro.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvbusquedalibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvbusquedalibro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbusquedalibro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvbusquedalibro.ColumnHeadersHeight = 30;
            this.dgvbusquedalibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvbusquedalibro.EnableHeadersVisualStyles = false;
            this.dgvbusquedalibro.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvbusquedalibro.Location = new System.Drawing.Point(48, 288);
            this.dgvbusquedalibro.Name = "dgvbusquedalibro";
            this.dgvbusquedalibro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbusquedalibro.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvbusquedalibro.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvbusquedalibro.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvbusquedalibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbusquedalibro.Size = new System.Drawing.Size(755, 230);
            this.dgvbusquedalibro.TabIndex = 30;
            this.dgvbusquedalibro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbusquedalibro_CellContentClick);
            // 
            // cmbeditorial
            // 
            this.cmbeditorial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbeditorial.FormattingEnabled = true;
            this.cmbeditorial.Location = new System.Drawing.Point(288, 141);
            this.cmbeditorial.Name = "cmbeditorial";
            this.cmbeditorial.Size = new System.Drawing.Size(139, 25);
            this.cmbeditorial.TabIndex = 31;
            this.cmbeditorial.Visible = false;
            // 
            // cmbcatego
            // 
            this.cmbcatego.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcatego.FormattingEnabled = true;
            this.cmbcatego.Location = new System.Drawing.Point(288, 141);
            this.cmbcatego.Name = "cmbcatego";
            this.cmbcatego.Size = new System.Drawing.Size(139, 25);
            this.cmbcatego.TabIndex = 32;
            this.cmbcatego.Visible = false;
            // 
            // lblusuariobl
            // 
            this.lblusuariobl.AutoSize = true;
            this.lblusuariobl.Location = new System.Drawing.Point(12, 9);
            this.lblusuariobl.Name = "lblusuariobl";
            this.lblusuariobl.Size = new System.Drawing.Size(43, 13);
            this.lblusuariobl.TabIndex = 62;
            this.lblusuariobl.Text = "Usuario";
            this.lblusuariobl.Visible = false;
            // 
            // Buscarlibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.lblusuariobl);
            this.Controls.Add(this.cmbcatego);
            this.Controls.Add(this.cmbeditorial);
            this.Controls.Add(this.dgvbusquedalibro);
            this.Controls.Add(this.btnprestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cmb_buscarpor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscarlibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscarlibro";
            this.Load += new System.EventHandler(this.Buscarlibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedalibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_buscarpor;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnprestamo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbcatego;
        private System.Windows.Forms.ComboBox cmbeditorial;
        public System.Windows.Forms.DataGridView dgvbusquedalibro;
        public System.Windows.Forms.Label lblusuariobl;
    }
}