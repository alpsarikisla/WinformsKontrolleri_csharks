namespace WindowsFormKontrolleri
{
    partial class ButtonKontrolu
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kurabiye = new System.Windows.Forms.Button();
            this.lbl_sayac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ben Bir Butonum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kurabiye
            // 
            this.btn_kurabiye.FlatAppearance.BorderSize = 0;
            this.btn_kurabiye.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_kurabiye.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_kurabiye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kurabiye.Image = global::WindowsFormKontrolleri.Properties.Resources.kurabiye;
            this.btn_kurabiye.Location = new System.Drawing.Point(12, 134);
            this.btn_kurabiye.Name = "btn_kurabiye";
            this.btn_kurabiye.Size = new System.Drawing.Size(145, 145);
            this.btn_kurabiye.TabIndex = 1;
            this.btn_kurabiye.UseVisualStyleBackColor = true;
            this.btn_kurabiye.Click += new System.EventHandler(this.btn_kurabiye_Click);
            // 
            // lbl_sayac
            // 
            this.lbl_sayac.AutoSize = true;
            this.lbl_sayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayac.Location = new System.Drawing.Point(200, 158);
            this.lbl_sayac.Name = "lbl_sayac";
            this.lbl_sayac.Size = new System.Drawing.Size(83, 91);
            this.lbl_sayac.TabIndex = 2;
            this.lbl_sayac.Text = "0";
            // 
            // ButtonKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_sayac);
            this.Controls.Add(this.btn_kurabiye);
            this.Controls.Add(this.button1);
            this.Name = "ButtonKontrolu";
            this.Text = "ButtonKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_kurabiye;
        private System.Windows.Forms.Label lbl_sayac;
    }
}