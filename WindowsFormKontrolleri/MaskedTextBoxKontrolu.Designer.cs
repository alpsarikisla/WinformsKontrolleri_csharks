namespace WindowsFormKontrolleri
{
    partial class MaskedTextBoxKontrolu
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
            this.mtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_kimlik = new System.Windows.Forms.MaskedTextBox();
            this.btn_Goster = new System.Windows.Forms.Button();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_kimlik = new System.Windows.Forms.Label();
            this.mtb_iban = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_iban = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon Numarası:";
            // 
            // mtb_telefon
            // 
            this.mtb_telefon.Location = new System.Drawing.Point(15, 53);
            this.mtb_telefon.Mask = "(999) 000-0000";
            this.mtb_telefon.Name = "mtb_telefon";
            this.mtb_telefon.Size = new System.Drawing.Size(205, 20);
            this.mtb_telefon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC Kimlik No:";
            // 
            // mtb_kimlik
            // 
            this.mtb_kimlik.Location = new System.Drawing.Point(15, 106);
            this.mtb_kimlik.Mask = "00000000000";
            this.mtb_kimlik.Name = "mtb_kimlik";
            this.mtb_kimlik.Size = new System.Drawing.Size(205, 20);
            this.mtb_kimlik.TabIndex = 3;
            // 
            // btn_Goster
            // 
            this.btn_Goster.Location = new System.Drawing.Point(145, 182);
            this.btn_Goster.Name = "btn_Goster";
            this.btn_Goster.Size = new System.Drawing.Size(75, 23);
            this.btn_Goster.TabIndex = 4;
            this.btn_Goster.Text = "Göster";
            this.btn_Goster.UseVisualStyleBackColor = true;
            this.btn_Goster.Click += new System.EventHandler(this.btn_Goster_Click);
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(237, 56);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(55, 13);
            this.lbl_telefon.TabIndex = 5;
            this.lbl_telefon.Text = "Telefon = ";
            // 
            // lbl_kimlik
            // 
            this.lbl_kimlik.AutoSize = true;
            this.lbl_kimlik.Location = new System.Drawing.Point(237, 109);
            this.lbl_kimlik.Name = "lbl_kimlik";
            this.lbl_kimlik.Size = new System.Drawing.Size(60, 13);
            this.lbl_kimlik.TabIndex = 6;
            this.lbl_kimlik.Text = "Kimlik No =";
            // 
            // mtb_iban
            // 
            this.mtb_iban.Location = new System.Drawing.Point(15, 156);
            this.mtb_iban.Mask = "TR00-0000-0000-0000-0000-00";
            this.mtb_iban.Name = "mtb_iban";
            this.mtb_iban.Size = new System.Drawing.Size(205, 20);
            this.mtb_iban.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IBAN =";
            // 
            // lbl_iban
            // 
            this.lbl_iban.AutoSize = true;
            this.lbl_iban.Location = new System.Drawing.Point(237, 159);
            this.lbl_iban.Name = "lbl_iban";
            this.lbl_iban.Size = new System.Drawing.Size(41, 13);
            this.lbl_iban.TabIndex = 6;
            this.lbl_iban.Text = "IBAN =";
            // 
            // MaskedTextBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb_iban);
            this.Controls.Add(this.lbl_iban);
            this.Controls.Add(this.lbl_kimlik);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.btn_Goster);
            this.Controls.Add(this.mtb_kimlik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_telefon);
            this.Controls.Add(this.label1);
            this.Name = "MaskedTextBoxKontrolu";
            this.Text = "MaskedTextBoxKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_telefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_kimlik;
        private System.Windows.Forms.Button btn_Goster;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_kimlik;
        private System.Windows.Forms.MaskedTextBox mtb_iban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_iban;
    }
}