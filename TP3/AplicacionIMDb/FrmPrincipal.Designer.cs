
namespace AplicacionIMDb
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPelículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarPelículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoPelículasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoSeriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConfirmacionArchivos = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeries = new System.Windows.Forms.Button();
            this.dataGridViewSeries = new System.Windows.Forms.DataGridView();
            this.dataGridViewPeliculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPeliculas.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnPeliculas.FlatAppearance.BorderSize = 4;
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPeliculas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPeliculas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPeliculas.Location = new System.Drawing.Point(3, 3);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(909, 44);
            this.btnPeliculas.TabIndex = 0;
            this.btnPeliculas.Text = "Películas";
            this.btnPeliculas.UseVisualStyleBackColor = false;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logo.ErrorImage")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(352, 47);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(224, 100);
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.guardarToolStripMenuItem1,
            this.guardarComoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPelículasToolStripMenuItem,
            this.listaSeriesToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.archivoToolStripMenuItem.Text = "Abrir";
            // 
            // listaPelículasToolStripMenuItem
            // 
            this.listaPelículasToolStripMenuItem.Name = "listaPelículasToolStripMenuItem";
            this.listaPelículasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listaPelículasToolStripMenuItem.Text = "Lista películas";
            this.listaPelículasToolStripMenuItem.Click += new System.EventHandler(this.listaPelículasToolStripMenuItem_Click);
            // 
            // listaSeriesToolStripMenuItem
            // 
            this.listaSeriesToolStripMenuItem.Name = "listaSeriesToolStripMenuItem";
            this.listaSeriesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listaSeriesToolStripMenuItem.Text = "Lista series";
            this.listaSeriesToolStripMenuItem.Click += new System.EventHandler(this.listaSeriesToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarPelículasToolStripMenuItem,
            this.guardarSeriesToolStripMenuItem});
            this.guardarToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem1.Text = "Guardar";
            // 
            // guardarPelículasToolStripMenuItem
            // 
            this.guardarPelículasToolStripMenuItem.Name = "guardarPelículasToolStripMenuItem";
            this.guardarPelículasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.guardarPelículasToolStripMenuItem.Text = "Guardar lista películas";
            this.guardarPelículasToolStripMenuItem.Click += new System.EventHandler(this.guardarPelículasToolStripMenuItem_Click);
            // 
            // guardarSeriesToolStripMenuItem
            // 
            this.guardarSeriesToolStripMenuItem.Name = "guardarSeriesToolStripMenuItem";
            this.guardarSeriesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.guardarSeriesToolStripMenuItem.Text = "Guardar lista series";
            this.guardarSeriesToolStripMenuItem.Click += new System.EventHandler(this.guardarSeriesToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem1
            // 
            this.guardarComoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarComoPelículasToolStripMenuItem1,
            this.guardarComoSeriesToolStripMenuItem1});
            this.guardarComoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardarComoToolStripMenuItem1.Name = "guardarComoToolStripMenuItem1";
            this.guardarComoToolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.guardarComoToolStripMenuItem1.Text = "Guardar como";
            // 
            // guardarComoPelículasToolStripMenuItem1
            // 
            this.guardarComoPelículasToolStripMenuItem1.Name = "guardarComoPelículasToolStripMenuItem1";
            this.guardarComoPelículasToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.guardarComoPelículasToolStripMenuItem1.Text = "Películas";
            this.guardarComoPelículasToolStripMenuItem1.Click += new System.EventHandler(this.guardarComoPelículasToolStripMenuItem1_Click);
            // 
            // guardarComoSeriesToolStripMenuItem1
            // 
            this.guardarComoSeriesToolStripMenuItem1.Name = "guardarComoSeriesToolStripMenuItem1";
            this.guardarComoSeriesToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.guardarComoSeriesToolStripMenuItem1.Text = "Series";
            this.guardarComoSeriesToolStripMenuItem1.Click += new System.EventHandler(this.guardarComoSeriesToolStripMenuItem1_Click);
            // 
            // lblConfirmacionArchivos
            // 
            this.lblConfirmacionArchivos.AutoSize = true;
            this.lblConfirmacionArchivos.BackColor = System.Drawing.Color.Black;
            this.lblConfirmacionArchivos.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblConfirmacionArchivos.Location = new System.Drawing.Point(662, 9);
            this.lblConfirmacionArchivos.Name = "lblConfirmacionArchivos";
            this.lblConfirmacionArchivos.Size = new System.Drawing.Size(94, 15);
            this.lblConfirmacionArchivos.TabIndex = 10;
            this.lblConfirmacionArchivos.Text = "Archivo cargado";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSeries, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewSeries, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewPeliculas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPeliculas, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 488);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnSeries
            // 
            this.btnSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeries.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSeries.FlatAppearance.BorderSize = 4;
            this.btnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeries.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeries.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeries.Location = new System.Drawing.Point(3, 247);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(909, 44);
            this.btnSeries.TabIndex = 3;
            this.btnSeries.Text = "Series";
            this.btnSeries.UseVisualStyleBackColor = false;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click_1);
            // 
            // dataGridViewSeries
            // 
            this.dataGridViewSeries.AllowUserToAddRows = false;
            this.dataGridViewSeries.AllowUserToDeleteRows = false;
            this.dataGridViewSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSeries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeries.Enabled = false;
            this.dataGridViewSeries.Location = new System.Drawing.Point(3, 297);
            this.dataGridViewSeries.Name = "dataGridViewSeries";
            this.dataGridViewSeries.ReadOnly = true;
            this.dataGridViewSeries.RowTemplate.Height = 25;
            this.dataGridViewSeries.Size = new System.Drawing.Size(909, 188);
            this.dataGridViewSeries.TabIndex = 1;
            // 
            // dataGridViewPeliculas
            // 
            this.dataGridViewPeliculas.AllowUserToAddRows = false;
            this.dataGridViewPeliculas.AllowUserToDeleteRows = false;
            this.dataGridViewPeliculas.AllowUserToResizeColumns = false;
            this.dataGridViewPeliculas.AllowUserToResizeRows = false;
            this.dataGridViewPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPeliculas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPeliculas.Enabled = false;
            this.dataGridViewPeliculas.Location = new System.Drawing.Point(3, 53);
            this.dataGridViewPeliculas.Name = "dataGridViewPeliculas";
            this.dataGridViewPeliculas.ReadOnly = true;
            this.dataGridViewPeliculas.RowTemplate.Height = 25;
            this.dataGridViewPeliculas.Size = new System.Drawing.Size(909, 188);
            this.dataGridViewPeliculas.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(915, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblConfirmacionArchivos);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Label lblConfirmacionArchivos;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaPelículasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoPelículasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarComoSeriesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarPelículasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarSeriesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.DataGridView dataGridViewSeries;
        private System.Windows.Forms.DataGridView dataGridViewPeliculas;
    }
}

