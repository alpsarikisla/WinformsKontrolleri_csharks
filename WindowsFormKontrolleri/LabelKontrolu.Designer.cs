namespace WindowsFormKontrolleri
{
    partial class LabelKontrolu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dogumYeri = new System.Windows.Forms.Label();
            this.lbl_duzen = new System.Windows.Forms.Label();
            this.lbl_renk = new System.Windows.Forms.Label();
            this.lbl_kodIleFont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yaş = 26";
            // 
            // lbl_dogumYeri
            // 
            this.lbl_dogumYeri.AutoSize = true;
            this.lbl_dogumYeri.Location = new System.Drawing.Point(12, 96);
            this.lbl_dogumYeri.Name = "lbl_dogumYeri";
            this.lbl_dogumYeri.Size = new System.Drawing.Size(113, 13);
            this.lbl_dogumYeri.TabIndex = 1;
            this.lbl_dogumYeri.Text = "Doğum Yeri = Balıkesir";
            // 
            // lbl_duzen
            // 
            this.lbl_duzen.AutoSize = true;
            this.lbl_duzen.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_duzen.Location = new System.Drawing.Point(12, 125);
            this.lbl_duzen.Name = "lbl_duzen";
            this.lbl_duzen.Size = new System.Drawing.Size(265, 24);
            this.lbl_duzen.TabIndex = 2;
            this.lbl_duzen.Text = "Font Properties İle Düzenlendi";
            // 
            // lbl_renk
            // 
            this.lbl_renk.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_renk.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_renk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_renk.ForeColor = System.Drawing.Color.White;
            this.lbl_renk.Location = new System.Drawing.Point(13, 171);
            this.lbl_renk.Name = "lbl_renk";
            this.lbl_renk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_renk.Size = new System.Drawing.Size(300, 30);
            this.lbl_renk.TabIndex = 3;
            this.lbl_renk.Text = "Renkler düzenlendi";
            // 
            // lbl_kodIleFont
            // 
            this.lbl_kodIleFont.AutoSize = true;
            this.lbl_kodIleFont.Location = new System.Drawing.Point(16, 229);
            this.lbl_kodIleFont.Name = "lbl_kodIleFont";
            this.lbl_kodIleFont.Size = new System.Drawing.Size(120, 13);
            this.lbl_kodIleFont.TabIndex = 4;
            this.lbl_kodIleFont.Text = "Font Kod İle Düzenlendi";
            // 
            // LabelKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_kodIleFont);
            this.Controls.Add(this.lbl_renk);
            this.Controls.Add(this.lbl_duzen);
            this.Controls.Add(this.lbl_dogumYeri);
            this.Controls.Add(this.label1);
            this.Name = "LabelKontrolu";
            this.Text = "LabelKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_dogumYeri;
        private System.Windows.Forms.Label lbl_duzen;
        private System.Windows.Forms.Label lbl_renk;
        private System.Windows.Forms.Label lbl_kodIleFont;
    }
}