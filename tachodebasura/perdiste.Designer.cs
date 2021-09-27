
namespace tachodebasura
{
    partial class perdiste
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
            this.btvolver = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btvolver
            // 
            this.btvolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btvolver.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvolver.ForeColor = System.Drawing.Color.Red;
            this.btvolver.Location = new System.Drawing.Point(486, 225);
            this.btvolver.Name = "btvolver";
            this.btvolver.Size = new System.Drawing.Size(86, 24);
            this.btvolver.TabIndex = 0;
            this.btvolver.Text = "Volver";
            this.btvolver.UseVisualStyleBackColor = false;
            this.btvolver.Click += new System.EventHandler(this.btvolver_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Black;
            this.lblmensaje.Font = new System.Drawing.Font("Impact", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.ForeColor = System.Drawing.Color.Red;
            this.lblmensaje.Location = new System.Drawing.Point(56, 25);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(448, 132);
            this.lblmensaje.TabIndex = 1;
            this.lblmensaje.Text = "PERDISTE";
            // 
            // perdiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btvolver);
            this.Name = "perdiste";
            this.Text = "Perdiste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvolver;
        private System.Windows.Forms.Label lblmensaje;
    }
}