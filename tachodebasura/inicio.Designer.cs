
namespace tachodebasura
{
    partial class inicio
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
            this.btinicio = new System.Windows.Forms.Button();
            this.imgtacho = new System.Windows.Forms.PictureBox();
            this.imgpapel = new System.Windows.Forms.PictureBox();
            this.imgflecha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgtacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgflecha)).BeginInit();
            this.SuspendLayout();
            // 
            // btinicio
            // 
            this.btinicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btinicio.Font = new System.Drawing.Font("Mistral", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinicio.ForeColor = System.Drawing.Color.Green;
            this.btinicio.Location = new System.Drawing.Point(187, 201);
            this.btinicio.Name = "btinicio";
            this.btinicio.Size = new System.Drawing.Size(159, 77);
            this.btinicio.TabIndex = 0;
            this.btinicio.TabStop = false;
            this.btinicio.Text = "START";
            this.btinicio.UseVisualStyleBackColor = false;
            this.btinicio.Click += new System.EventHandler(this.btinicio_Click);
            // 
            // imgtacho
            // 
            this.imgtacho.Image = global::tachodebasura.Properties.Resources.tacho1;
            this.imgtacho.Location = new System.Drawing.Point(433, 128);
            this.imgtacho.Name = "imgtacho";
            this.imgtacho.Size = new System.Drawing.Size(118, 150);
            this.imgtacho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgtacho.TabIndex = 2;
            this.imgtacho.TabStop = false;
            // 
            // imgpapel
            // 
            this.imgpapel.Image = global::tachodebasura.Properties.Resources.papel1;
            this.imgpapel.Location = new System.Drawing.Point(30, 42);
            this.imgpapel.Name = "imgpapel";
            this.imgpapel.Size = new System.Drawing.Size(81, 81);
            this.imgpapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgpapel.TabIndex = 1;
            this.imgpapel.TabStop = false;
            // 
            // imgflecha
            // 
            this.imgflecha.Image = global::tachodebasura.Properties.Resources.flecha;
            this.imgflecha.Location = new System.Drawing.Point(132, 42);
            this.imgflecha.Name = "imgflecha";
            this.imgflecha.Size = new System.Drawing.Size(333, 64);
            this.imgflecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgflecha.TabIndex = 0;
            this.imgflecha.TabStop = false;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.imgflecha);
            this.Controls.Add(this.imgpapel);
            this.Controls.Add(this.imgtacho);
            this.Controls.Add(this.btinicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "inicio";
            this.Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)(this.imgtacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgflecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btinicio;
        private System.Windows.Forms.PictureBox imgtacho;
        private System.Windows.Forms.PictureBox imgpapel;
        private System.Windows.Forms.PictureBox imgflecha;
    }
}

