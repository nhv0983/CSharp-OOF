namespace CSharp_OOF
{
    partial class FRmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FRmMain = new System.Windows.Forms.Button();
            this.txtTendangnhap = new System.Windows.Forms.Label();
            this.pas = new System.Windows.Forms.Label();
            this.txtdangnhap = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSharp_OOF.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FRmMain
            // 
            this.FRmMain.Location = new System.Drawing.Point(676, 251);
            this.FRmMain.Name = "FRmMain";
            this.FRmMain.Size = new System.Drawing.Size(142, 70);
            this.FRmMain.TabIndex = 1;
            this.FRmMain.Text = "Đăng nhập";
            this.FRmMain.UseVisualStyleBackColor = true;
            this.FRmMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.AutoSize = true;
            this.txtTendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendangnhap.Location = new System.Drawing.Point(481, 55);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(170, 25);
            this.txtTendangnhap.TabIndex = 2;
            this.txtTendangnhap.Text = "Tên đăng nhập";
            // 
            // pas
            // 
            this.pas.AutoSize = true;
            this.pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pas.Location = new System.Drawing.Point(481, 111);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(64, 25);
            this.pas.TabIndex = 3;
            this.pas.Text = "Pass";
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.Location = new System.Drawing.Point(675, 55);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(143, 20);
            this.txtdangnhap.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(675, 111);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(143, 20);
            this.txtpass.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 479);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtdangnhap);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.FRmMain);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FRmMain;
        private System.Windows.Forms.Label txtTendangnhap;
        private System.Windows.Forms.Label pas;
        private System.Windows.Forms.TextBox txtdangnhap;
        private System.Windows.Forms.TextBox txtpass;
    }
}

