
namespace AplicacionIMDb
{
    partial class FrmLista
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
            this.dataGridLista = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblContadorPelis = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbxResultados = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEstadistica3 = new System.Windows.Forms.Button();
            this.btnEstadistica2 = new System.Windows.Forms.Button();
            this.btnEstadistica1 = new System.Windows.Forms.Button();
            this.btnEstadistica4 = new System.Windows.Forms.Button();
            this.btnEstadistica5 = new System.Windows.Forms.Button();
            this.btnVerTodas = new System.Windows.Forms.Button();
            this.btnMostrarEstadisticas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridLista
            // 
            this.dataGridLista.AllowUserToAddRows = false;
            this.dataGridLista.AllowUserToDeleteRows = false;
            this.dataGridLista.AllowUserToOrderColumns = true;
            this.dataGridLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLista.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLista.Location = new System.Drawing.Point(0, 0);
            this.dataGridLista.Name = "dataGridLista";
            this.dataGridLista.ReadOnly = true;
            this.dataGridLista.RowTemplate.Height = 25;
            this.dataGridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLista.Size = new System.Drawing.Size(832, 563);
            this.dataGridLista.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridLista);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblContadorPelis);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.lblCantidad);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(1219, 563);
            this.splitContainer1.SplitterDistance = 832;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblContadorPelis
            // 
            this.lblContadorPelis.AutoSize = true;
            this.lblContadorPelis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContadorPelis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContadorPelis.ForeColor = System.Drawing.Color.White;
            this.lblContadorPelis.Location = new System.Drawing.Point(277, 432);
            this.lblContadorPelis.Name = "lblContadorPelis";
            this.lblContadorPelis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContadorPelis.Size = new System.Drawing.Size(15, 17);
            this.lblContadorPelis.TabIndex = 3;
            this.lblContadorPelis.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbxResultados);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 111);
            this.panel2.TabIndex = 4;
            // 
            // rtbxResultados
            // 
            this.rtbxResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbxResultados.Location = new System.Drawing.Point(0, 0);
            this.rtbxResultados.Name = "rtbxResultados";
            this.rtbxResultados.Size = new System.Drawing.Size(383, 111);
            this.rtbxResultados.TabIndex = 1;
            this.rtbxResultados.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(96, 432);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCantidad.Size = new System.Drawing.Size(163, 17);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad total de películas";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnEstadistica3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnEstadistica2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnEstadistica1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEstadistica4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnEstadistica5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnVerTodas, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnMostrarEstadisticas, 0, 6);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 347);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnEstadistica3
            // 
            this.btnEstadistica3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEstadistica3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadistica3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadistica3.Location = new System.Drawing.Point(3, 127);
            this.btnEstadistica3.Name = "btnEstadistica3";
            this.btnEstadistica3.Size = new System.Drawing.Size(377, 41);
            this.btnEstadistica3.TabIndex = 4;
            this.btnEstadistica3.Text = "b3";
            this.btnEstadistica3.UseVisualStyleBackColor = false;
            this.btnEstadistica3.Click += new System.EventHandler(this.btnEstadistica3_Click);
            // 
            // btnEstadistica2
            // 
            this.btnEstadistica2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEstadistica2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadistica2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadistica2.Location = new System.Drawing.Point(3, 80);
            this.btnEstadistica2.Name = "btnEstadistica2";
            this.btnEstadistica2.Size = new System.Drawing.Size(377, 41);
            this.btnEstadistica2.TabIndex = 3;
            this.btnEstadistica2.Text = "b2";
            this.btnEstadistica2.UseVisualStyleBackColor = false;
            this.btnEstadistica2.Click += new System.EventHandler(this.btnEstadistica2_Click);
            // 
            // btnEstadistica1
            // 
            this.btnEstadistica1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEstadistica1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadistica1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadistica1.Location = new System.Drawing.Point(3, 33);
            this.btnEstadistica1.Name = "btnEstadistica1";
            this.btnEstadistica1.Size = new System.Drawing.Size(377, 41);
            this.btnEstadistica1.TabIndex = 2;
            this.btnEstadistica1.Text = "b1";
            this.btnEstadistica1.UseVisualStyleBackColor = false;
            this.btnEstadistica1.Click += new System.EventHandler(this.btnEstadistica1_Click);
            // 
            // btnEstadistica4
            // 
            this.btnEstadistica4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEstadistica4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadistica4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadistica4.Location = new System.Drawing.Point(3, 174);
            this.btnEstadistica4.Name = "btnEstadistica4";
            this.btnEstadistica4.Size = new System.Drawing.Size(377, 41);
            this.btnEstadistica4.TabIndex = 6;
            this.btnEstadistica4.Text = "b4";
            this.btnEstadistica4.UseVisualStyleBackColor = false;
            this.btnEstadistica4.Click += new System.EventHandler(this.btnEstadistica4_Click);
            // 
            // btnEstadistica5
            // 
            this.btnEstadistica5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEstadistica5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadistica5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadistica5.Location = new System.Drawing.Point(3, 221);
            this.btnEstadistica5.Name = "btnEstadistica5";
            this.btnEstadistica5.Size = new System.Drawing.Size(377, 41);
            this.btnEstadistica5.TabIndex = 7;
            this.btnEstadistica5.Text = "b5";
            this.btnEstadistica5.UseVisualStyleBackColor = false;
            this.btnEstadistica5.Click += new System.EventHandler(this.btnEstadistica5_Click);
            // 
            // btnVerTodas
            // 
            this.btnVerTodas.BackColor = System.Drawing.Color.Gold;
            this.btnVerTodas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerTodas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerTodas.Location = new System.Drawing.Point(3, 315);
            this.btnVerTodas.Name = "btnVerTodas";
            this.btnVerTodas.Size = new System.Drawing.Size(377, 29);
            this.btnVerTodas.TabIndex = 5;
            this.btnVerTodas.Text = "Ver todas ";
            this.btnVerTodas.UseVisualStyleBackColor = false;
            this.btnVerTodas.Click += new System.EventHandler(this.btnVerTodas_Click);
            // 
            // btnMostrarEstadisticas
            // 
            this.btnMostrarEstadisticas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMostrarEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrarEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarEstadisticas.Location = new System.Drawing.Point(3, 268);
            this.btnMostrarEstadisticas.Name = "btnMostrarEstadisticas";
            this.btnMostrarEstadisticas.Size = new System.Drawing.Size(377, 41);
            this.btnMostrarEstadisticas.TabIndex = 8;
            this.btnMostrarEstadisticas.Text = "Mostrar estadísticas";
            this.btnMostrarEstadisticas.UseVisualStyleBackColor = false;
            this.btnMostrarEstadisticas.Click += new System.EventHandler(this.btnMostrarEstadisticas_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.50938F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.24531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.24531F));
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 2, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 68);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Gold;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 62);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gold;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(146, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 62);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gold;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(265, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 62);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1219, 563);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1235, 503);
            this.Name = "FrmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLista";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLista;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEstadistica1;
        private System.Windows.Forms.Button btnEstadistica2;
        private System.Windows.Forms.Button btnEstadistica3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerTodas;
        private System.Windows.Forms.Label lblContadorPelis;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnEstadistica4;
        private System.Windows.Forms.Button btnEstadistica5;
        private System.Windows.Forms.Button btnMostrarEstadisticas;
        private System.Windows.Forms.RichTextBox rtbxResultados;
    }
}