namespace Sistema_Bibliotecario_INJI
{
    partial class Adminestudiantes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbuscarpor = new System.Windows.Forms.ComboBox();
            this.btnelimestu = new System.Windows.Forms.Button();
            this.btnactuaestu = new System.Windows.Forms.Button();
            this.btnbuscarestu = new System.Windows.Forms.Button();
            this.txtbusquedaalum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbusgrado = new System.Windows.Forms.ComboBox();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvlistalum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistalum)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ADMINISTRAR ESTUDIANTES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por ";
            // 
            // cmbbuscarpor
            // 
            this.cmbbuscarpor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbuscarpor.FormattingEnabled = true;
            this.cmbbuscarpor.Items.AddRange(new object[] {
            "NIE",
            "Grado"});
            this.cmbbuscarpor.Location = new System.Drawing.Point(111, 126);
            this.cmbbuscarpor.Name = "cmbbuscarpor";
            this.cmbbuscarpor.Size = new System.Drawing.Size(139, 25);
            this.cmbbuscarpor.TabIndex = 0;
            this.cmbbuscarpor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnelimestu
            // 
            this.btnelimestu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnelimestu.FlatAppearance.BorderSize = 0;
            this.btnelimestu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnelimestu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelimestu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnelimestu.ForeColor = System.Drawing.Color.White;
            this.btnelimestu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnelimestu.Location = new System.Drawing.Point(484, 494);
            this.btnelimestu.Name = "btnelimestu";
            this.btnelimestu.Size = new System.Drawing.Size(178, 41);
            this.btnelimestu.TabIndex = 21;
            this.btnelimestu.Text = "Eliminar";
            this.btnelimestu.UseVisualStyleBackColor = false;
            this.btnelimestu.Click += new System.EventHandler(this.btnelimestu_Click);
            // 
            // btnactuaestu
            // 
            this.btnactuaestu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnactuaestu.FlatAppearance.BorderSize = 0;
            this.btnactuaestu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnactuaestu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactuaestu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactuaestu.ForeColor = System.Drawing.Color.White;
            this.btnactuaestu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactuaestu.Location = new System.Drawing.Point(218, 494);
            this.btnactuaestu.Name = "btnactuaestu";
            this.btnactuaestu.Size = new System.Drawing.Size(178, 41);
            this.btnactuaestu.TabIndex = 22;
            this.btnactuaestu.Text = "Actualizar";
            this.btnactuaestu.UseVisualStyleBackColor = false;
            this.btnactuaestu.Click += new System.EventHandler(this.btnactuaestu_Click);
            // 
            // btnbuscarestu
            // 
            this.btnbuscarestu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnbuscarestu.FlatAppearance.BorderSize = 0;
            this.btnbuscarestu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnbuscarestu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarestu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarestu.ForeColor = System.Drawing.Color.White;
            this.btnbuscarestu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarestu.Location = new System.Drawing.Point(626, 187);
            this.btnbuscarestu.Name = "btnbuscarestu";
            this.btnbuscarestu.Size = new System.Drawing.Size(134, 37);
            this.btnbuscarestu.TabIndex = 24;
            this.btnbuscarestu.Text = "Buscar ";
            this.btnbuscarestu.UseVisualStyleBackColor = false;
            this.btnbuscarestu.Click += new System.EventHandler(this.btnbuscarestu_Click);
            // 
            // txtbusquedaalum
            // 
            this.txtbusquedaalum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusquedaalum.Location = new System.Drawing.Point(111, 195);
            this.txtbusquedaalum.MaxLength = 8;
            this.txtbusquedaalum.Multiline = true;
            this.txtbusquedaalum.Name = "txtbusquedaalum";
            this.txtbusquedaalum.Size = new System.Drawing.Size(263, 29);
            this.txtbusquedaalum.TabIndex = 1;
            this.txtbusquedaalum.Visible = false;
            this.txtbusquedaalum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusquedaalum_KeyPress);
            this.txtbusquedaalum.Validated += new System.EventHandler(this.txtbusquedaalum_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(415, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Grado";
            this.label3.Visible = false;
            // 
            // cmbbusgrado
            // 
            this.cmbbusgrado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbusgrado.FormattingEnabled = true;
            this.cmbbusgrado.Items.AddRange(new object[] {
            "1er Año",
            "2do Año",
            "3er Año"});
            this.cmbbusgrado.Location = new System.Drawing.Point(419, 199);
            this.cmbbusgrado.Name = "cmbbusgrado";
            this.cmbbusgrado.Size = new System.Drawing.Size(139, 25);
            this.cmbbusgrado.TabIndex = 26;
            this.cmbbusgrado.Visible = false;
            this.cmbbusgrado.SelectedIndexChanged += new System.EventHandler(this.cmbbusgrado_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "NIE";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvlistalum
            // 
            this.dgvlistalum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvlistalum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvlistalum.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvlistalum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvlistalum.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistalum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvlistalum.ColumnHeadersHeight = 30;
            this.dgvlistalum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlistalum.EnableHeadersVisualStyles = false;
            this.dgvlistalum.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvlistalum.Location = new System.Drawing.Point(174, 258);
            this.dgvlistalum.Name = "dgvlistalum";
            this.dgvlistalum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistalum.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvlistalum.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvlistalum.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvlistalum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistalum.Size = new System.Drawing.Size(525, 230);
            this.dgvlistalum.TabIndex = 29;
            this.dgvlistalum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistalum_CellContentClick_1);
            // 
            // Adminestudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.dgvlistalum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.cmbbusgrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbuscarestu);
            this.Controls.Add(this.txtbusquedaalum);
            this.Controls.Add(this.btnactuaestu);
            this.Controls.Add(this.btnelimestu);
            this.Controls.Add(this.cmbbuscarpor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminestudiantes";
            this.Text = "Adminestudiantes";
            this.Load += new System.EventHandler(this.Adminestudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistalum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbuscarpor;
        private System.Windows.Forms.Button btnelimestu;
        private System.Windows.Forms.Button btnactuaestu;
        private System.Windows.Forms.Button btnbuscarestu;
        private System.Windows.Forms.TextBox txtbusquedaalum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbusgrado;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvlistalum;
    }
}