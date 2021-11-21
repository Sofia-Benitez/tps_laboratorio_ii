
namespace AplicacionIMDb
{
    partial class FrmAltayModificacion
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
            this.lblTipoContenido = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtEscritor = new System.Windows.Forms.TextBox();
            this.txtActor1 = new System.Windows.Forms.TextBox();
            this.txtActor3 = new System.Windows.Forms.TextBox();
            this.txtActor2 = new System.Windows.Forms.TextBox();
            this.txtTemporadas = new System.Windows.Forms.TextBox();
            this.txtAñoFinalizacion = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAñofin = new System.Windows.Forms.Label();
            this.lblTempODuracion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoContenido
            // 
            this.lblTipoContenido.AutoSize = true;
            this.lblTipoContenido.Location = new System.Drawing.Point(214, 4);
            this.lblTipoContenido.Name = "lblTipoContenido";
            this.lblTipoContenido.Size = new System.Drawing.Size(38, 15);
            this.lblTipoContenido.TabIndex = 0;
            this.lblTipoContenido.Text = "label1";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(90, 44);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "Titulo";
            this.txtTitulo.Size = new System.Drawing.Size(289, 23);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(90, 97);
            this.txtAño.Name = "txtAño";
            this.txtAño.PlaceholderText = "Año";
            this.txtAño.Size = new System.Drawing.Size(116, 23);
            this.txtAño.TabIndex = 4;
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Comedia",
            "Drama",
            "Terror",
            "Thriller",
            "Comedia romántica",
            "Aventura",
            "Crimen",
            "Misterio",
            "Fantástico"});
            this.cbxGenero.Location = new System.Drawing.Point(214, 97);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(165, 23);
            this.cbxGenero.TabIndex = 5;
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(242, 206);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.PlaceholderText = "Puntuación";
            this.txtPuntuacion.Size = new System.Drawing.Size(137, 23);
            this.txtPuntuacion.TabIndex = 6;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(90, 206);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.PlaceholderText = "Duración en minutos";
            this.txtDuracion.Size = new System.Drawing.Size(137, 23);
            this.txtDuracion.TabIndex = 7;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(90, 257);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(60, 15);
            this.lblEquipo.TabIndex = 8;
            this.lblEquipo.Text = "Director/a";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(90, 275);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.PlaceholderText = "Director/a";
            this.txtDirector.Size = new System.Drawing.Size(137, 23);
            this.txtDirector.TabIndex = 9;
            // 
            // txtEscritor
            // 
            this.txtEscritor.Location = new System.Drawing.Point(242, 275);
            this.txtEscritor.Name = "txtEscritor";
            this.txtEscritor.PlaceholderText = "Escritor/a";
            this.txtEscritor.Size = new System.Drawing.Size(137, 23);
            this.txtEscritor.TabIndex = 10;
            // 
            // txtActor1
            // 
            this.txtActor1.Location = new System.Drawing.Point(90, 333);
            this.txtActor1.Name = "txtActor1";
            this.txtActor1.PlaceholderText = "Actor/actriz 1";
            this.txtActor1.Size = new System.Drawing.Size(137, 23);
            this.txtActor1.TabIndex = 11;
            // 
            // txtActor3
            // 
            this.txtActor3.Location = new System.Drawing.Point(90, 362);
            this.txtActor3.Name = "txtActor3";
            this.txtActor3.PlaceholderText = "Actor/actriz 3";
            this.txtActor3.Size = new System.Drawing.Size(137, 23);
            this.txtActor3.TabIndex = 12;
            // 
            // txtActor2
            // 
            this.txtActor2.Location = new System.Drawing.Point(242, 333);
            this.txtActor2.Name = "txtActor2";
            this.txtActor2.PlaceholderText = "Actor/actriz 2";
            this.txtActor2.Size = new System.Drawing.Size(137, 23);
            this.txtActor2.TabIndex = 13;
            // 
            // txtTemporadas
            // 
            this.txtTemporadas.Location = new System.Drawing.Point(90, 206);
            this.txtTemporadas.Name = "txtTemporadas";
            this.txtTemporadas.PlaceholderText = "Temporadas";
            this.txtTemporadas.Size = new System.Drawing.Size(137, 23);
            this.txtTemporadas.TabIndex = 14;
            // 
            // txtAñoFinalizacion
            // 
            this.txtAñoFinalizacion.Location = new System.Drawing.Point(90, 150);
            this.txtAñoFinalizacion.Name = "txtAñoFinalizacion";
            this.txtAñoFinalizacion.PlaceholderText = "Año finalizacion";
            this.txtAñoFinalizacion.Size = new System.Drawing.Size(116, 23);
            this.txtAñoFinalizacion.TabIndex = 15;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Gold;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmar.Location = new System.Drawing.Point(90, 404);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(146, 34);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Agregar/modificar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gold;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(242, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 34);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Género";
            // 
            // lblAñofin
            // 
            this.lblAñofin.AutoSize = true;
            this.lblAñofin.Location = new System.Drawing.Point(90, 132);
            this.lblAñofin.Name = "lblAñofin";
            this.lblAñofin.Size = new System.Drawing.Size(92, 15);
            this.lblAñofin.TabIndex = 21;
            this.lblAñofin.Text = "Año finalización";
            // 
            // lblTempODuracion
            // 
            this.lblTempODuracion.AutoSize = true;
            this.lblTempODuracion.Location = new System.Drawing.Point(90, 188);
            this.lblTempODuracion.Name = "lblTempODuracion";
            this.lblTempODuracion.Size = new System.Drawing.Size(71, 15);
            this.lblTempODuracion.TabIndex = 22;
            this.lblTempODuracion.Text = "Temporadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Puntuación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Escritor/a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Actores/actrices";
            // 
            // FrmAltayModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(469, 455);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTempODuracion);
            this.Controls.Add(this.lblAñofin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtAñoFinalizacion);
            this.Controls.Add(this.txtTemporadas);
            this.Controls.Add(this.txtActor2);
            this.Controls.Add(this.txtActor3);
            this.Controls.Add(this.txtActor1);
            this.Controls.Add(this.txtEscritor);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTipoContenido);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAltayModificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltayModificacion";
            this.Load += new System.EventHandler(this.FrmAltayModificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoContenido;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtEscritor;
        private System.Windows.Forms.TextBox txtActor1;
        private System.Windows.Forms.TextBox txtActor3;
        private System.Windows.Forms.TextBox txtActor2;
        private System.Windows.Forms.TextBox txtTemporadas;
        private System.Windows.Forms.TextBox txtAñoFinalizacion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAñofin;
        private System.Windows.Forms.Label lblTempODuracion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}