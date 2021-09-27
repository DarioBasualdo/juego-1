
namespace tachodebasura
{
    partial class ganaste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ganaste));
            this.imgpapellista = new System.Windows.Forms.ImageList(this.components);
            this.imgtacholista = new System.Windows.Forms.ImageList(this.components);
            this.lbltacho = new System.Windows.Forms.Label();
            this.lblpapel = new System.Windows.Forms.Label();
            this.lblganaste = new System.Windows.Forms.Label();
            this.btvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imgpapellista
            // 
            this.imgpapellista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgpapellista.ImageStream")));
            this.imgpapellista.TransparentColor = System.Drawing.Color.Transparent;
            this.imgpapellista.Images.SetKeyName(0, "papel1.jpg");
            this.imgpapellista.Images.SetKeyName(1, "papel2.jpg");
            this.imgpapellista.Images.SetKeyName(2, "papel3.jpg");
            // 
            // imgtacholista
            // 
            this.imgtacholista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgtacholista.ImageStream")));
            this.imgtacholista.TransparentColor = System.Drawing.Color.Transparent;
            this.imgtacholista.Images.SetKeyName(0, "tacho1.jpg");
            this.imgtacholista.Images.SetKeyName(1, "tacho2.jpg");
            this.imgtacholista.Images.SetKeyName(2, "tacho3.jpg");
            this.imgtacholista.Images.SetKeyName(3, "tacho4.jpg");
            // 
            // lbltacho
            // 
            this.lbltacho.ImageIndex = 0;
            this.lbltacho.ImageList = this.imgtacholista;
            this.lbltacho.Location = new System.Drawing.Point(572, 252);
            this.lbltacho.Name = "lbltacho";
            this.lbltacho.Size = new System.Drawing.Size(100, 100);
            this.lbltacho.TabIndex = 4;
            // 
            // lblpapel
            // 
            this.lblpapel.ImageIndex = 0;
            this.lblpapel.ImageList = this.imgpapellista;
            this.lblpapel.Location = new System.Drawing.Point(12, 302);
            this.lblpapel.Name = "lblpapel";
            this.lblpapel.Size = new System.Drawing.Size(50, 50);
            this.lblpapel.TabIndex = 3;
            // 
            // lblganaste
            // 
            this.lblganaste.AutoSize = true;
            this.lblganaste.Font = new System.Drawing.Font("Onyx", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblganaste.Location = new System.Drawing.Point(162, 48);
            this.lblganaste.Name = "lblganaste";
            this.lblganaste.Size = new System.Drawing.Size(314, 149);
            this.lblganaste.TabIndex = 5;
            this.lblganaste.Text = "Ganaste";
            // 
            // btvolver
            // 
            this.btvolver.BackColor = System.Drawing.Color.Black;
            this.btvolver.Font = new System.Drawing.Font("Onyx", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvolver.ForeColor = System.Drawing.Color.Yellow;
            this.btvolver.Location = new System.Drawing.Point(187, 252);
            this.btvolver.Name = "btvolver";
            this.btvolver.Size = new System.Drawing.Size(255, 77);
            this.btvolver.TabIndex = 6;
            this.btvolver.Text = "VOLVER";
            this.btvolver.UseVisualStyleBackColor = false;
            this.btvolver.Click += new System.EventHandler(this.btvolver_Click);
            // 
            // ganaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btvolver);
            this.Controls.Add(this.lblganaste);
            this.Controls.Add(this.lbltacho);
            this.Controls.Add(this.lblpapel);
            this.Name = "ganaste";
            this.Text = "Ganaste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgpapellista;
        private System.Windows.Forms.ImageList imgtacholista;
        private System.Windows.Forms.Label lbltacho;
        private System.Windows.Forms.Label lblpapel;
        private System.Windows.Forms.Label lblganaste;
        private System.Windows.Forms.Button btvolver;
    }
}