
namespace Stok_Takip
{
    partial class Form2
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
            this.btnSatisIslemleri = new System.Windows.Forms.Button();
            this.btnDukkanIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSatisIslemleri
            // 
            this.btnSatisIslemleri.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatisIslemleri.Location = new System.Drawing.Point(48, 130);
            this.btnSatisIslemleri.Name = "btnSatisIslemleri";
            this.btnSatisIslemleri.Size = new System.Drawing.Size(108, 51);
            this.btnSatisIslemleri.TabIndex = 0;
            this.btnSatisIslemleri.Text = "Satış";
            this.btnSatisIslemleri.UseVisualStyleBackColor = true;
            this.btnSatisIslemleri.Click += new System.EventHandler(this.btnSatisIslemleri_Click);
            // 
            // btnDukkanIslemleri
            // 
            this.btnDukkanIslemleri.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDukkanIslemleri.Location = new System.Drawing.Point(212, 130);
            this.btnDukkanIslemleri.Name = "btnDukkanIslemleri";
            this.btnDukkanIslemleri.Size = new System.Drawing.Size(108, 51);
            this.btnDukkanIslemleri.TabIndex = 1;
            this.btnDukkanIslemleri.Text = "Dükkan";
            this.btnDukkanIslemleri.UseVisualStyleBackColor = true;
            this.btnDukkanIslemleri.Click += new System.EventHandler(this.btnDukkanIslemleri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(380, 322);
            this.Controls.Add(this.btnDukkanIslemleri);
            this.Controls.Add(this.btnSatisIslemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "İşlem Ekranı";
            this.ResumeLayout(false);

        }

        #endregion
      
      

        private System.Windows.Forms.Button btnSatisIslemleri;
        private System.Windows.Forms.Button btnDukkanIslemleri;
    }
}