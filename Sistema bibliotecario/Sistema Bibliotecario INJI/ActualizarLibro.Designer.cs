namespace Sistema_Bibliotecario_INJI
{
    partial class ActualizarLibro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.btneliminarlib = new System.Windows.Forms.Button();
            this.btnactualizarlib = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvlistadolibro = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscarlibro = new System.Windows.Forms.Button();
            this.cmbbuscarpor = new System.Windows.Forms.ComboBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblautor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadolibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.lblcerrar.TabIndex = 11;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // btneliminarlib
            // 
            this.btneliminarlib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btneliminarlib.FlatAppearance.BorderSize = 0;
            this.btneliminarlib.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btneliminarlib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarlib.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarlib.ForeColor = System.Drawing.Color.White;
            this.btneliminarlib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminarlib.Location = new System.Drawing.Point(431, 551);
            this.btneliminarlib.Name = "btneliminarlib";
            this.btneliminarlib.Size = new System.Drawing.Size(134, 37);
            this.btneliminarlib.TabIndex = 18;
            this.btneliminarlib.Text = "Eliminar";
            this.btneliminarlib.UseVisualStyleBackColor = false;
            this.btneliminarlib.Click += new System.EventHandler(this.btneliminarlib_Click);
            // 
            // btnactualizarlib
            // 
            this.btnactualizarlib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnactualizarlib.FlatAppearance.BorderSize = 0;
            this.btnactualizarlib.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnactualizarlib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizarlib.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarlib.ForeColor = System.Drawing.Color.White;
            this.btnactualizarlib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizarlib.Location = new System.Drawing.Point(227, 551);
            this.btnactualizarlib.Name = "btnactualizarlib";
            this.btnactualizarlib.Size = new System.Drawing.Size(134, 37);
            this.btnactualizarlib.TabIndex = 17;
            this.btnactualizarlib.Text = "Actualizar";
            this.btnactualizarlib.UseVisualStyleBackColor = false;
            this.btnactualizarlib.Click += new System.EventHandler(this.btnactualizarlib_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "ACTUALIZAR LIBRO";
            // 
            // dgvlistadolibro
            // 
            this.dgvlistadolibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvlistadolibro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvlistadolibro.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvlistadolibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvlistadolibro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistadolibro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvlistadolibro.ColumnHeadersHeight = 30;
            this.dgvlistadolibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlistadolibro.EnableHeadersVisualStyles = false;
            this.dgvlistadolibro.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvlistadolibro.Location = new System.Drawing.Point(27, 244);
            this.dgvlistadolibro.Name = "dgvlistadolibro";
            this.dgvlistadolibro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistadolibro.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvlistadolibro.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvlistadolibro.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvlistadolibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistadolibro.Size = new System.Drawing.Size(774, 279);
            this.dgvlistadolibro.TabIndex = 15;
            this.dgvlistadolibro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistadolibro_CellContentClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(155, 180);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(450, 24);
            this.txtbuscar.TabIndex = 19;
            this.txtbuscar.Validated += new System.EventHandler(this.txtbuscar_Validated);
            // 
            // btnbuscarlibro
            // 
            this.btnbuscarlibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.btnbuscarlibro.FlatAppearance.BorderSize = 0;
            this.btnbuscarlibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnbuscarlibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarlibro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarlibro.ForeColor = System.Drawing.Color.White;
            this.btnbuscarlibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarlibro.Location = new System.Drawing.Point(621, 170);
            this.btnbuscarlibro.Name = "btnbuscarlibro";
            this.btnbuscarlibro.Size = new System.Drawing.Size(134, 37);
            this.btnbuscarlibro.TabIndex = 25;
            this.btnbuscarlibro.Text = "Buscar ";
            this.btnbuscarlibro.UseVisualStyleBackColor = false;
            this.btnbuscarlibro.Click += new System.EventHandler(this.btnbuscarestu_Click);
            // 
            // cmbbuscarpor
            // 
            this.cmbbuscarpor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbuscarpor.FormattingEnabled = true;
            this.cmbbuscarpor.Items.AddRange(new object[] {
            "Título",
            "Autor"});
            this.cmbbuscarpor.Location = new System.Drawing.Point(66, 108);
            this.cmbbuscarpor.Name = "cmbbuscarpor";
            this.cmbbuscarpor.Size = new System.Drawing.Size(122, 25);
            this.cmbbuscarpor.TabIndex = 26;
            this.cmbbuscarpor.SelectedIndexChanged += new System.EventHandler(this.cmbbuscarpor_SelectedIndexChanged);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(94, 178);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(47, 20);
            this.lbltitulo.TabIndex = 27;
            this.lbltitulo.Text = "Título";
            this.lbltitulo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Buscar por";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblautor.Location = new System.Drawing.Point(93, 178);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(48, 20);
            this.lblautor.TabIndex = 29;
            this.lblautor.Text = "Autor";
            this.lblautor.Visible = false;
            // 
            // ActualizarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.lblautor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.cmbbuscarpor);
            this.Controls.Add(this.btnbuscarlibro);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btneliminarlib);
            this.Controls.Add(this.btnactualizarlib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvlistadolibro);
            this.Controls.Add(this.lblcerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 50);
            this.Name = "ActualizarLibro";
            this.Text = "ActualizarLibro";
            this.Load += new System.EventHandler(this.ActualizarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadolibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Button btneliminarlib;
        private System.Windows.Forms.Button btnactualizarlib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvlistadolibro;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscarlibro;
        private System.Windows.Forms.ComboBox cmbbuscarpor;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblautor;
    }
}