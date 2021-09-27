
namespace tachodebasura
{
    partial class jugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jugar));
            this.imgpapellista = new System.Windows.Forms.ImageList(this.components);
            this.lblpapel = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.lbltacho = new System.Windows.Forms.Label();
            this.imgtacholista = new System.Windows.Forms.ImageList(this.components);
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
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
            // lblpapel
            // 
            this.lblpapel.ImageIndex = 0;
            this.lblpapel.ImageList = this.imgpapellista;
            this.lblpapel.Location = new System.Drawing.Point(50, 120);
            this.lblpapel.Name = "lblpapel";
            this.lblpapel.Size = new System.Drawing.Size(50, 50);
            this.lblpapel.TabIndex = 0;
            this.lblpapel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblpapel_MouseClick);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt1.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt1.Location = new System.Drawing.Point(38, 312);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(60, 65);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltacho
            // 
            this.lbltacho.ImageIndex = 0;
            this.lbltacho.ImageList = this.imgtacholista;
            this.lbltacho.Location = new System.Drawing.Point(600, 120);
            this.lbltacho.Name = "lbltacho";
            this.lbltacho.Size = new System.Drawing.Size(100, 100);
            this.lbltacho.TabIndex = 2;
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
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt6.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt6.Location = new System.Drawing.Point(94, 373);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(60, 65);
            this.bt6.TabIndex = 3;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt5.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt5.Location = new System.Drawing.Point(38, 373);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(60, 65);
            this.bt5.TabIndex = 4;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt3.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt3.Location = new System.Drawing.Point(150, 312);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(60, 65);
            this.bt3.TabIndex = 5;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt2.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt2.Location = new System.Drawing.Point(94, 312);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(60, 65);
            this.bt2.TabIndex = 6;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt4.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt4.Location = new System.Drawing.Point(206, 312);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(60, 65);
            this.bt4.TabIndex = 7;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt7.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt7.Location = new System.Drawing.Point(150, 373);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(60, 65);
            this.bt7.TabIndex = 7;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt8.Font = new System.Drawing.Font("Lucida Handwriting", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt8.Location = new System.Drawing.Point(206, 373);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(60, 65);
            this.bt8.TabIndex = 8;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.lbltacho);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lblpapel);
            this.Name = "jugar";
            this.Text = "Jugar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgpapellista;
        private System.Windows.Forms.Label lblpapel;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label lbltacho;
        private System.Windows.Forms.ImageList imgtacholista;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
    }
}