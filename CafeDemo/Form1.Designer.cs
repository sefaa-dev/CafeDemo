
namespace CafeDemo
{
    partial class Form1
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
            this.btnMasalar = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMasalar
            // 
            this.btnMasalar.Location = new System.Drawing.Point(10, 18);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(86, 62);
            this.btnMasalar.TabIndex = 0;
            this.btnMasalar.Text = "MASALAR";
            this.btnMasalar.UseVisualStyleBackColor = true;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Location = new System.Drawing.Point(10, 110);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(86, 68);
            this.btnAyarlar.TabIndex = 1;
            this.btnAyarlar.Text = "AYARLAR";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(10, 216);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(85, 63);
            this.btnRaporlar.TabIndex = 2;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(10, 325);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(81, 60);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnRaporlar);
            this.groupBox1.Controls.Add(this.btnAyarlar);
            this.groupBox1.Controls.Add(this.btnMasalar);
            this.groupBox1.Location = new System.Drawing.Point(2, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 403);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasalar;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

