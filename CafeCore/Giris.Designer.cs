
namespace CafeCore
{
    partial class Giris
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
            this.btnfrmKatEkle = new System.Windows.Forms.Button();
            this.btnfrmMenuEkle = new System.Windows.Forms.Button();
            this.btnfrmMasaEkle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfrmKatEkle
            // 
            this.btnfrmKatEkle.Location = new System.Drawing.Point(176, 73);
            this.btnfrmKatEkle.Name = "btnfrmKatEkle";
            this.btnfrmKatEkle.Size = new System.Drawing.Size(66, 62);
            this.btnfrmKatEkle.TabIndex = 0;
            this.btnfrmKatEkle.Text = "Kat Ekle";
            this.btnfrmKatEkle.UseVisualStyleBackColor = true;
            this.btnfrmKatEkle.Click += new System.EventHandler(this.btnfrmKatEkle_Click);
            // 
            // btnfrmMenuEkle
            // 
            this.btnfrmMenuEkle.Location = new System.Drawing.Point(262, 73);
            this.btnfrmMenuEkle.Name = "btnfrmMenuEkle";
            this.btnfrmMenuEkle.Size = new System.Drawing.Size(75, 62);
            this.btnfrmMenuEkle.TabIndex = 1;
            this.btnfrmMenuEkle.Text = "Menu Ekle";
            this.btnfrmMenuEkle.UseVisualStyleBackColor = true;
            this.btnfrmMenuEkle.Click += new System.EventHandler(this.btnfrmMenuEkle_Click);
            // 
            // btnfrmMasaEkle
            // 
            this.btnfrmMasaEkle.Location = new System.Drawing.Point(166, 141);
            this.btnfrmMasaEkle.Name = "btnfrmMasaEkle";
            this.btnfrmMasaEkle.Size = new System.Drawing.Size(76, 62);
            this.btnfrmMasaEkle.TabIndex = 2;
            this.btnfrmMasaEkle.Text = "Masa Ekle";
            this.btnfrmMasaEkle.UseVisualStyleBackColor = true;
            this.btnfrmMasaEkle.Click += new System.EventHandler(this.btnfrmMasaEkle_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 340);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnfrmMasaEkle);
            this.Controls.Add(this.btnfrmMenuEkle);
            this.Controls.Add(this.btnfrmKatEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfrmKatEkle;
        private System.Windows.Forms.Button btnfrmMenuEkle;
        private System.Windows.Forms.Button btnfrmMasaEkle;
        private System.Windows.Forms.Button button4;
    }
}

