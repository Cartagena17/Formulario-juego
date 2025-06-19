namespace Pierda_papel_tijera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbJugador = new System.Windows.Forms.GroupBox();
            this.gbMaquina = new System.Windows.Forms.GroupBox();
            this.bdnPiedra = new System.Windows.Forms.RadioButton();
            this.rdnPapel = new System.Windows.Forms.RadioButton();
            this.rdnTijera = new System.Windows.Forms.RadioButton();
            this.rdnPiedramach = new System.Windows.Forms.RadioButton();
            this.rdnPapelmach = new System.Windows.Forms.RadioButton();
            this.rdnTijeramach = new System.Windows.Forms.RadioButton();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lbljugador = new System.Windows.Forms.Label();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.txtJugador = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbJugador.SuspendLayout();
            this.gbMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbJugador
            // 
            this.gbJugador.Controls.Add(this.rdnTijera);
            this.gbJugador.Controls.Add(this.rdnPapel);
            this.gbJugador.Controls.Add(this.bdnPiedra);
            this.gbJugador.Location = new System.Drawing.Point(80, 88);
            this.gbJugador.Name = "gbJugador";
            this.gbJugador.Size = new System.Drawing.Size(200, 299);
            this.gbJugador.TabIndex = 0;
            this.gbJugador.TabStop = false;
            this.gbJugador.Text = "Jugador:";
            // 
            // gbMaquina
            // 
            this.gbMaquina.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbMaquina.Controls.Add(this.rdnTijeramach);
            this.gbMaquina.Controls.Add(this.rdnPapelmach);
            this.gbMaquina.Controls.Add(this.rdnPiedramach);
            this.gbMaquina.Enabled = false;
            this.gbMaquina.Location = new System.Drawing.Point(560, 88);
            this.gbMaquina.Name = "gbMaquina";
            this.gbMaquina.Size = new System.Drawing.Size(200, 299);
            this.gbMaquina.TabIndex = 1;
            this.gbMaquina.TabStop = false;
            this.gbMaquina.Text = "Maquina";
            // 
            // bdnPiedra
            // 
            this.bdnPiedra.AutoSize = true;
            this.bdnPiedra.Location = new System.Drawing.Point(23, 50);
            this.bdnPiedra.Name = "bdnPiedra";
            this.bdnPiedra.Size = new System.Drawing.Size(55, 17);
            this.bdnPiedra.TabIndex = 0;
            this.bdnPiedra.TabStop = true;
            this.bdnPiedra.Text = "Piedra";
            this.bdnPiedra.UseVisualStyleBackColor = true;
            // 
            // rdnPapel
            // 
            this.rdnPapel.AutoSize = true;
            this.rdnPapel.Location = new System.Drawing.Point(23, 97);
            this.rdnPapel.Name = "rdnPapel";
            this.rdnPapel.Size = new System.Drawing.Size(52, 17);
            this.rdnPapel.TabIndex = 1;
            this.rdnPapel.TabStop = true;
            this.rdnPapel.Text = "Papel";
            this.rdnPapel.UseVisualStyleBackColor = true;
            // 
            // rdnTijera
            // 
            this.rdnTijera.AutoSize = true;
            this.rdnTijera.Location = new System.Drawing.Point(23, 157);
            this.rdnTijera.Name = "rdnTijera";
            this.rdnTijera.Size = new System.Drawing.Size(51, 17);
            this.rdnTijera.TabIndex = 2;
            this.rdnTijera.TabStop = true;
            this.rdnTijera.Text = "Tijera";
            this.rdnTijera.UseVisualStyleBackColor = true;
            // 
            // rdnPiedramach
            // 
            this.rdnPiedramach.AutoSize = true;
            this.rdnPiedramach.Location = new System.Drawing.Point(33, 50);
            this.rdnPiedramach.Name = "rdnPiedramach";
            this.rdnPiedramach.Size = new System.Drawing.Size(55, 17);
            this.rdnPiedramach.TabIndex = 0;
            this.rdnPiedramach.TabStop = true;
            this.rdnPiedramach.Text = "Piedra";
            this.rdnPiedramach.UseVisualStyleBackColor = true;
            // 
            // rdnPapelmach
            // 
            this.rdnPapelmach.AutoSize = true;
            this.rdnPapelmach.Location = new System.Drawing.Point(33, 97);
            this.rdnPapelmach.Name = "rdnPapelmach";
            this.rdnPapelmach.Size = new System.Drawing.Size(52, 17);
            this.rdnPapelmach.TabIndex = 1;
            this.rdnPapelmach.TabStop = true;
            this.rdnPapelmach.Text = "Papel";
            this.rdnPapelmach.UseVisualStyleBackColor = true;
            // 
            // rdnTijeramach
            // 
            this.rdnTijeramach.AutoSize = true;
            this.rdnTijeramach.Location = new System.Drawing.Point(33, 157);
            this.rdnTijeramach.Name = "rdnTijeramach";
            this.rdnTijeramach.Size = new System.Drawing.Size(51, 17);
            this.rdnTijeramach.TabIndex = 2;
            this.rdnTijeramach.TabStop = true;
            this.rdnTijeramach.Text = "Tijera";
            this.rdnTijeramach.UseVisualStyleBackColor = true;
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(560, 45);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(35, 13);
            this.lblMaquina.TabIndex = 2;
            this.lblMaquina.Text = "Score";
            // 
            // lbljugador
            // 
            this.lbljugador.AutoSize = true;
            this.lbljugador.Location = new System.Drawing.Point(80, 44);
            this.lbljugador.Name = "lbljugador";
            this.lbljugador.Size = new System.Drawing.Size(35, 13);
            this.lbljugador.TabIndex = 3;
            this.lbljugador.Text = "Score";
            // 
            // txtMaquina
            // 
            this.txtMaquina.Location = new System.Drawing.Point(602, 44);
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.Size = new System.Drawing.Size(100, 20);
            this.txtMaquina.TabIndex = 4;
            // 
            // txtJugador
            // 
            this.txtJugador.Location = new System.Drawing.Point(121, 41);
            this.txtJugador.Name = "txtJugador";
            this.txtJugador.Size = new System.Drawing.Size(100, 20);
            this.txtJugador.TabIndex = 5;
            // 
            // btnJugar
            // 
            this.btnJugar.ForeColor = System.Drawing.Color.Black;
            this.btnJugar.Location = new System.Drawing.Point(364, 355);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(104, 32);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Pierda_papel_tijera.Properties.Resources.icons8_swords_49;
            this.pictureBox1.Location = new System.Drawing.Point(377, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.txtJugador);
            this.Controls.Add(this.txtMaquina);
            this.Controls.Add(this.lbljugador);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.gbMaquina);
            this.Controls.Add(this.gbJugador);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbJugador.ResumeLayout(false);
            this.gbJugador.PerformLayout();
            this.gbMaquina.ResumeLayout(false);
            this.gbMaquina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJugador;
        private System.Windows.Forms.RadioButton rdnTijera;
        private System.Windows.Forms.RadioButton rdnPapel;
        private System.Windows.Forms.RadioButton bdnPiedra;
        private System.Windows.Forms.GroupBox gbMaquina;
        private System.Windows.Forms.RadioButton rdnTijeramach;
        private System.Windows.Forms.RadioButton rdnPapelmach;
        private System.Windows.Forms.RadioButton rdnPiedramach;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lbljugador;
        private System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.TextBox txtJugador;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

