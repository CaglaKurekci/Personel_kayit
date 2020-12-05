namespace Personel_kayit
{
    partial class Frmistatistik
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
            this.LblToplamPersonel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblEvliPersonel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblBekarPersonel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSehirSayi = new System.Windows.Forms.Label();
            this.LblToplamMaas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblOrtMaas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı:";
            this.label1.Click += new System.EventHandler(this.LblToplamPersonel_Click);
            // 
            // LblToplamPersonel
            // 
            this.LblToplamPersonel.AutoSize = true;
            this.LblToplamPersonel.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamPersonel.Location = new System.Drawing.Point(300, 39);
            this.LblToplamPersonel.Name = "LblToplamPersonel";
            this.LblToplamPersonel.Size = new System.Drawing.Size(25, 29);
            this.LblToplamPersonel.TabIndex = 1;
            this.LblToplamPersonel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Evli Personel Sayısı:";
            // 
            // LblEvliPersonel
            // 
            this.LblEvliPersonel.AutoSize = true;
            this.LblEvliPersonel.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEvliPersonel.Location = new System.Drawing.Point(300, 109);
            this.LblEvliPersonel.Name = "LblEvliPersonel";
            this.LblEvliPersonel.Size = new System.Drawing.Size(25, 29);
            this.LblEvliPersonel.TabIndex = 3;
            this.LblEvliPersonel.Text = "0";
            this.LblEvliPersonel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bekar Personel Sayısı:";
            // 
            // LblBekarPersonel
            // 
            this.LblBekarPersonel.AutoSize = true;
            this.LblBekarPersonel.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBekarPersonel.Location = new System.Drawing.Point(300, 190);
            this.LblBekarPersonel.Name = "LblBekarPersonel";
            this.LblBekarPersonel.Size = new System.Drawing.Size(25, 29);
            this.LblBekarPersonel.TabIndex = 5;
            this.LblBekarPersonel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şehir Sayısı:";
            // 
            // LblSehirSayi
            // 
            this.LblSehirSayi.AutoSize = true;
            this.LblSehirSayi.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSehirSayi.Location = new System.Drawing.Point(300, 261);
            this.LblSehirSayi.Name = "LblSehirSayi";
            this.LblSehirSayi.Size = new System.Drawing.Size(25, 29);
            this.LblSehirSayi.TabIndex = 7;
            this.LblSehirSayi.Text = "0";
            // 
            // LblToplamMaas
            // 
            this.LblToplamMaas.AutoSize = true;
            this.LblToplamMaas.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamMaas.Location = new System.Drawing.Point(300, 324);
            this.LblToplamMaas.Name = "LblToplamMaas";
            this.LblToplamMaas.Size = new System.Drawing.Size(25, 29);
            this.LblToplamMaas.TabIndex = 9;
            this.LblToplamMaas.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toplam Maaş:";
            // 
            // LblOrtMaas
            // 
            this.LblOrtMaas.AutoSize = true;
            this.LblOrtMaas.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrtMaas.Location = new System.Drawing.Point(300, 386);
            this.LblOrtMaas.Name = "LblOrtMaas";
            this.LblOrtMaas.Size = new System.Drawing.Size(25, 29);
            this.LblOrtMaas.TabIndex = 11;
            this.LblOrtMaas.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ortalama Maaş:";
            // 
            // Frmistatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 472);
            this.Controls.Add(this.LblOrtMaas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblToplamMaas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSehirSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblBekarPersonel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblEvliPersonel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblToplamPersonel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frmistatistik";
            this.Text = "Frmistatistik";
            this.Load += new System.EventHandler(this.Frmistatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblToplamPersonel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblEvliPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblBekarPersonel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSehirSayi;
        private System.Windows.Forms.Label LblToplamMaas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblOrtMaas;
        private System.Windows.Forms.Label label6;
    }
}